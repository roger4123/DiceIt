import pandas as pd
import numpy as np
from sklearn.ensemble import RandomForestClassifier
import m2cgen as m2c
import os

csv_path = 'DemonstrationData.csv'
if not os.path.exists(csv_path):
    print(f"Error: {csv_path} not found.")
    exit(1)

df = pd.read_csv(csv_path)
print(f"Loaded {len(df)} rows of training data.")

df = df[df['ActionType'] != 'GameOver'].copy()

phase_map = {
    'Upkeep': 0,
    'Income': 1,
    'MainPhase1': 2,
    'OffensiveRollPhase': 3,
    'DefensiveRollPhase': 4,
    'Resolution': 5,
    'MainPhase2': 6,
    'Cleanup': 7
}
df['TurnPhase_Encoded'] = df['TurnPhase'].map(phase_map).fillna(0).astype(int)

# mapping actions to strategic stances
# 0 = Standard, 1 = Aggressive, 2 = Defensive
def map_action_to_stance(row):
    action = row['ActionType']
    detail = str(row['ActionDetail'])
        
    match action:
        case 'ActivateDefense':
            return 2  # Defensive
        case 'ActivateOffense':
            return 1  # Aggressive
                
        case 'PlayCard':
            defensive_cards = ["Better D!", "Invisible Punch!", "Kinetic Therapy!", "Nice Try!", "Not This Time!", "Swing Escape!", "Yikes!", "Milkshake Me!", "Yibambe!", "Vibin!"]
            aggressive_cards = ["Ambush!", "Web Shooters!", "Strength Of Will!", "Radioactive Blood!", "Warrior Of Wakanda!"]
                
            if any(dc in detail for dc in defensive_cards):
                return 2
            elif any(ac in detail for ac in aggressive_cards):
                return 1
            else:
                return 0  # Standard (draw, CP, upgrades)
                    
        case 'SpendToken':
            defensive_tokens = ["Invisibility", "Vibranium Suit"]
            aggressive_tokens = ["Combo", "Kinetic Energy", "Webbed"]
                
            if any(dt in detail for dt in defensive_tokens):
                return 2
            elif any(at in detail for at in aggressive_tokens):
                return 1
            else:
                return 0  # Standard
                    
        case _:
            # default to Standard (rolls, locking, priority passes)
            return 0

df['Stance'] = df.apply(map_action_to_stance, axis=1)

print("\n First 10 rows of the dataset with mapped Stance")
preview_columns = ['ActionType', 'ActionDetail', 'TurnPhase', 'PlayerHP', 'PlayerCP', 'Stance']
print(df[preview_columns].head(10))

# extracting Feature Matrix
X = pd.DataFrame()

MAX_HP = 50.0
MAX_CP = 15.0

X['IsMyTurn'] = df['IsMyTurn'].astype(float)
X['PlayerHP_Ratio'] = df['PlayerHP'] / MAX_HP
X['PlayerCP_Ratio'] = df['PlayerCP'] / MAX_CP
X['OpponentHP_Ratio'] = df['OpponentHP'] / MAX_HP
X['OpponentCP_Ratio'] = df['OpponentCP'] / MAX_CP

X['PlayerPosTokens'] = df['PlayerPosTokens'].astype(float)
X['PlayerNegTokens'] = df['PlayerNegTokens'].astype(float)
X['OppPosTokens'] = df['OppPosTokens'].astype(float)
X['OppNegTokens'] = df['OppNegTokens'].astype(float)

X['RollsLeft'] = df['RollsLeft'].astype(float)
X['HandSize'] = df['HandSize'].astype(float)
X['OpponentHandSize'] = df['OpponentHandSize'].astype(float)
X['TurnPhase'] = df['TurnPhase_Encoded'].astype(float)

X['HealthDifference'] = X['PlayerHP_Ratio'] - X['OpponentHP_Ratio']
X['CPDifference'] = X['PlayerCP_Ratio'] - X['OpponentCP_Ratio']


# extracting Target Vector
y = df['Stance'].values

print("Feature vector columns:")
print(list(X.columns))
print(f"Features shape: {X.shape}, Target shape: {y.shape}")
print(f"Stance distribution (0=Standard, 1=Aggressive, 2=Defensive):")
print(pd.Series(y).value_counts())

# training & evaluation split
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report, accuracy_score

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42, stratify=y)

print("\nStarting training.")
model = RandomForestClassifier(n_estimators=50, max_depth=8, class_weight='balanced', random_state=42)
model.fit(X_train, y_train)

# metrics
y_pred = model.predict(X_test)
accuracy = accuracy_score(y_test, y_pred)
print(f"Overall Accuracy: {accuracy:.2%}")
print("\nClassification Report:")
print(classification_report(y_test, y_pred, target_names=['Standard (0)', 'Aggressive (1)', 'Defensive (2)']))

print("\nRetraining model on full dataset for C# export.")
model.fit(X, y)
print("Model training completed successfully.")

# exporting
print("Exporting  model to C#.")
rf_model = m2c.export_to_c_sharp(model, class_name="RFBrain", method_name="Score")

csharp_filename = 'RFBrain.cs'
with open(csharp_filename, 'w') as f:
    f.write(rf_model)

print(f"Generated {csharp_filename} successfully!")
