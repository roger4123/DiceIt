
# 🎲 DiceIt!

![Unity](https://img.shields.io/badge/Unity-2022.3%2B-black?style=flat-square&logo=unity)
![C#](https://img.shields.io/badge/Language-C%23-blue?style=flat-square&logo=csharp)
![AI](https://img.shields.io/badge/AI-Behavioral_Cloning-purple?style=flat-square)
![Architecture](https://img.shields.io/badge/Architecture-Event--Driven-green?style=flat-square)

**DiceIt!** is a highly interactive, turn-based card and dice strategy game built in
Unity. Beyond the gameplay, this project serves as a showcase for advanced **Software
Systems Architecture** and a state-of-the-art **Hierarchical Hybrid AI** capable of
mimicking human strategy while executing mathematically perfect probability mechanics.
    
    ---
    
## 🎮 Gameplay Overview
In *DiceIt!*, players duel using a combination of resource management, ability cards,
and dice rolls. The game is highly interactive, allowing players to respond to opponent
attacks with instant cards, stack status effects, and mitigate RNG (Random Number
Generation) by strategically locking dice.
    
    <img width="1603" height="900" alt="Screenshot 2026-06-18 225626" src="https://github.com/user-attachments/assets/496a07e4-57fd-40da-a76a-3b119b78b513" />

    
## 🧠 The AI Engine (DiceBot)
The crown jewel of this project is the AI opponent. Traditional game AI relies on
predictable, hardcoded rules. *DiceIt!* uses a **Hierarchical Hybrid Model** that blends
Machine Learning with a deterministic Utility system.
    
### 1. The Macro-Strategist (Behavioral Cloning)
*   **Imitation Learning:** The AI's high-level strategy is powered by a Random Forest
Classifier trained on a dataset of human gameplay. 
*   **Context Awareness:** By reading a 15-variable array of the board state (HP, CP,
Phase, Statuses), the ML model predicts the optimal human "Stance" (Aggressive, Defensive,
or Standard).
*   **Zero-Dependency Transpilation:** The Python-trained ML model was transpiled into
pure, native C# using `m2cgen`. This allows the AI to evaluate complex decision trees in
microseconds natively on the CPU, without bloating the game with external neural network
libraries.
    
### 2. The Micro-Executioner (Utility & Probability)
*   **Unbounded Heuristics:** The AI translates disparate mechanics (healing vs.
drawing cards vs. dealing damage) into a universal mathematical currency ("Utility
Score"), scaling its math dynamically based on the ML's chosen Stance.
*   **Minimax & Monte Carlo Solver:** To conquer the RNG of the dice, the AI generates
$2^N$ bitmask combinations for defensive locking. It executes a perfect-information 
state-space search for 1-3 dice, and dynamically falls back to a Monte Carlo
approximation for 4+ dice, calculating the exact Expected Value (EV) of every timeline
without dropping frames.
*   **Hyper-Awareness:** The bot actively reads opponent passives and status stack
limits to prevent wasting resources on "blindspot" setups.
    
    
## 🏗️ Systems Architecture
*DiceIt!* was engineered to prevent "spaghetti code" and easily scale for future
expansions.

*   **Finite State Machine (FSM):** The game's macro-flow is strictly governed by a
phase-based state machine, preventing illegal moves and providing context to the AI.
*   **Action Stack & Priority Manager:** The micro-flow is handled by an asynchronous
LIFO (Last-In, First-Out) stack. Priority passes between players allow for deep
interactivity (e.g., casting shields in response to attacks). The FSM mathematically
halts until the stack is empty, preventing race conditions.
*   **Event-Driven Observer Pattern:** C# Delegates are used to completely decouple the
core rules engine from the UI and Audio systems.
*   **Data-Driven Design:** Cards, Abilities, and Status Effects are isolated as
`ScriptableObjects`, making the game infinitely scalable without requiring new logic
scripts.

    

    ## 🚀 Getting Started

    ### Prerequisites
    *   Unity Editor (Version 2022.3 or higher recommended)
    *   Git

    ### Installation
    1. Clone the repository:
       ```bash
       git clone https://github.com/YourUsername/DiceIt.git

  2. Open the project in Unity Hub.
  3. Navigate to  Assets/_DiceIt/Scenes/  and open the  MainScene .
  4. Press Play in the Unity Editor to start a match against the AI!
  ──────
  ## 🗺️ Future Roadmap

  • Server-Authoritative Multiplayer: Migrating the rules engine and RNG to a dedicated
  backend to support online matchmaking and eliminate client-side cheating.
  • Self-Play RL AI Personas: Upgrading the ML pipeline to use Reinforcement Learning (PPO),
  allowing the bot to discover optimal meta-strategies and generating distinct AI
  difficulty personas.
  • JSON Modding Support: Transitioning data from ScriptableObjects to JSON loading to
  allow community-driven custom card and hero creation.
