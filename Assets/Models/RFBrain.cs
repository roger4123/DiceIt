namespace ML {
    public static class RFBrain {
        public static double[] Score(double[] input) {
            double[] var0;
            if (input[12] <= 3.5) {
                if (input[12] <= 2.5) {
                    if (input[13] <= -0.14999999850988388) {
                        if (input[5] <= 0.5) {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[14] <= -0.03333333507180214) {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var0 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[10] <= 4.5) {
                                var0 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[4] <= 0.10000000521540642) {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var0 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[13] <= -0.009999999776482582) {
                            if (input[13] <= -0.029999999329447746) {
                                var0 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 0.5) {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var0 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 0.5) {
                                var0 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var0 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[9] <= 2.5) {
                        if (input[11] <= 4.5) {
                            if (input[1] <= 0.8499999940395355) {
                                if (input[11] <= 3.5) {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[13] <= 0.009999999776482582) {
                                            var0 = new double[3] {0.29019500886403926, 0.7098049911359607, 0.0};
                                        } else {
                                            var0 = new double[3] {0.8466094951816816, 0.15339050481831848, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var0 = new double[3] {0.2098923214784128, 0.7901076785215873, 0.0};
                                        } else {
                                            var0 = new double[3] {0.44474923421569945, 0.5552507657843005, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var0 = new double[3] {0.5982866404260245, 0.4017133595739754, 0.0};
                                        } else {
                                            var0 = new double[3] {0.17966903073286053, 0.8203309692671396, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.7199999988079071) {
                                            var0 = new double[3] {0.5362698455123751, 0.46373015448762495, 0.0};
                                        } else {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.10000000521540642) {
                                        if (input[6] <= 0.5) {
                                            var0 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        } else {
                                            var0 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var0 = new double[3] {0.18841799981289173, 0.8115820001871081, 0.0};
                                        } else {
                                            var0 = new double[3] {0.5886351062989014, 0.4113648937010986, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                var0 = new double[3] {0.0, 1.0, 0.0};
                            } else {
                                if (input[1] <= 0.3999999910593033) {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[3] <= 0.4699999839067459) {
                                            var0 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var0 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.6099999845027924) {
                                            var0 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        } else {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var0 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[11] <= 5.5) {
                    if (input[12] <= 5.0) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[0] <= 0.5) {
                                if (input[11] <= 3.5) {
                                    if (input[8] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var0 = new double[3] {0.6540378863409771, 0.0, 0.34596211365902296};
                                        } else {
                                            var0 = new double[3] {0.09676187831881443, 0.0, 0.9032381216811854};
                                        }
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {0.011677584733694105, 0.0, 0.9883224152663059};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[5] <= 0.5) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {0.14193867457962414, 0.0, 0.8580613254203758};
                                        }
                                    } else {
                                        if (input[1] <= 0.25999999791383743) {
                                            var0 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var0 = new double[3] {0.041669428426238934, 0.0, 0.958330571573761};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 0.5) {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.019999999552965164) {
                                        if (input[5] <= 0.5) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {0.28835110746513537, 0.7116488925348647, 0.0};
                                        }
                                    } else {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.7400000095367432) {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[1] <= 0.17999999970197678) {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 1.5) {
                                            var0 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var0 = new double[3] {0.18697282099343956, 0.8130271790065604, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.3699999898672104) {
                                        if (input[5] <= 1.5) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var0 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        } else {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= 0.03999999910593033) {
                                    if (input[5] <= 0.5) {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.019999999552965164) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.7999999821186066) {
                                        if (input[1] <= 0.9500000178813934) {
                                            var0 = new double[3] {0.10567010309278352, 0.0, 0.8943298969072165};
                                        } else {
                                            var0 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.5) {
                            if (input[10] <= 3.5) {
                                if (input[11] <= 3.5) {
                                    if (input[0] <= 0.5) {
                                        if (input[11] <= 0.5) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var0 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        } else {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var0 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.10000000521540642) {
                                var0 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[1] <= 0.9399999976158142) {
                                        var0 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var0 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var0 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    }
                                } else {
                                    var0 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var0 = new double[3] {1.0, 0.0, 0.0};
                }
            }
            double[] var1;
            if (input[12] <= 3.5) {
                if (input[12] <= 2.5) {
                    if (input[1] <= 0.1900000050663948) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[5] <= 0.5) {
                                if (input[13] <= -0.14999999850988388) {
                                    var1 = new double[3] {0.0, 0.0, 1.0};
                                } else {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var1 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var1 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[13] <= -0.17000000178813934) {
                            if (input[4] <= 0.10000000521540642) {
                                var1 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 4.5) {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var1 = new double[3] {0.0, 0.0, 1.0};
                                }
                            }
                        } else {
                            var1 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.23333334177732468) {
                        if (input[9] <= 0.5) {
                            if (input[0] <= 0.5) {
                                var1 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[8] <= 0.5) {
                                    if (input[1] <= 0.6700000166893005) {
                                        if (input[7] <= 4.5) {
                                            var1 = new double[3] {0.08668187401298472, 0.9133181259870153, 0.0};
                                        } else {
                                            var1 = new double[3] {0.19698231972600205, 0.803017680273998, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var1 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.08999999798834324) {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 5.5) {
                                            var1 = new double[3] {0.1246215943491423, 0.8753784056508578, 0.0};
                                        } else {
                                            var1 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                var1 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[13] <= 0.04999999888241291) {
                                    if (input[3] <= 0.45000000298023224) {
                                        if (input[9] <= 2.5) {
                                            var1 = new double[3] {0.3277572817169518, 0.6722427182830482, 0.0};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.7000000178813934) {
                                            var1 = new double[3] {0.7002591419522023, 0.29974085804779765, 0.0};
                                        } else {
                                            var1 = new double[3] {0.45776628689945154, 0.5422337131005485, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[3] <= 0.699999988079071) {
                                            var1 = new double[3] {0.8378959170326077, 0.16210408296739234, 0.0};
                                        } else {
                                            var1 = new double[3] {0.243129271484659, 0.7568707285153411, 0.0};
                                        }
                                    } else {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var1 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[9] <= 0.5) {
                                    if (input[3] <= 0.21999999321997166) {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.10999999940395355) {
                                            var1 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var1 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 5.5) {
                                        if (input[13] <= -0.16999999806284904) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {0.10459315327713746, 0.8954068467228625, 0.0};
                                        }
                                    } else {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= 2.5) {
                    if (input[13] <= -0.04999999888241291) {
                        if (input[9] <= 0.5) {
                            if (input[0] <= 0.5) {
                                var1 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 1.5) {
                                    if (input[1] <= 0.6500000059604645) {
                                        if (input[1] <= 0.4999999850988388) {
                                            var1 = new double[3] {0.466973886328725, 0.5330261136712751, 0.0};
                                        } else {
                                            var1 = new double[3] {0.06803939122649955, 0.9319606087735004, 0.0};
                                        }
                                    } else {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.6500000059604645) {
                                        if (input[3] <= 0.5600000023841858) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[4] <= 0.03333333507180214) {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 6.5) {
                                        if (input[4] <= 0.23333334177732468) {
                                            var1 = new double[3] {0.07301869991095282, 0.0, 0.9269813000890472};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.1100000012665987) {
                                            var1 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        } else {
                                            var1 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 1.5) {
                                    if (input[8] <= 0.5) {
                                        if (input[7] <= 1.0) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {0.3251653053286659, 0.6748346946713342, 0.0};
                                        }
                                    } else {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var1 = new double[3] {0.0, 1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[13] <= 0.14999999850988388) {
                                if (input[8] <= 0.5) {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[3] <= 0.22999999672174454) {
                                            var1 = new double[3] {0.23500881834215165, 0.0, 0.7649911816578483};
                                        } else {
                                            var1 = new double[3] {0.6164050409020562, 0.0, 0.3835949590979439};
                                        }
                                    } else {
                                        if (input[13] <= 0.12999999895691872) {
                                            var1 = new double[3] {0.6162919277552524, 0.3837080722447475, 0.0};
                                        } else {
                                            var1 = new double[3] {0.19114219114219116, 0.0, 0.8088578088578089};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.029999999329447746) {
                                            var1 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var1 = new double[3] {0.3420553659461509, 0.0, 0.6579446340538491};
                                        }
                                    }
                                }
                            } else {
                                if (input[11] <= 2.0) {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[7] <= 0.5) {
                                if (input[3] <= 0.12999999895691872) {
                                    var1 = new double[3] {0.0, 0.0, 1.0};
                                } else {
                                    if (input[13] <= 0.019999999552965164) {
                                        if (input[11] <= 3.0) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[10] <= 4.5) {
                                    if (input[8] <= 0.5) {
                                        if (input[11] <= 5.5) {
                                            var1 = new double[3] {0.057577403585008166, 0.0, 0.9424225964149919};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.1666666716337204) {
                        if (input[14] <= -0.1666666716337204) {
                            var1 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[4] <= 0.1666666716337204) {
                                    var1 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.019999999552965164) {
                                        var1 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 3.0) {
                                            var1 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[11] <= 2.5) {
                                            var1 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        } else {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var1 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                } else {
                                    if (input[3] <= 0.2199999988079071) {
                                        if (input[11] <= 2.0) {
                                            var1 = new double[3] {0.011677584733694105, 0.0, 0.9883224152663059};
                                        } else {
                                            var1 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        if (input[1] <= 0.32999999821186066) {
                                            var1 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var1 = new double[3] {0.09804533166978581, 0.0, 0.9019546683302141};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var1 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            double[] var2;
            if (input[13] <= 0.009999999776482582) {
                if (input[12] <= 3.5) {
                    if (input[11] <= 2.5) {
                        if (input[0] <= 0.5) {
                            var2 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[12] <= 2.5) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.10183014099089498, 0.8981698590091051, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 4.5) {
                                            var2 = new double[3] {0.46116725196492964, 0.5388327480350703, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var2 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[6] <= 0.5) {
                                if (input[1] <= 0.7100000083446503) {
                                    if (input[1] <= 0.6100000143051147) {
                                        if (input[12] <= 2.5) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.13475923976284143, 0.8652407602371586, 0.0};
                                        }
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.7400000095367432) {
                                        if (input[7] <= 4.0) {
                                            var2 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.14909269249632173, 0.8509073075036784, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    if (input[1] <= 0.44999998807907104) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= -0.06999999843537807) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var2 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.6899999976158142) {
                                if (input[1] <= 0.3999999910593033) {
                                    if (input[13] <= -0.06999999843537807) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.3700000047683716) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[10] <= 3.5) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.5982866404260245, 0.4017133595739754, 0.0};
                                        }
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.12999999895691872) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 4.5) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.4065055819883695, 0.5934944180116305, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.7700000107288361) {
                                            var2 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.03333333507180214) {
                        if (input[13] <= -0.06999999843537807) {
                            if (input[0] <= 0.5) {
                                var2 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 0.5) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[6] <= 0.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var2 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.3999999910593033) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[3] <= 0.2499999925494194) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[7] <= 1.5) {
                                    if (input[6] <= 0.5) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[8] <= 0.5) {
                                            var2 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var2 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 4.5) {
                            if (input[7] <= 0.5) {
                                if (input[11] <= 3.5) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[14] <= 0.10000000521540642) {
                                            var2 = new double[3] {0.5125035122225344, 0.4874964877774657, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= -0.1666666716337204) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.10000000521540642) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.27000000327825546) {
                                            var2 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var2 = new double[3] {0.25429123255624164, 0.38701341095182396, 0.35869535649193435};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.3699999898672104) {
                                    if (input[12] <= 5.0) {
                                        if (input[5] <= 1.5) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.2499999925494194) {
                                        if (input[11] <= 1.5) {
                                            var2 = new double[3] {0.10567010309278352, 0.0, 0.8943298969072165};
                                        } else {
                                            var2 = new double[3] {0.22602230483271377, 0.7739776951672863, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.8699999749660492) {
                                            var2 = new double[3] {0.18922092910846117, 0.07447783847622055, 0.7363012324153184};
                                        } else {
                                            var2 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= -0.14999999850988388) {
                                var2 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var2 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= 0.26999999582767487) {
                    if (input[13] <= 0.1899999976158142) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[1] <= 0.21000000089406967) {
                                if (input[0] <= 0.5) {
                                    if (input[7] <= 0.5) {
                                        if (input[13] <= 0.04999999888241291) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.09999999962747097) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328564};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[13] <= 0.04999999888241291) {
                                            var2 = new double[3] {0.243129271484659, 0.7568707285153411, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    if (input[11] <= 2.0) {
                                        if (input[13] <= 0.10999999940395355) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        }
                                    } else {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 5.0) {
                                            var2 = new double[3] {0.018554135083154205, 0.0, 0.9814458649168458};
                                        } else {
                                            var2 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    }
                                }
                            }
                        } else {
                            var2 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            var2 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 2.5) {
                                var2 = new double[3] {0.0, 1.0, 0.0};
                            } else {
                                var2 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.8799999952316284) {
                        if (input[0] <= 0.5) {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[12] <= 3.5) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var2 = new double[3] {0.5606482653836414, 0.0, 0.4393517346163586};
                                        }
                                    } else {
                                        if (input[13] <= 0.4399999976158142) {
                                            var2 = new double[3] {0.08523266498953048, 0.0, 0.9147673350104696};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.39000000059604645) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[14] <= 0.23333334177732468) {
                                if (input[9] <= 2.5) {
                                    if (input[9] <= 1.5) {
                                        if (input[12] <= 3.5) {
                                            var2 = new double[3] {0.3198745589964719, 0.6801254410035282, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var2 = new double[3] {0.3150414528227398, 0.6849585471772601, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= 0.06999999843537807) {
                                    var2 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 3.5) {
                            if (input[2] <= 0.13333334028720856) {
                                if (input[4] <= 0.10000000521540642) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var2 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                }
                            } else {
                                if (input[5] <= 0.5) {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[13] <= 0.05999999865889549) {
                                var2 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[8] <= 0.5) {
                                    if (input[1] <= 0.9900000095367432) {
                                        var2 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var2 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var2 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var2 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var3;
            if (input[12] <= 3.5) {
                if (input[3] <= 0.3100000023841858) {
                    if (input[13] <= 0.06999999843537807) {
                        if (input[9] <= 1.5) {
                            if (input[3] <= 0.2499999925494194) {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[0] <= 0.5) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var3 = new double[3] {0.43158239598121656, 0.5684176040187835, 0.0};
                                        } else {
                                            var3 = new double[3] {0.22950528466115994, 0.7704947153388401, 0.0};
                                        }
                                    }
                                } else {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[10] <= 3.5) {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[9] <= 2.5) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 2.5) {
                                        var3 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.10000000521540642) {
                            if (input[5] <= 5.5) {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 0.5) {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 0.5) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var3 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[10] <= 3.5) {
                        if (input[12] <= 2.5) {
                            if (input[13] <= -0.009999999776482582) {
                                if (input[11] <= 1.5) {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.45000000298023224) {
                                        if (input[1] <= 0.3799999952316284) {
                                            var3 = new double[3] {0.27436219155165203, 0.0, 0.7256378084483479};
                                        } else {
                                            var3 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[14] <= -0.10000000521540642) {
                                        if (input[1] <= 0.6800000071525574) {
                                            var3 = new double[3] {0.04993976563355602, 0.9500602343664439, 0.0};
                                        } else {
                                            var3 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var3 = new double[3] {0.1673488976088982, 0.8326511023911018, 0.0};
                                        } else {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[5] <= 3.5) {
                                            var3 = new double[3] {0.2314507198228127, 0.7685492801771873, 0.0};
                                        } else {
                                            var3 = new double[3] {0.05989852716614945, 0.9401014728338505, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.3700000047683716) {
                                            var3 = new double[3] {0.3445409897997733, 0.6554590102002267, 0.0};
                                        } else {
                                            var3 = new double[3] {0.8423730353411466, 0.15762696465885354, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 2.5) {
                            var3 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[13] <= 0.06999999843537807) {
                                if (input[5] <= 2.5) {
                                    if (input[9] <= 0.5) {
                                        if (input[0] <= 0.5) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.09423127120856171, 0.9057687287914382, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.6599999964237213) {
                                            var3 = new double[3] {0.7779910428662827, 0.2220089571337172, 0.0};
                                        } else {
                                            var3 = new double[3] {0.2985040143244961, 0.701495985675504, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[3] <= 0.9600000083446503) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var3 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= -0.03333333507180214) {
                                    if (input[0] <= 0.5) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.03333333507180214) {
                    if (input[14] <= 0.1666666716337204) {
                        if (input[5] <= 0.5) {
                            if (input[7] <= 5.5) {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    if (input[10] <= 3.5) {
                                        if (input[3] <= 0.5400000065565109) {
                                            var3 = new double[3] {0.05124599640653074, 0.0, 0.9487540035934693};
                                        } else {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[12] <= 5.0) {
                                if (input[3] <= 0.3999999910593033) {
                                    if (input[9] <= 0.5) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.3199999928474426) {
                                            var3 = new double[3] {0.4148397976391231, 0.0, 0.5851602023608768};
                                        } else {
                                            var3 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[10] <= 0.5) {
                            if (input[9] <= 0.5) {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var3 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                            }
                        } else {
                            if (input[5] <= 1.5) {
                                if (input[11] <= 2.5) {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.5600000023841858) {
                                        if (input[5] <= 0.5) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 2.5) {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var3 = new double[3] {0.0, 1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[10] <= 4.5) {
                        if (input[8] <= 0.5) {
                            if (input[7] <= 0.5) {
                                if (input[5] <= 3.5) {
                                    if (input[13] <= -0.05999999865889549) {
                                        if (input[10] <= 3.5) {
                                            var3 = new double[3] {0.398196323274367, 0.0, 0.6018036767256331};
                                        } else {
                                            var3 = new double[3] {0.08636124275934702, 0.0, 0.9136387572406529};
                                        }
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var3 = new double[3] {0.26170212765957446, 0.0, 0.7382978723404255};
                                        } else {
                                            var3 = new double[3] {0.5054631828978622, 0.49453681710213776, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 5.0) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.10999999940395355) {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[10] <= 3.5) {
                                            var3 = new double[3] {0.1498826965646155, 0.09504622753640647, 0.7550710758989782};
                                        } else {
                                            var3 = new double[3] {0.5695857107417515, 0.0, 0.4304142892582486};
                                        }
                                    } else {
                                        if (input[13] <= -0.06999999843537807) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.07973833097595474, 0.0, 0.9202616690240453};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[12] <= 5.0) {
                                    if (input[1] <= 0.4000000059604645) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.3200000077486038) {
                                            var3 = new double[3] {0.04819749216300941, 0.0, 0.9518025078369906};
                                        } else {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.23999999463558197) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.3999999910593033) {
                                    if (input[14] <= 0.06666667014360428) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= 0.03333333507180214) {
                            if (input[10] <= 5.5) {
                                if (input[13] <= 0.03999999910593033) {
                                    var3 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var3 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                }
                            } else {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 0.35999999940395355) {
                                var3 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.23333334177732468) {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[6] <= 0.5) {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.12000000104308128) {
                                            var3 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var3 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var3 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var3 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var4;
            if (input[13] <= 0.029999999329447746) {
                if (input[1] <= 0.26999999582767487) {
                    if (input[8] <= 0.5) {
                        if (input[13] <= -0.06999999843537807) {
                            if (input[9] <= 0.5) {
                                if (input[1] <= 0.2199999988079071) {
                                    if (input[13] <= -0.14999999850988388) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.10999999940395355) {
                                            var4 = new double[3] {0.19886101277512697, 0.801138987224873, 0.0};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 0.2199999988079071) {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[9] <= 2.5) {
                                            var4 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[10] <= 1.5) {
                                if (input[5] <= 5.0) {
                                    if (input[2] <= 0.13333333656191826) {
                                        if (input[9] <= 0.5) {
                                            var4 = new double[3] {0.4148397976391231, 0.0, 0.5851602023608768};
                                        } else {
                                            var4 = new double[3] {0.05124599640653074, 0.0, 0.9487540035934693};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        }
                                    }
                                } else {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    if (input[9] <= 0.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var4 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[11] <= 0.5) {
                                            var4 = new double[3] {0.22602230483271377, 0.7739776951672863, 0.0};
                                        } else {
                                            var4 = new double[3] {0.7103989317309297, 0.2896010682690703, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var4 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 1.5) {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[12] <= 3.5) {
                                        if (input[7] <= 3.5) {
                                            var4 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var4 = new double[3] {0.3445409897997733, 0.6554590102002267, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[9] <= 2.5) {
                        if (input[3] <= 0.4699999988079071) {
                            if (input[9] <= 1.5) {
                                if (input[10] <= 5.5) {
                                    if (input[8] <= 0.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var4 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[5] <= 2.5) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.45000000298023224) {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[3] <= 0.4299999922513962) {
                                            var4 = new double[3] {0.1305748442980886, 0.8694251557019114, 0.0};
                                        } else {
                                            var4 = new double[3] {0.014391213785267941, 0.985608786214732, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[9] <= 0.5) {
                                    if (input[1] <= 0.5300000011920929) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var4 = new double[3] {0.6247025740860913, 0.37529742591390874, 0.0};
                                        } else {
                                            var4 = new double[3] {0.13143403267646658, 0.8685659673235335, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var4 = new double[3] {0.21538183243389913, 0.7846181675661009, 0.0};
                                        } else {
                                            var4 = new double[3] {0.44695907178375627, 0.3779113009477666, 0.17512962726847722};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 1.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var4 = new double[3] {0.3763728583409877, 0.6236271416590123, 0.0};
                                        } else {
                                            var4 = new double[3] {0.7902309273364768, 0.20976907266352318, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[8] <= 0.5) {
                                    if (input[0] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {0.19626312538604077, 0.0, 0.8037368746139592};
                                        }
                                    } else {
                                        if (input[5] <= 2.5) {
                                            var4 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.14999999850988388) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 1.5) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {0.0814030443414957, 0.0, 0.9185969556585043};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var4 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[12] <= 3.5) {
                    if (input[9] <= 1.5) {
                        if (input[0] <= 0.5) {
                            var4 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[13] <= 0.04999999888241291) {
                                if (input[10] <= 2.5) {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[5] <= 4.0) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.029999999329447746) {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[1] <= 0.3500000089406967) {
                                            var4 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        } else {
                                            var4 = new double[3] {0.27131457370852585, 0.7286854262914743, 0.0};
                                        }
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.23333334177732468) {
                            if (input[10] <= 3.5) {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 2.5) {
                                    if (input[1] <= 0.5600000023841858) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.1099999975413084) {
                                            var4 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[6] <= 0.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 2.5) {
                                var4 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                            } else {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[9] <= 0.5) {
                        if (input[1] <= 0.2499999925494194) {
                            if (input[3] <= 0.17999999970197678) {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 6.5) {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 2.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var4 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.1666666716337204) {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 2.5) {
                                    var4 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.12999999895691872) {
                                        if (input[4] <= 0.10000000521540642) {
                                            var4 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 5.0) {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[7] <= 0.5) {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[13] <= 0.29999999701976776) {
                                    if (input[11] <= 2.5) {
                                        if (input[3] <= 0.5300000160932541) {
                                            var4 = new double[3] {0.11686857375547187, 0.0, 0.8831314262445282};
                                        } else {
                                            var4 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 5.5) {
                                            var4 = new double[3] {0.07405886941171644, 0.0, 0.9259411305882836};
                                        } else {
                                            var4 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 0.5) {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var4 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var4 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var5;
            if (input[3] <= 0.6899999976158142) {
                if (input[9] <= 0.5) {
                    if (input[3] <= 0.13999999687075615) {
                        var5 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[2] <= 0.03333333507180214) {
                            if (input[10] <= 0.5) {
                                if (input[4] <= 0.1666666716337204) {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.3100000023841858) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var5 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[7] <= 5.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.49000000953674316) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[14] <= 0.23333334177732468) {
                                if (input[0] <= 0.5) {
                                    if (input[10] <= 2.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.08999999985098839) {
                                            var5 = new double[3] {0.5365918803418803, 0.0, 0.4634081196581197};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[12] <= 2.5) {
                                            var5 = new double[3] {0.6849464318140548, 0.0, 0.3150535681859452};
                                        } else {
                                            var5 = new double[3] {0.18251181736658917, 0.8174881826334108, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.06999999843537807) {
                                            var5 = new double[3] {0.2503316636160128, 0.4633628410815599, 0.28630549530242727};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 2.0) {
                                    var5 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    if (input[12] <= 2.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.4699999839067459) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.06999999843537807) {
                        if (input[10] <= 0.5) {
                            if (input[8] <= 0.5) {
                                if (input[7] <= 0.5) {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 3.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var5 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        } else {
                                            var5 = new double[3] {0.03423323128305037, 0.0, 0.9657667687169496};
                                        }
                                    }
                                }
                            } else {
                                var5 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[12] <= 3.5) {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.1666666716337204) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.07030329010824136, 0.0, 0.9296967098917586};
                                        }
                                    }
                                }
                            } else {
                                if (input[11] <= 4.5) {
                                    if (input[1] <= 0.13999999687075615) {
                                        if (input[11] <= 0.5) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.575898313370814, 0.42410168662918607, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.3500000089406967) {
                                            var5 = new double[3] {0.2114396683515362, 0.7885603316484637, 0.0};
                                        } else {
                                            var5 = new double[3] {0.4791353947763431, 0.520864605223657, 0.0};
                                        }
                                    }
                                } else {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.3100000023841858) {
                            if (input[12] <= 3.5) {
                                if (input[6] <= 0.5) {
                                    if (input[10] <= 3.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var5 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.23333334177732468) {
                                    if (input[5] <= 0.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.25999999791383743) {
                                            var5 = new double[3] {0.0326563122262047, 0.0, 0.9673436877737953};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                if (input[11] <= 5.5) {
                                    if (input[13] <= 0.3400000035762787) {
                                        if (input[12] <= 3.5) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.041802965291643665, 0.0, 0.9581970347083563};
                                        }
                                    } else {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[14] <= -0.03333333507180214) {
                                    if (input[3] <= 0.42000000178813934) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var5 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.10999999940395355) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    if (input[9] <= 0.5) {
                        var5 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[3] <= 0.7299999892711639) {
                            var5 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[7] <= 0.5) {
                                if (input[1] <= 0.8100000023841858) {
                                    if (input[12] <= 3.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var5 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                    }
                                } else {
                                    if (input[13] <= -0.12000000104308128) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 4.5) {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[1] <= 0.9399999976158142) {
                                            var5 = new double[3] {0.2865953947368421, 0.0, 0.7134046052631579};
                                        } else {
                                            var5 = new double[3] {0.0536707756081597, 0.0, 0.9463292243918402};
                                        }
                                    } else {
                                        if (input[2] <= 0.20000001043081284) {
                                            var5 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var5 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        }
                                    }
                                } else {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.9699999988079071) {
                        if (input[13] <= -0.17000000178813934) {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[3] <= 0.8799999952316284) {
                                    if (input[11] <= 1.5) {
                                        if (input[13] <= -0.3700000047683716) {
                                            var5 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var5 = new double[3] {0.2019727091531661, 0.798027290846834, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 2.5) {
                                        if (input[12] <= 2.5) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.1697240389216781, 0.8302759610783219, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 3.0) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var5 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                if (input[13] <= -0.04999999888241291) {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var5 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[11] <= 2.5) {
                                    if (input[1] <= 0.7199999988079071) {
                                        if (input[5] <= 5.5) {
                                            var5 = new double[3] {0.18937860146394642, 0.8106213985360535, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= 0.0) {
                                        if (input[13] <= -0.09999999776482582) {
                                            var5 = new double[3] {0.5732557186193326, 0.4267442813806674, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var5 = new double[3] {0.47399194421586044, 0.5260080557841397, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.5) {
                            if (input[10] <= 3.5) {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[12] <= 2.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var5 = new double[3] {0.5836333093352531, 0.4163666906647468, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 2.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var5 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var5 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 1.5) {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var5 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var5 = new double[3] {0.2713145737085258, 0.7286854262914741, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 3.5) {
                                if (input[5] <= 2.5) {
                                    if (input[1] <= 0.8799999952316284) {
                                        if (input[9] <= 1.5) {
                                            var5 = new double[3] {0.11386155470053458, 0.8861384452994654, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.9900000095367432) {
                                            var5 = new double[3] {0.5836333093352531, 0.4163666906647468, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        if (input[2] <= 0.06666667014360428) {
                                            var5 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var5 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var5 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[9] <= 0.5) {
                                    if (input[2] <= 0.20000001043081284) {
                                        var5 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                    } else {
                                        var5 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    var5 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var6;
            if (input[9] <= 0.5) {
                if (input[12] <= 2.5) {
                    if (input[11] <= 3.5) {
                        if (input[2] <= 0.10000000521540642) {
                            var6 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= 0.1666666716337204) {
                                if (input[13] <= 0.0) {
                                    if (input[13] <= -0.1900000050663948) {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.12417970721857648, 0.0, 0.8758202927814235};
                                        }
                                    }
                                } else {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var6 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        var6 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[2] <= 0.03333333507180214) {
                        if (input[3] <= 0.6100000143051147) {
                            if (input[1] <= 0.75) {
                                if (input[0] <= 0.5) {
                                    if (input[8] <= 0.5) {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.17999999970197678) {
                                        if (input[11] <= 0.5) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 4.5) {
                                        var6 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.4699999988079071) {
                                var6 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 5.5) {
                                    if (input[12] <= 3.5) {
                                        if (input[0] <= 0.5) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.17373083150776264, 0.8262691684922373, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var6 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[7] <= 0.5) {
                            if (input[1] <= 0.7100000083446503) {
                                if (input[3] <= 0.9300000071525574) {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[11] <= 1.5) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.19414770088248953, 0.8058522991175104, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var6 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.03333333507180214) {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[13] <= -0.17000000178813934) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.11123307720453712, 0.8887669227954629, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.1666666716337204) {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[11] <= 2.5) {
                                        if (input[5] <= 3.5) {
                                            var6 = new double[3] {0.3445409897997734, 0.6554590102002267, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.09999999776482582) {
                                            var6 = new double[3] {0.2748620670101252, 0.44820083295354063, 0.27693710003633404};
                                        } else {
                                            var6 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.19698231972600203, 0.8030176802739979, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.1826062376330915, 0.8173937623669086, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.1666666716337204) {
                                    if (input[3] <= 0.3999999910593033) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {0.03423323128305037, 0.0, 0.9657667687169496};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var6 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        } else {
                                            var6 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[6] <= 0.5) {
                                            var6 = new double[3] {0.010832383124287344, 0.9891676168757126, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[13] <= 0.06999999843537807) {
                    if (input[5] <= 1.5) {
                        if (input[0] <= 0.5) {
                            if (input[12] <= 3.5) {
                                var6 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= -0.1666666716337204) {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[4] <= 0.1666666716337204) {
                                            var6 = new double[3] {0.12719040831726336, 0.0, 0.8728095916827365};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.949999988079071) {
                                            var6 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        } else {
                                            var6 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= -0.029999999329447746) {
                                if (input[8] <= 0.5) {
                                    if (input[3] <= 0.9900000095367432) {
                                        if (input[7] <= 2.5) {
                                            var6 = new double[3] {0.37528933696826294, 0.6247106630317372, 0.0};
                                        } else {
                                            var6 = new double[3] {0.49575354409532707, 0.5042464559046729, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= -0.1666666716337204) {
                                        if (input[9] <= 2.0) {
                                            var6 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 6.5) {
                                        if (input[9] <= 2.5) {
                                            var6 = new double[3] {0.2225076927673048, 0.7774923072326951, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.03333333507180214) {
                            if (input[5] <= 5.5) {
                                if (input[9] <= 2.5) {
                                    if (input[11] <= 2.5) {
                                        if (input[13] <= 0.009999999776482582) {
                                            var6 = new double[3] {0.11302690895570944, 0.8869730910442907, 0.0};
                                        } else {
                                            var6 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[3] <= 0.6100000068545341) {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[9] <= 2.5) {
                                    if (input[11] <= 3.5) {
                                        if (input[4] <= 0.23333334177732468) {
                                            var6 = new double[3] {0.3801357627724187, 0.6198642372275812, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.3700000047683716) {
                                            var6 = new double[3] {0.6119436367702975, 0.38805636322970255, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[10] <= 2.5) {
                                    if (input[1] <= 0.17999999970197678) {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 4.5) {
                                            var6 = new double[3] {0.03722948090601826, 0.0, 0.9627705190939818};
                                        } else {
                                            var6 = new double[3] {0.17538022813688212, 0.0, 0.8246197718631179};
                                        }
                                    }
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[0] <= 0.5) {
                                            var6 = new double[3] {0.040317128633765596, 0.0, 0.9596828713662344};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 1.5) {
                                            var6 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.10000000521540642) {
                        if (input[5] <= 6.5) {
                            if (input[13] <= 0.10999999940395355) {
                                if (input[10] <= 4.0) {
                                    if (input[14] <= -0.06666667014360428) {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var6 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                }
                            } else {
                                if (input[7] <= 6.5) {
                                    if (input[7] <= 0.5) {
                                        if (input[1] <= 0.4100000113248825) {
                                            var6 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var6 = new double[3] {0.05753474265538004, 0.0, 0.94246525734462};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var6 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[10] <= 4.5) {
                                if (input[5] <= 0.5) {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[8] <= 0.5) {
                                            var6 = new double[3] {0.04870693594078407, 0.0, 0.9512930640592159};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var6 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[13] <= 0.08999999985098839) {
                                var6 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[11] <= 3.5) {
                                        var6 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var6 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var6 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var6 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var7;
            if (input[0] <= 0.5) {
                if (input[3] <= 0.6899999976158142) {
                    if (input[5] <= 0.5) {
                        if (input[12] <= 3.5) {
                            var7 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 0.5) {
                                var7 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= -0.1666666716337204) {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 6.5) {
                                        if (input[7] <= 2.5) {
                                            var7 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328564};
                                        } else {
                                            var7 = new double[3] {0.26170212765957446, 0.0, 0.7382978723404255};
                                        }
                                    } else {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[13] <= -0.17999999970197678) {
                            var7 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 3.5) {
                                if (input[3] <= 0.3500000089406967) {
                                    if (input[3] <= 0.28999999165534973) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var7 = new double[3] {0.2136868343530478, 0.0, 0.7863131656469522};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[1] <= 0.7699999809265137) {
                                            var7 = new double[3] {0.1271904083172633, 0.0, 0.8728095916827368};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 4.5) {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[12] <= 5.0) {
                                            var7 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var7 = new double[3] {0.26170212765957446, 0.0, 0.7382978723404255};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= 0.9099999964237213) {
                        if (input[9] <= 0.5) {
                            var7 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[13] <= -0.14999999850988388) {
                                if (input[12] <= 3.5) {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 3.5) {
                                        if (input[7] <= 2.0) {
                                            var7 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var7 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var7 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[10] <= 2.5) {
                            var7 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[11] <= 3.5) {
                                var7 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 4.5) {
                                    if (input[4] <= 0.20000001043081284) {
                                        if (input[7] <= 2.5) {
                                            var7 = new double[3] {0.14441704825642832, 0.0, 0.8555829517435717};
                                        } else {
                                            var7 = new double[3] {0.0536707756081597, 0.0, 0.9463292243918402};
                                        }
                                    } else {
                                        if (input[2] <= 0.06666667014360428) {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[12] <= 2.5) {
                    if (input[7] <= 0.5) {
                        var7 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[8] <= 0.5) {
                            if (input[4] <= 0.10000000521540642) {
                                if (input[11] <= 2.5) {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[1] <= 0.25999999791383743) {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.4399999976158142) {
                                            var7 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.14999999850988388) {
                                        if (input[7] <= 2.5) {
                                            var7 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        } else {
                                            var7 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[10] <= 1.5) {
                                var7 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var7 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.22999999672174454) {
                        if (input[7] <= 2.5) {
                            if (input[14] <= 0.10000000521540642) {
                                if (input[12] <= 3.5) {
                                    if (input[5] <= 6.5) {
                                        if (input[10] <= 2.0) {
                                            var7 = new double[3] {0.27517058905444924, 0.7248294109455509, 0.0};
                                        } else {
                                            var7 = new double[3] {0.09512882027745906, 0.9048711797225409, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var7 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var7 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[4] <= 0.03333333507180214) {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var7 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[7] <= 6.5) {
                                            var7 = new double[3] {0.5508672016567434, 0.44913279834325653, 0.0};
                                        } else {
                                            var7 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[4] <= 0.10000000521540642) {
                                    if (input[7] <= 4.0) {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.17999999970197678) {
                                        var7 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var7 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[2] <= 0.30000001192092896) {
                            if (input[10] <= 0.5) {
                                if (input[13] <= -0.3699999898672104) {
                                    var7 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                } else {
                                    var7 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[14] <= 0.23333334177732468) {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[12] <= 3.5) {
                                            var7 = new double[3] {0.2835376706964553, 0.7164623293035446, 0.0};
                                        } else {
                                            var7 = new double[3] {0.4811085634532945, 0.5188914365467056, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.5300000011920929) {
                                            var7 = new double[3] {0.3572288598684815, 0.6427711401315185, 0.0};
                                        } else {
                                            var7 = new double[3] {0.5152638343049781, 0.4847361656950219, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.4299999922513962) {
                                        if (input[11] <= 2.5) {
                                            var7 = new double[3] {0.49075432932198415, 0.509245670678016, 0.0};
                                        } else {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var7 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var7 = new double[3] {0.11233016883633674, 0.8876698311636633, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var7 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var8;
            if (input[13] <= 0.009999999776482582) {
                if (input[5] <= 2.5) {
                    if (input[10] <= 2.5) {
                        if (input[0] <= 0.5) {
                            if (input[9] <= 0.5) {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 3.5) {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.03999999910593033) {
                                        var8 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                    } else {
                                        if (input[11] <= 0.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.0498935199269851, 0.0, 0.9501064800730149};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                if (input[14] <= 0.03333333507180214) {
                                    if (input[7] <= 5.0) {
                                        if (input[1] <= 0.32999999821186066) {
                                            var8 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.28999999165534973) {
                                    if (input[9] <= 0.5) {
                                        if (input[7] <= 0.5) {
                                            var8 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var8 = new double[3] {0.2689812083930227, 0.7310187916069772, 0.0};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[5] <= 1.5) {
                                            var8 = new double[3] {0.2552953251842866, 0.7447046748157135, 0.0};
                                        } else {
                                            var8 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 2.5) {
                            var8 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[9] <= 2.5) {
                                    if (input[10] <= 5.5) {
                                        if (input[7] <= 6.5) {
                                            var8 = new double[3] {0.2194061187762447, 0.7805938812237552, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[1] <= 0.45000000298023224) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.4699999988079071) {
                                            var8 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var8 = new double[3] {0.3046092184368738, 0.6953907815631263, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[7] <= 0.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.26170212765957446, 0.0, 0.7382978723404254};
                                        }
                                    } else {
                                        if (input[14] <= 0.10000000521540642) {
                                            var8 = new double[3] {0.35685160014827594, 0.6431483998517241, 0.0};
                                        } else {
                                            var8 = new double[3] {0.1992356970110953, 0.8007643029889048, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[0] <= 0.5) {
                            var8 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 3.5) {
                                if (input[3] <= 0.6800000071525574) {
                                    if (input[11] <= 0.5) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 6.5) {
                                            var8 = new double[3] {0.5324710320668283, 0.4675289679331716, 0.0};
                                        } else {
                                            var8 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        var8 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.1899999976158142) {
                                            var8 = new double[3] {0.02143260011280316, 0.9785673998871969, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.4699999839067459) {
                                    if (input[1] <= 0.3799999952316284) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 5.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.5499999821186066) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.9300000071525574) {
                            if (input[10] <= 3.5) {
                                if (input[0] <= 0.5) {
                                    if (input[14] <= -0.03333333507180214) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.07999999821186066) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 5.5) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= -0.06666667014360428) {
                                    if (input[11] <= 2.5) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                } else {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.23333334177732468) {
                    if (input[14] <= -0.03333333507180214) {
                        if (input[1] <= 0.7899999916553497) {
                            if (input[8] <= 0.5) {
                                if (input[13] <= 0.26000000536441803) {
                                    if (input[10] <= 5.0) {
                                        if (input[12] <= 3.5) {
                                            var8 = new double[3] {0.6893835412066599, 0.31061645879334016, 0.0};
                                        } else {
                                            var8 = new double[3] {0.08963707914298209, 0.0, 0.9103629208570179};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.23999999463558197) {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.4599999934434891) {
                                        var8 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.8799999952316284) {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[0] <= 0.5) {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var8 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= 0.03333333507180214) {
                            if (input[13] <= 0.09999999776482582) {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.75) {
                                    if (input[8] <= 0.5) {
                                        if (input[10] <= 2.0) {
                                            var8 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        } else {
                                            var8 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.19114219114219114, 0.0, 0.8088578088578089};
                                        }
                                    }
                                } else {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= 0.9900000095367432) {
                                if (input[9] <= 0.5) {
                                    if (input[5] <= 4.5) {
                                        if (input[3] <= 0.8100000023841858) {
                                            var8 = new double[3] {0.6627110392577463, 0.11819527684130257, 0.21909368390095113};
                                        } else {
                                            var8 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[5] <= 4.5) {
                                            var8 = new double[3] {0.12175615023791041, 0.0, 0.8782438497620895};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var8 = new double[3] {0.5508672016567435, 0.44913279834325653, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[8] <= 0.5) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= 0.12999999895691872) {
                                        if (input[9] <= 1.5) {
                                            var8 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.03333333507180214) {
                        var8 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[11] <= 2.0) {
                            if (input[12] <= 2.5) {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[9] <= 1.0) {
                                        var8 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var8 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.8599999845027924) {
                                var8 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[9] <= 1.5) {
                                        if (input[12] <= 2.5) {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var8 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var8 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var8 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var9;
            if (input[1] <= 0.04999999888241291) {
                if (input[8] <= 0.5) {
                    if (input[9] <= 0.5) {
                        var9 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[1] <= 0.029999999329447746) {
                            if (input[14] <= 0.23333334177732468) {
                                var9 = new double[3] {0.0, 0.0, 1.0};
                            } else {
                                var9 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var9 = new double[3] {0.0, 0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.23333334177732468) {
                        var9 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[13] <= -0.3699999898672104) {
                            if (input[12] <= 3.5) {
                                if (input[9] <= 0.5) {
                                    var9 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var9 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                var9 = new double[3] {0.0, 1.0, 0.0};
                            } else {
                                if (input[9] <= 1.5) {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[11] <= 2.5) {
                    if (input[12] <= 3.5) {
                        if (input[0] <= 0.5) {
                            var9 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= 0.1666666716337204) {
                                if (input[1] <= 0.8400000035762787) {
                                    if (input[12] <= 2.5) {
                                        if (input[1] <= 0.1900000050663948) {
                                            var9 = new double[3] {0.3420553659461509, 0.0, 0.6579446340538491};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var9 = new double[3] {0.20418059104907896, 0.7958194089509211, 0.0};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 2.5) {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[9] <= 2.5) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[6] <= 0.5) {
                                            var9 = new double[3] {0.717564707797493, 0.28243529220250696, 0.0};
                                        } else {
                                            var9 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 5.0) {
                            if (input[0] <= 0.5) {
                                if (input[14] <= -0.1666666716337204) {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.08999999798834324) {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 0.5) {
                                            var9 = new double[3] {0.32093933463796476, 0.0, 0.6790606653620352};
                                        } else {
                                            var9 = new double[3] {0.09072381063297039, 0.0, 0.9092761893670297};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.22999999672174454) {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.08999999985098839) {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= -0.03333333507180214) {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var9 = new double[3] {0.19698231972600203, 0.8030176802739979, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.03333333507180214) {
                                if (input[5] <= 0.5) {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[13] <= -0.27000000327825546) {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.30000000447034836) {
                                            var9 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var9 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[13] <= -0.21000000089406967) {
                            if (input[7] <= 0.5) {
                                var9 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 2.5) {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.7199999988079071) {
                                        if (input[7] <= 1.5) {
                                            var9 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var9 = new double[3] {0.1329335332333833, 0.8670664667666167, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.8600000143051147) {
                                            var9 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var9 = new double[3] {0.02143260011280316, 0.9785673998871969, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                if (input[7] <= 0.5) {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var9 = new double[3] {0.3135962020308585, 0.0, 0.6864037979691415};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 1.5) {
                                    if (input[1] <= 0.29999999701976776) {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var9 = new double[3] {0.2901950088640388, 0.7098049911359612, 0.0};
                                        } else {
                                            var9 = new double[3] {0.2260223048327138, 0.7739776951672863, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.9900000095367432) {
                                        if (input[4] <= 0.23333334177732468) {
                                            var9 = new double[3] {0.8003222465185864, 0.19967775348141356, 0.0};
                                        } else {
                                            var9 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var9 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.6899999976158142) {
                            if (input[12] <= 5.0) {
                                if (input[10] <= 4.5) {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[13] <= -0.04999999888241291) {
                                            var9 = new double[3] {0.15725162910113993, 0.14957871518118301, 0.6931696557176772};
                                        } else {
                                            var9 = new double[3] {0.09126620400680896, 0.0, 0.9087337959931909};
                                        }
                                    } else {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var9 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var9 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.09999999962747097) {
                                        if (input[10] <= 3.5) {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var9 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.6500000059604645) {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var9 = new double[3] {0.0, 0.35042735042735046, 0.6495726495726496};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.7899999916553497) {
                                if (input[11] <= 3.5) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[1] <= 0.5600000023841858) {
                                            var9 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var9 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var9 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    if (input[6] <= 0.5) {
                                        if (input[5] <= 0.5) {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var9 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var9 = new double[3] {0.19114219114219116, 0.0, 0.8088578088578089};
                                        } else {
                                            var9 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.9900000095367432) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var9 = new double[3] {0.15749788343264803, 0.12841110326862987, 0.7140910132987222};
                                        } else {
                                            var9 = new double[3] {0.25536962471396873, 0.4602489254280495, 0.2843814498579818};
                                        }
                                    } else {
                                        if (input[1] <= 0.949999988079071) {
                                            var9 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328564};
                                        } else {
                                            var9 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var10;
            if (input[14] <= -0.10000000521540642) {
                if (input[9] <= 0.5) {
                    if (input[3] <= 0.7199999988079071) {
                        if (input[13] <= 0.019999999552965164) {
                            if (input[13] <= -0.009999999776482582) {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[0] <= 0.5) {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 2.5) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var10 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var10 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 0.10000000521540642) {
                            if (input[0] <= 0.5) {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 3.5) {
                                    if (input[7] <= 0.5) {
                                        if (input[13] <= -0.10999999940395355) {
                                            var10 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.8900000154972076) {
                                            var10 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        } else {
                                            var10 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                } else {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var10 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[9] <= 1.5) {
                            if (input[3] <= 0.06000000052154064) {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 5.5) {
                                    if (input[11] <= 2.5) {
                                        if (input[14] <= -0.1666666716337204) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.06620021528525297, 0.0, 0.9337997847147471};
                                        }
                                    } else {
                                        if (input[5] <= 3.5) {
                                            var10 = new double[3] {0.03349797600921009, 0.0, 0.9665020239907899};
                                        } else {
                                            var10 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    }
                                } else {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var10 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[7] <= 4.5) {
                            if (input[11] <= 3.5) {
                                if (input[2] <= 0.03333333507180214) {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var10 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var10 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                if (input[5] <= 0.5) {
                                    if (input[9] <= 1.5) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var10 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    var10 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[6] <= 0.5) {
                    if (input[7] <= 0.5) {
                        if (input[4] <= 0.1666666716337204) {
                            if (input[0] <= 0.5) {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[3] <= 0.26999999582767487) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[13] <= 0.05000000074505806) {
                                            var10 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.0800000000745058) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 5.5) {
                                        if (input[10] <= 4.5) {
                                            var10 = new double[3] {0.32086338981155244, 0.6791366101884474, 0.0};
                                        } else {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[10] <= 3.0) {
                                    if (input[9] <= 0.5) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.17999999970197678) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                } else {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[12] <= 2.5) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 3.0) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.12740989103101424, 0.8725901089689857, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 5.0) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var10 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.9900000095367432) {
                            if (input[0] <= 0.5) {
                                if (input[13] <= 0.10999999940395355) {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var10 = new double[3] {0.2209250112258644, 0.0, 0.7790749887741356};
                                        } else {
                                            var10 = new double[3] {0.11369773042399477, 0.0, 0.8863022695760053};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var10 = new double[3] {0.6140728108548972, 0.0, 0.3859271891451028};
                                        } else {
                                            var10 = new double[3] {0.07840220970997556, 0.0, 0.9215977902900243};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var10 = new double[3] {0.19727954103821596, 0.0, 0.802720458961784};
                                        } else {
                                            var10 = new double[3] {0.0730186999109528, 0.0, 0.9269813000890472};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 1.5) {
                                    if (input[13] <= -0.10999999940395355) {
                                        if (input[12] <= 5.0) {
                                            var10 = new double[3] {0.518670587582533, 0.4813294124174669, 0.0};
                                        } else {
                                            var10 = new double[3] {0.08433359946953191, 0.32087455061324094, 0.5947918499172271};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var10 = new double[3] {0.2261628608980032, 0.6852209323138224, 0.08861620678817439};
                                        } else {
                                            var10 = new double[3] {0.2782261419419252, 0.7217738580580749, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.029999999329447746) {
                                        if (input[9] <= 2.5) {
                                            var10 = new double[3] {0.4008413650205633, 0.5991586349794368, 0.0};
                                        } else {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.7430010368834247, 0.25699896311657533, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[10] <= 3.5) {
                                    var10 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 0.9199999868869781) {
                                    if (input[5] <= 4.5) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var10 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[9] <= 0.5) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[12] <= 2.5) {
                            var10 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 0.5) {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 3.5) {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var10 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        } else {
                                            var10 = new double[3] {0.13293353323338333, 0.8670664667666167, 0.0};
                                        }
                                    } else {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var10 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    } else {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[7] <= 2.5) {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[3] <= 0.29999999701976776) {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[10] <= 0.5) {
                                            var10 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var10 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[14] <= -0.03333333507180214) {
                                    var10 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        var10 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 3.0) {
                                            var10 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var10 = new double[3] {0.030545725460979698, 0.0, 0.9694542745390203};
                                        }
                                    }
                                }
                            } else {
                                var10 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var11;
            if (input[12] <= 3.5) {
                if (input[2] <= 0.30000001192092896) {
                    if (input[12] <= 2.5) {
                        if (input[14] <= 0.03333333507180214) {
                            if (input[0] <= 0.5) {
                                var11 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var11 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[13] <= -0.17000000178813934) {
                                if (input[5] <= 4.5) {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.7400000095367432) {
                                        var11 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var11 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[14] <= -0.23333334177732468) {
                            var11 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 2.5) {
                                if (input[11] <= 5.5) {
                                    if (input[3] <= 0.22999999672174454) {
                                        if (input[11] <= 1.5) {
                                            var11 = new double[3] {0.5982866404260246, 0.4017133595739755, 0.0};
                                        } else {
                                            var11 = new double[3] {0.3129801219608775, 0.6870198780391225, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.2495706253123198, 0.7504293746876801, 0.0};
                                        }
                                    }
                                } else {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[13] <= -0.12999999895691872) {
                                            var11 = new double[3] {0.440863680309378, 0.559136319690622, 0.0};
                                        } else {
                                            var11 = new double[3] {0.28855645834915306, 0.711443541650847, 0.0};
                                        }
                                    } else {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= -0.14000000432133675) {
                        var11 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        var11 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    if (input[3] <= 0.21000000089406967) {
                        if (input[7] <= 1.5) {
                            if (input[13] <= 0.1899999976158142) {
                                if (input[13] <= 0.12999999895691872) {
                                    if (input[9] <= 0.5) {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                } else {
                                    var11 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                }
                            } else {
                                var11 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var11 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[8] <= 0.5) {
                            if (input[14] <= -0.03333333507180214) {
                                if (input[9] <= 0.5) {
                                    if (input[14] <= -0.10000000521540642) {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 4.5) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 5.5) {
                                        if (input[14] <= -0.23333334177732468) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.08218949244090545, 0.0, 0.9178105075590945};
                                        }
                                    } else {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[10] <= 3.5) {
                                    if (input[12] <= 5.0) {
                                        if (input[4] <= 0.1666666716337204) {
                                            var11 = new double[3] {0.13471411388505883, 0.0, 0.8652858861149412};
                                        } else {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.8900000154972076) {
                                        if (input[5] <= 0.5) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.03999999910593033) {
                                            var11 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                if (input[14] <= -0.06666667014360428) {
                                    if (input[1] <= 0.5699999928474426) {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 4.0) {
                                            var11 = new double[3] {0.03423323128305038, 0.0, 0.9657667687169497};
                                        } else {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= 0.03999999910593033) {
                                    if (input[3] <= 0.4699999988079071) {
                                        if (input[2] <= 0.13333333656191826) {
                                            var11 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var11 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.03789279112754159, 0.0, 0.9621072088724585};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.13333333656191826) {
                                        if (input[11] <= 3.5) {
                                            var11 = new double[3] {0.030545725460979698, 0.0, 0.9694542745390203};
                                        } else {
                                            var11 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        }
                                    } else {
                                        if (input[1] <= 0.75) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[7] <= 2.5) {
                        if (input[13] <= 0.12999999895691872) {
                            if (input[11] <= 3.5) {
                                var11 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 1.5) {
                                    if (input[5] <= 0.5) {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var11 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var11 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        }
                                    }
                                } else {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var11 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.5) {
                            if (input[8] <= 0.5) {
                                if (input[9] <= 0.5) {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.6200000047683716) {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        var11 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 5.0) {
                                if (input[3] <= 0.22999999672174454) {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 4.5) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var11 = new double[3] {0.6119436367702975, 0.38805636322970255, 0.0};
                                        } else {
                                            var11 = new double[3] {0.13057484429808863, 0.8694251557019114, 0.0};
                                        }
                                    } else {
                                        var11 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 3.5) {
                                    if (input[3] <= 0.5000000074505806) {
                                        var11 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var11 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    var11 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var12;
            if (input[0] <= 0.5) {
                if (input[10] <= 3.5) {
                    if (input[3] <= 0.8799999952316284) {
                        if (input[3] <= 0.04999999888241291) {
                            var12 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[3] <= 0.7699999809265137) {
                                if (input[12] <= 3.5) {
                                    var12 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[13] <= 0.029999999329447746) {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var12 = new double[3] {0.3554179566563468, 0.0, 0.6445820433436532};
                                        }
                                    } else {
                                        if (input[14] <= -0.1666666716337204) {
                                            var12 = new double[3] {0.14193867457962414, 0.0, 0.8580613254203758};
                                        } else {
                                            var12 = new double[3] {0.03940372099825547, 0.0, 0.9605962790017446};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[8] <= 0.5) {
                                        if (input[13] <= 0.13000000268220901) {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var12 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    } else {
                                        if (input[1] <= 0.9900000095367432) {
                                            var12 = new double[3] {0.12417970721857648, 0.0, 0.8758202927814235};
                                        } else {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var12 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var12 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[5] <= 0.5) {
                        if (input[3] <= 0.949999988079071) {
                            var12 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[4] <= 0.10000000521540642) {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[9] <= 0.5) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= -0.06666667014360428) {
                                            var12 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var12 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[14] <= 0.03333333507180214) {
                            if (input[9] <= 0.5) {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= -0.03333333507180214) {
                                    if (input[12] <= 3.5) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var12 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        } else {
                                            var12 = new double[3] {0.028691392582225337, 0.0, 0.9713086074177746};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.949999988079071) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var12 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[12] <= 2.5) {
                    if (input[10] <= 4.5) {
                        if (input[5] <= 0.5) {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[10] <= 2.5) {
                                    if (input[13] <= -0.12999999895691872) {
                                        var12 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[10] <= 1.5) {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var12 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var12 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[7] <= 1.5) {
                            if (input[1] <= 0.6500000059604645) {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.7700000107288361) {
                                    var12 = new double[3] {0.0, 0.0, 1.0};
                                } else {
                                    if (input[6] <= 0.5) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var12 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[11] <= 4.5) {
                        if (input[13] <= 0.06999999843537807) {
                            if (input[5] <= 0.5) {
                                if (input[12] <= 5.0) {
                                    if (input[9] <= 2.5) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var12 = new double[3] {0.22997780915876537, 0.7700221908412346, 0.0};
                                        } else {
                                            var12 = new double[3] {0.3860196923333123, 0.6139803076666878, 0.0};
                                        }
                                    } else {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[8] <= 0.5) {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var12 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var12 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.07000000029802322) {
                                    var12 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var12 = new double[3] {0.26421724197389307, 0.7357827580261069, 0.0};
                                        } else {
                                            var12 = new double[3] {0.642341785198928, 0.3576582148010719, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var12 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[9] <= 1.5) {
                                    if (input[13] <= 0.2900000065565109) {
                                        if (input[1] <= 0.9900000095367432) {
                                            var12 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        } else {
                                            var12 = new double[3] {0.10123584696218456, 0.8987641530378154, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var12 = new double[3] {0.06984759133032091, 0.9301524086696792, 0.0};
                                        } else {
                                            var12 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.5) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 2.5) {
                                            var12 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[8] <= 0.5) {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.8400000035762787) {
                                        if (input[10] <= 1.5) {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.06666667014360428) {
                                            var12 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var12 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[2] <= 0.23333334177732468) {
                            if (input[12] <= 3.5) {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.6099999845027924) {
                                if (input[14] <= 0.20000001043081284) {
                                    if (input[9] <= 0.5) {
                                        var12 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var12 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var12 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var12 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var13;
            if (input[7] <= 0.5) {
                if (input[4] <= 0.1666666716337204) {
                    if (input[12] <= 2.5) {
                        var13 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[0] <= 0.5) {
                            var13 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= 0.23333334177732468) {
                                if (input[10] <= 0.5) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 5.5) {
                                        if (input[4] <= 0.10000000521540642) {
                                            var13 = new double[3] {0.3515230797981685, 0.6484769202018316, 0.0};
                                        } else {
                                            var13 = new double[3] {0.2285133504139581, 0.7714866495860419, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var13 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var13 = new double[3] {0.7308825810454475, 0.2691174189545525, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 0.5) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[11] <= 3.5) {
                        if (input[2] <= 0.10000000521540642) {
                            var13 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[0] <= 0.5) {
                                var13 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.03333333507180214) {
                                    if (input[1] <= 0.8499999940395355) {
                                        if (input[1] <= 0.7099999785423279) {
                                            var13 = new double[3] {0.34454098979977327, 0.6554590102002267, 0.0};
                                        } else {
                                            var13 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var13 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            var13 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= -0.1666666716337204) {
                                if (input[6] <= 0.5) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var13 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[0] <= 0.5) {
                                        var13 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[9] <= 0.5) {
                    if (input[0] <= 0.5) {
                        if (input[4] <= 0.1666666716337204) {
                            var13 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[11] <= 2.5) {
                                var13 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= -0.10000000521540642) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.47999998927116394) {
                                        if (input[13] <= 0.019999999552965164) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328564};
                                        }
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[11] <= 3.5) {
                            if (input[8] <= 0.5) {
                                if (input[4] <= 0.10000000521540642) {
                                    if (input[13] <= 0.12999999895691872) {
                                        if (input[11] <= 1.5) {
                                            var13 = new double[3] {0.3440221393374239, 0.518638143278676, 0.13733971738390024};
                                        } else {
                                            var13 = new double[3] {0.2594963721724285, 0.7405036278275716, 0.0};
                                        }
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.1900000050663948) {
                                        if (input[5] <= 0.5) {
                                            var13 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.15000000223517418) {
                                            var13 = new double[3] {0.01289316178311269, 0.441505967638826, 0.5456008705780614};
                                        } else {
                                            var13 = new double[3] {0.6327524165667113, 0.36724758343328867, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.6500000059604645) {
                                    if (input[7] <= 1.5) {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.05518242875294971, 0.9448175712470502, 0.0};
                                        }
                                    }
                                } else {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.10000000521540642) {
                                if (input[7] <= 5.0) {
                                    if (input[1] <= 0.8199999928474426) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.22602230483271377, 0.7739776951672862, 0.0};
                                        }
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[5] <= 0.5) {
                                            var13 = new double[3] {0.12740989103101424, 0.8725901089689857, 0.0};
                                        } else {
                                            var13 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.12000000104308128) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.05778212229825133, 0.9422178777017487, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= -0.04999999888241291) {
                        if (input[0] <= 0.5) {
                            if (input[13] <= -0.12999999895691872) {
                                if (input[5] <= 0.5) {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.3100000023841858) {
                                        if (input[12] <= 3.5) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var13 = new double[3] {0.011677584733694103, 0.0, 0.9883224152663058};
                                        } else {
                                            var13 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.09999999776482582) {
                                    var13 = new double[3] {0.0, 0.0, 1.0};
                                } else {
                                    if (input[12] <= 3.5) {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.2199999988079071) {
                                if (input[13] <= -0.3699999898672104) {
                                    if (input[14] <= 0.13333334028720856) {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.3700000047683716) {
                                    if (input[8] <= 0.5) {
                                        if (input[1] <= 0.25999999791383743) {
                                            var13 = new double[3] {0.06803939122649955, 0.9319606087735004, 0.0};
                                        } else {
                                            var13 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        }
                                    } else {
                                        var13 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= -0.22999999672174454) {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.5600000023841858) {
                                            var13 = new double[3] {0.7566961155518159, 0.24330388444818396, 0.0};
                                        } else {
                                            var13 = new double[3] {0.3515230797981685, 0.6484769202018315, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[13] <= 0.17000000178813934) {
                            if (input[6] <= 0.5) {
                                if (input[9] <= 1.5) {
                                    if (input[0] <= 0.5) {
                                        if (input[5] <= 4.5) {
                                            var13 = new double[3] {0.0763907372903913, 0.0, 0.9236092627096087};
                                        } else {
                                            var13 = new double[3] {0.0498935199269851, 0.0, 0.9501064800730149};
                                        }
                                    } else {
                                        if (input[1] <= 0.9099999964237213) {
                                            var13 = new double[3] {0.6514431125694771, 0.34855688743052304, 0.0};
                                        } else {
                                            var13 = new double[3] {0.16159273219290615, 0.8384072678070938, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 4.5) {
                                        if (input[0] <= 0.5) {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var13 = new double[3] {0.740074906367041, 0.25992509363295907, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= -0.06666666641831398) {
                                            var13 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var13 = new double[3] {0.02143260011280316, 0.9785673998871969, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[1] <= 0.7400000095367432) {
                                        if (input[3] <= 0.5400000065565109) {
                                            var13 = new double[3] {0.22950528466116, 0.7704947153388401, 0.0};
                                        } else {
                                            var13 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        }
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 3.5) {
                                        if (input[13] <= 0.0800000000745058) {
                                            var13 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var13 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[10] <= 0.5) {
                                var13 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[0] <= 0.5) {
                                    if (input[13] <= 0.4399999976158142) {
                                        if (input[9] <= 1.5) {
                                            var13 = new double[3] {0.047815051107909734, 0.0, 0.9521849488920903};
                                        } else {
                                            var13 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var13 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var13 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var14;
            if (input[0] <= 0.5) {
                if (input[12] <= 3.5) {
                    var14 = new double[3] {1.0, 0.0, 0.0};
                } else {
                    if (input[12] <= 5.0) {
                        if (input[1] <= 0.8799999952316284) {
                            if (input[14] <= 0.1666666716337204) {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[8] <= 0.5) {
                                        if (input[5] <= 5.5) {
                                            var14 = new double[3] {0.08854774690637406, 0.0, 0.911452253093626};
                                        } else {
                                            var14 = new double[3] {0.4148397976391231, 0.0, 0.5851602023608768};
                                        }
                                    } else {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.7100000083446503) {
                                        if (input[7] <= 0.5) {
                                            var14 = new double[3] {0.1833372558249, 0.0, 0.8166627441751001};
                                        } else {
                                            var14 = new double[3] {0.04739199537639071, 0.0, 0.9526080046236093};
                                        }
                                    } else {
                                        if (input[1] <= 0.7999999821186066) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                }
                            } else {
                                if (input[8] <= 0.5) {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.949999988079071) {
                                var14 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[9] <= 0.5) {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[7] <= 0.5) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    } else {
                                        if (input[14] <= -0.06666667014360428) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var14 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[14] <= 0.10000000521540642) {
                    if (input[9] <= 2.5) {
                        if (input[12] <= 2.5) {
                            if (input[5] <= 0.5) {
                                if (input[7] <= 4.5) {
                                    if (input[13] <= -0.13999999687075615) {
                                        if (input[10] <= 2.5) {
                                            var14 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.8799999952316284) {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.7400000095367432) {
                                        if (input[1] <= 0.6800000071525574) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[5] <= 2.5) {
                                    if (input[1] <= 0.6899999976158142) {
                                        if (input[1] <= 0.6700000166893005) {
                                            var14 = new double[3] {0.2905467024782296, 0.6794652827210728, 0.029988014800697745};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 5.5) {
                                            var14 = new double[3] {0.19498348754059863, 0.8050165124594014, 0.0};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 3.5) {
                                        if (input[9] <= 0.5) {
                                            var14 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var14 = new double[3] {0.22820284697508875, 0.7717971530249111, 0.0};
                                        } else {
                                            var14 = new double[3] {0.8466094951816815, 0.15339050481831845, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var14 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        var14 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[14] <= 0.23333334177732468) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[10] <= 2.5) {
                                if (input[10] <= 1.5) {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.12999999895691872) {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 4.5) {
                                            var14 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var14 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[14] <= 0.1666666716337204) {
                                if (input[12] <= 2.5) {
                                    if (input[1] <= 0.4299999922513962) {
                                        if (input[11] <= 3.5) {
                                            var14 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.3799999952316284) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.21000000089406967) {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.04999999888241291) {
                                            var14 = new double[3] {0.27131457370852585, 0.728685426291474, 0.0};
                                        } else {
                                            var14 = new double[3] {0.5206917509254655, 0.4793082490745345, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 0.5) {
                                    if (input[13] <= 0.029999999329447746) {
                                        if (input[5] <= 0.5) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {0.09870129870129869, 0.9012987012987013, 0.0};
                                        }
                                    } else {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.0) {
                                            var14 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var14 = new double[3] {0.5836333093352533, 0.41636669066474685, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.6400000154972076) {
                            if (input[1] <= 0.5600000023841858) {
                                if (input[12] <= 3.5) {
                                    if (input[13] <= -0.3699999898672104) {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.3499999940395355) {
                                            var14 = new double[3] {0.2827614716825134, 0.7172385283174866, 0.0};
                                        } else {
                                            var14 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                } else {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[9] <= 1.0) {
                                    var14 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        var14 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var14 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.09999999776482582) {
                                var14 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var14 = new double[3] {0.0, 0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var15;
            if (input[13] <= -0.009999999776482582) {
                if (input[7] <= 1.5) {
                    if (input[11] <= 2.5) {
                        if (input[5] <= 5.5) {
                            if (input[4] <= 0.03333333507180214) {
                                if (input[9] <= 0.5) {
                                    if (input[14] <= 0.1666666716337204) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.1666666716337204) {
                                            var15 = new double[3] {0.10751028806584362, 0.8924897119341565, 0.0};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 2.5) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.461948768839546, 0.5380512311604541, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 6.5) {
                                var15 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.03333333507180214) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[12] <= 2.5) {
                                if (input[5] <= 4.5) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.6800000071525574) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= -0.03333333507180214) {
                                    if (input[5] <= 2.5) {
                                        if (input[7] <= 0.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.18552248615153508, 0.814477513848465, 0.0};
                                        }
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[10] <= 2.5) {
                                        if (input[1] <= 0.15000000223517418) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.06440181804175332, 0.9355981819582466, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var15 = new double[3] {0.7103989317309297, 0.2896010682690703, 0.0};
                                        } else {
                                            var15 = new double[3] {0.14418516410548282, 0.8558148358945171, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[5] <= 0.5) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var15 = new double[3] {0.5595328763645595, 0.44046712363544044, 0.0};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var15 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.9900000095367432) {
                                    if (input[0] <= 0.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.1056701030927835, 0.0, 0.8943298969072165};
                                        }
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[1] <= 0.9099999964237213) {
                                            var15 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var15 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= -0.06999999843537807) {
                        if (input[7] <= 6.5) {
                            if (input[7] <= 2.5) {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[0] <= 0.5) {
                                        if (input[8] <= 0.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.12294004650692548, 0.8770599534930745, 0.0};
                                        }
                                    }
                                } else {
                                    var15 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[11] <= 4.5) {
                                    if (input[12] <= 2.5) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var15 = new double[3] {0.26541804143211073, 0.6873898800800113, 0.047192078487877924};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                var15 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[5] <= 1.5) {
                                        if (input[8] <= 0.5) {
                                            var15 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var15 = new double[3] {0.398196323274367, 0.0, 0.6018036767256331};
                                        }
                                    } else {
                                        var15 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= -0.12999999895691872) {
                                        var15 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[7] <= 6.5) {
                            if (input[1] <= 0.17999999970197678) {
                                if (input[4] <= 0.10000000521540642) {
                                    if (input[13] <= -0.04999999888241291) {
                                        if (input[12] <= 3.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[7] <= 3.5) {
                                    if (input[7] <= 2.5) {
                                        if (input[5] <= 2.5) {
                                            var15 = new double[3] {0.11369773042399473, 0.3707999291083287, 0.5155023404676765};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.09932514275826267, 0.0, 0.9006748572417373};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.04999999888241291) {
                                        if (input[10] <= 3.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.20812414422638065, 0.7918758557736193, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var15 = new double[3] {0.5678704856787049, 0.43212951432129515, 0.0};
                                        } else {
                                            var15 = new double[3] {0.15690816390759743, 0.17910241077610628, 0.6639894253162963};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.1666666716337204) {
                                var15 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.17999999970197678) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 1.5) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var15 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[12] <= 3.5) {
                    if (input[12] <= 2.5) {
                        var15 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[8] <= 0.5) {
                            if (input[0] <= 0.5) {
                                var15 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 5.5) {
                                    if (input[5] <= 3.5) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var15 = new double[3] {0.19886101277512697, 0.801138987224873, 0.0};
                                        } else {
                                            var15 = new double[3] {0.40623828691556757, 0.5937617130844324, 0.0};
                                        }
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[9] <= 0.5) {
                                            var15 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        } else {
                                            var15 = new double[3] {0.6683234563181036, 0.3316765436818964, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var15 = new double[3] {0.052806590897811305, 0.9471934091021886, 0.0};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                if (input[0] <= 0.5) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.30000000447034836) {
                                        if (input[7] <= 5.0) {
                                            var15 = new double[3] {0.19886101277512702, 0.8011389872248731, 0.0};
                                        } else {
                                            var15 = new double[3] {0.014391213785267943, 0.985608786214732, 0.0};
                                        }
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[4] <= 0.03333333507180214) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[13] <= 0.4399999976158142) {
                            if (input[5] <= 0.5) {
                                if (input[14] <= -0.1666666716337204) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.26999999582767487) {
                                            var15 = new double[3] {0.09049524072285833, 0.0, 0.9095047592771416};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 1.5) {
                                    if (input[1] <= 0.570000022649765) {
                                        if (input[12] <= 5.0) {
                                            var15 = new double[3] {0.07750930466119219, 0.0, 0.9224906953388078};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.06999999843537807) {
                                            var15 = new double[3] {0.0536707756081597, 0.0, 0.9463292243918402};
                                        } else {
                                            var15 = new double[3] {0.020573292354011164, 0.0, 0.9794267076459888};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.7000000178813934) {
                                        if (input[7] <= 0.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.1419386745796241, 0.0, 0.8580613254203758};
                                        }
                                    } else {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var15 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 0.23333334177732468) {
                            if (input[11] <= 3.5) {
                                var15 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[9] <= 0.5) {
                                    if (input[3] <= 0.8400000035762787) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.03999999910593033) {
                                            var15 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                if (input[4] <= 0.06666667014360428) {
                                    var15 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 2.0) {
                                        var15 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var15 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var15 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var15 = new double[3] {0.0, 0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var16;
            if (input[13] <= -0.06999999843537807) {
                if (input[0] <= 0.5) {
                    if (input[5] <= 0.5) {
                        var16 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[1] <= 0.42000000178813934) {
                            var16 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 1.5) {
                                if (input[12] <= 5.0) {
                                    if (input[7] <= 3.5) {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var16 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    if (input[11] <= 2.5) {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.14999999850988388) {
                                    if (input[7] <= 2.0) {
                                        if (input[11] <= 4.0) {
                                            var16 = new double[3] {0.10567010309278352, 0.0, 0.8943298969072165};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.14193867457962414, 0.0, 0.8580613254203758};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= 0.8799999952316284) {
                        if (input[1] <= 0.4999999850988388) {
                            if (input[13] <= -0.08999999985098839) {
                                if (input[12] <= 2.5) {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[13] <= -0.3100000023841858) {
                                            var16 = new double[3] {0.24479846783320275, 0.7552015321667973, 0.0};
                                        } else {
                                            var16 = new double[3] {0.43646933680791034, 0.5015504455327571, 0.06198021765933259};
                                        }
                                    } else {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[14] <= -0.03333333507180214) {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.0654960680814392, 0.9345039319185608, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var16 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        } else {
                                            var16 = new double[3] {0.6119436367702975, 0.38805636322970255, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                if (input[2] <= 0.1666666716337204) {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[5] <= 3.5) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.6400000154972076) {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.23333334177732468) {
                                        if (input[12] <= 3.5) {
                                            var16 = new double[3] {0.2110825724152338, 0.7889174275847661, 0.0};
                                        } else {
                                            var16 = new double[3] {0.4180586301737439, 0.5819413698262561, 0.0};
                                        }
                                    } else {
                                        var16 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 2.5) {
                            var16 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var16 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[13] <= 0.26999999582767487) {
                    if (input[12] <= 3.5) {
                        if (input[12] <= 2.5) {
                            if (input[6] <= 0.5) {
                                if (input[1] <= 0.12999999895691872) {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[5] <= 1.5) {
                                    if (input[13] <= 0.009999999776482582) {
                                        var16 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[2] <= 0.20000001043081284) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[13] <= 0.12999999895691872) {
                                    if (input[10] <= 3.5) {
                                        if (input[8] <= 0.5) {
                                            var16 = new double[3] {0.17966903073286047, 0.8203309692671394, 0.0};
                                        } else {
                                            var16 = new double[3] {0.0654960680814392, 0.9345039319185608, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.15953495882447924, 0.8404650411755208, 0.0};
                                        }
                                    }
                                } else {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.45000000298023224) {
                                    if (input[5] <= 0.5) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.7779910428662827, 0.2220089571337172, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var16 = new double[3] {0.3120057847962492, 0.6879942152037507, 0.0};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= -0.1666666716337204) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.12740989103101424, 0.8725901089689857, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var16 = new double[3] {0.7015652772203426, 0.29843472277965744, 0.0};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.0800000000745058) {
                            var16 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 3.5) {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[7] <= 4.5) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var16 = new double[3] {0.6940574854523012, 0.0, 0.30594251454769883};
                                        } else {
                                            var16 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var16 = new double[3] {0.4305874630784378, 0.0, 0.5694125369215622};
                                        } else {
                                            var16 = new double[3] {0.09932514275826267, 0.0, 0.9006748572417373};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[13] <= -0.009999999776482582) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.23697933027580576, 0.0, 0.7630206697241942};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var16 = new double[3] {0.0853485448573244, 0.0, 0.9146514551426757};
                                        } else {
                                            var16 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 0.5) {
                                    if (input[12] <= 5.0) {
                                        if (input[1] <= 0.5600000023841858) {
                                            var16 = new double[3] {0.29842296805499396, 0.0, 0.7015770319450061};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.7243844320889595, 0.2756155679110405, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[0] <= 0.5) {
                                            var16 = new double[3] {0.13756679507891142, 0.0, 0.8624332049210885};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[9] <= 0.5) {
                        if (input[7] <= 1.5) {
                            if (input[1] <= 0.7800000011920929) {
                                if (input[14] <= -0.23333334177732468) {
                                    var16 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[13] <= 0.3499999940395355) {
                                            var16 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var16 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var16 = new double[3] {0.0654960680814392, 0.9345039319185608, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var16 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var16 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        var16 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            double[] var17;
            if (input[9] <= 1.5) {
                if (input[3] <= 0.6899999976158142) {
                    if (input[0] <= 0.5) {
                        if (input[10] <= 3.5) {
                            if (input[14] <= -0.23333334177732468) {
                                var17 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 3.5) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[3] <= 0.0800000000745058) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.08428011889219139, 0.0, 0.9157198811078086};
                                        }
                                    } else {
                                        if (input[10] <= 0.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.3999999910593033) {
                                if (input[4] <= 0.10000000521540642) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.5600000023841858) {
                                        if (input[7] <= 0.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.23037113706934792, 0.0, 0.769628862930652};
                                        }
                                    } else {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var17 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[11] <= 2.5) {
                            if (input[1] <= 0.029999999329447746) {
                                if (input[13] <= -0.3699999898672104) {
                                    if (input[5] <= 1.5) {
                                        if (input[9] <= 0.5) {
                                            var17 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var17 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    var17 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                if (input[10] <= 4.5) {
                                    if (input[14] <= -0.1666666716337204) {
                                        if (input[12] <= 3.5) {
                                            var17 = new double[3] {0.12740989103101424, 0.8725901089689858, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.3854002624493933, 0.5788343623179527, 0.03576537523265398};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.03333333507180214) {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                if (input[6] <= 0.5) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 4.0) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.005873084085374589, 0.0, 0.9941269159146254};
                                        }
                                    } else {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[3] <= 0.4699999988079071) {
                                        if (input[5] <= 0.5) {
                                            var17 = new double[3] {0.1329335332333833, 0.8670664667666167, 0.0};
                                        } else {
                                            var17 = new double[3] {0.3867957870926699, 0.6132042129073302, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.4999999850988388) {
                                            var17 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        } else {
                                            var17 = new double[3] {0.17090653548840476, 0.8290934645115952, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var17 = new double[3] {0.0654960680814392, 0.9345039319185608, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.6200000047683716) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.17000000178813934) {
                        if (input[14] <= -0.10000000521540642) {
                            if (input[0] <= 0.5) {
                                if (input[9] <= 0.5) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 5.0) {
                                        if (input[11] <= 4.5) {
                                            var17 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[3] <= 0.8299999833106995) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.22162404665769406, 0.778375953342306, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var17 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.8899999856948853) {
                                        if (input[12] <= 2.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                var17 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[13] <= -0.08999999985098839) {
                                    if (input[1] <= 0.5499999821186066) {
                                        if (input[1] <= 0.39000000059604645) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.20119705340699814, 0.7988029465930018, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[11] <= 2.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.18824824549332594, 0.811751754506674, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var17 = new double[3] {0.2117696943998546, 0.7882303056001454, 0.0};
                                        } else {
                                            var17 = new double[3] {0.21812995217906822, 0.4357217548050631, 0.34614829301586886};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            var17 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 2.5) {
                                if (input[3] <= 0.7899999916553497) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var17 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[10] <= 3.5) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    var17 = new double[3] {1.0, 0.0, 0.0};
                } else {
                    if (input[9] <= 2.5) {
                        if (input[3] <= 0.45000000298023224) {
                            if (input[3] <= 0.32999999821186066) {
                                if (input[3] <= 0.029999999329447746) {
                                    var17 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    if (input[13] <= -0.029999999329447746) {
                                        if (input[13] <= -0.04999999888241291) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.22999999672174454) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[14] <= 0.10000000521540642) {
                                            var17 = new double[3] {0.08055113937466879, 0.9194488606253312, 0.0};
                                        } else {
                                            var17 = new double[3] {0.34454098979977327, 0.6554590102002267, 0.0};
                                        }
                                    } else {
                                        var17 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[10] <= 2.5) {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[6] <= 0.5) {
                                        if (input[1] <= 0.4999999850988388) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {0.4315823959812165, 0.5684176040187834, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 1.5) {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.1666666716337204) {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[8] <= 0.5) {
                                            var17 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var17 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var17 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                    }
                                } else {
                                    var17 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.06000000052154064) {
                            var17 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var17 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var18;
            if (input[0] <= 0.5) {
                if (input[12] <= 3.5) {
                    var18 = new double[3] {1.0, 0.0, 0.0};
                } else {
                    if (input[9] <= 0.5) {
                        if (input[12] <= 5.0) {
                            if (input[5] <= 0.5) {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 2.5) {
                                    if (input[7] <= 0.5) {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {0.07639073729039127, 0.0, 0.9236092627096086};
                                        }
                                    }
                                } else {
                                    var18 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.17999999970197678) {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[13] <= -0.25999999791383743) {
                            var18 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[11] <= 3.5) {
                                if (input[1] <= 0.8100000023841858) {
                                    if (input[7] <= 0.5) {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var18 = new double[3] {0.0517132646626025, 0.0, 0.9482867353373976};
                                        } else {
                                            var18 = new double[3] {0.12417970721857648, 0.0, 0.8758202927814235};
                                        }
                                    }
                                } else {
                                    if (input[14] <= -0.10000000521540642) {
                                        if (input[6] <= 0.5) {
                                            var18 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[1] <= 0.8199999928474426) {
                                        if (input[10] <= 1.5) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {0.00587308408537459, 0.0, 0.9941269159146254};
                                        }
                                    } else {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 6.5) {
                                        if (input[3] <= 0.17999999970197678) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {0.04956648217760064, 0.0, 0.9504335178223993};
                                        }
                                    } else {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[9] <= 2.5) {
                    if (input[11] <= 3.5) {
                        if (input[5] <= 2.5) {
                            if (input[13] <= 0.17999999970197678) {
                                if (input[12] <= 2.5) {
                                    if (input[1] <= 0.4299999922513962) {
                                        if (input[6] <= 0.5) {
                                            var18 = new double[3] {0.6019729295710026, 0.0, 0.3980270704289975};
                                        } else {
                                            var18 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[9] <= 0.5) {
                                            var18 = new double[3] {0.1325504331143538, 0.8674495668856463, 0.0};
                                        } else {
                                            var18 = new double[3] {0.3970359076691963, 0.6029640923308038, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var18 = new double[3] {0.5508672016567434, 0.44913279834325653, 0.0};
                                        } else {
                                            var18 = new double[3] {0.27436219155165203, 0.0, 0.725637808448348};
                                        }
                                    }
                                }
                            } else {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[12] <= 2.5) {
                                    if (input[3] <= 0.8799999952316284) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.13000000268220901) {
                                            var18 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[13] <= 0.3100000023841858) {
                                            var18 = new double[3] {0.5018662072925635, 0.49813379270743646, 0.0};
                                        } else {
                                            var18 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[10] <= 5.5) {
                            if (input[3] <= 0.570000022649765) {
                                if (input[13] <= -0.04999999888241291) {
                                    if (input[12] <= 2.5) {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var18 = new double[3] {0.15538895920553014, 0.8446110407944698, 0.0};
                                        } else {
                                            var18 = new double[3] {0.6184297338904773, 0.3815702661095228, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[1] <= 0.4699999839067459) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= -0.10000000521540642) {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var18 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var18 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 5.5) {
                                        if (input[13] <= 0.009999999776482582) {
                                            var18 = new double[3] {0.1691795980172648, 0.8308204019827352, 0.0};
                                        } else {
                                            var18 = new double[3] {0.4516088248308995, 0.5483911751691004, 0.0};
                                        }
                                    } else {
                                        var18 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var18 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[13] <= -0.4100000113248825) {
                        var18 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        var18 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            double[] var19;
            if (input[9] <= 0.5) {
                if (input[3] <= 0.3999999910593033) {
                    if (input[1] <= 0.13999999687075615) {
                        if (input[8] <= 0.5) {
                            if (input[1] <= 0.10999999940395355) {
                                if (input[2] <= 0.03333333507180214) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 2.0) {
                                        if (input[12] <= 3.5) {
                                            var19 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var19 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                            }
                        } else {
                            var19 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                        }
                    } else {
                        if (input[1] <= 0.4999999850988388) {
                            if (input[7] <= 6.5) {
                                if (input[12] <= 3.5) {
                                    if (input[0] <= 0.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.1900000050663948) {
                                            var19 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var19 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= 0.08999999798834324) {
                                    if (input[12] <= 5.0) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var19 = new double[3] {0.10567010309278352, 0.0, 0.8943298969072165};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.03333333507180214) {
                                        var19 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 4.5) {
                                if (input[2] <= 0.03333333507180214) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var19 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var19 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[14] <= -0.1666666716337204) {
                        if (input[0] <= 0.5) {
                            var19 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 2.0) {
                                var19 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 2.5) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var19 = new double[3] {0.0, 1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 2.5) {
                            if (input[3] <= 0.8799999952316284) {
                                var19 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 4.5) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.21000000089406967) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var19 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                if (input[5] <= 3.5) {
                                    if (input[0] <= 0.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var19 = new double[3] {0.10183014099089492, 0.8981698590091051, 0.0};
                                        } else {
                                            var19 = new double[3] {0.4982165236672129, 0.5017834763327871, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[13] <= -0.029999999329447746) {
                                            var19 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var19 = new double[3] {0.1697240389216781, 0.8302759610783219, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[12] <= 3.5) {
                                        if (input[0] <= 0.5) {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var19 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 5.0) {
                                            var19 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.12000000104308128) {
                                        if (input[0] <= 0.5) {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var19 = new double[3] {0.10459315327713746, 0.8954068467228626, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[14] <= 0.03333333507180214) {
                    if (input[9] <= 1.5) {
                        if (input[0] <= 0.5) {
                            if (input[3] <= 0.03999999910593033) {
                                var19 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[13] <= 0.4399999976158142) {
                                        if (input[10] <= 5.5) {
                                            var19 = new double[3] {0.07585994225000703, 0.0, 0.924140057749993};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[10] <= 2.5) {
                                        if (input[11] <= 1.5) {
                                            var19 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var19 = new double[3] {0.008519923112888983, 0.0, 0.991480076887111};
                                        }
                                    } else {
                                        if (input[11] <= 5.5) {
                                            var19 = new double[3] {0.05084065793792626, 0.0, 0.9491593420620738};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.5600000023841858) {
                                if (input[7] <= 1.5) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.13999999687075615) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var19 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= 0.009999999776482582) {
                                    if (input[10] <= 1.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 5.5) {
                                            var19 = new double[3] {0.1663552399765095, 0.8336447600234904, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[5] <= 0.5) {
                                            var19 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[7] <= 2.5) {
                            if (input[10] <= 1.5) {
                                if (input[5] <= 4.5) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[1] <= 0.44999998807907104) {
                                            var19 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[13] <= -0.09000000171363354) {
                                            var19 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.9900000095367432) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var19 = new double[3] {0.243129271484659, 0.7568707285153411, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.4099999964237213) {
                                if (input[7] <= 6.5) {
                                    if (input[10] <= 1.5) {
                                        if (input[11] <= 1.5) {
                                            var19 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        } else {
                                            var19 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var19 = new double[3] {0.10459315327713745, 0.8954068467228625, 0.0};
                                        } else {
                                            var19 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var19 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[7] <= 0.5) {
                            var19 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[7] <= 6.5) {
                                if (input[3] <= 0.3700000047683716) {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var19 = new double[3] {0.14769936138857048, 0.0, 0.8523006386114295};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var19 = new double[3] {0.05367077560815971, 0.0, 0.9463292243918403};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[11] <= 1.5) {
                                    if (input[12] <= 3.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 0.5) {
                                            var19 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var19 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                } else {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 1.5) {
                            if (input[9] <= 2.5) {
                                if (input[5] <= 1.5) {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[7] <= 3.0) {
                                            var19 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var19 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                var19 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[10] <= 2.5) {
                                if (input[1] <= 0.4099999964237213) {
                                    if (input[11] <= 0.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var19 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var19 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[11] <= 2.5) {
                                        if (input[10] <= 4.5) {
                                            var19 = new double[3] {0.4028360982997178, 0.5971639017002822, 0.0};
                                        } else {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.8799999952316284) {
                                            var19 = new double[3] {0.8331570343302239, 0.16684296566977608, 0.0};
                                        } else {
                                            var19 = new double[3] {0.537209922646039, 0.46279007735396105, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.5) {
                                        var19 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var19 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var19 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var20;
            if (input[12] <= 3.5) {
                if (input[13] <= 0.10999999940395355) {
                    if (input[12] <= 2.5) {
                        if (input[11] <= 3.5) {
                            if (input[7] <= 0.5) {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 4.5) {
                                        if (input[13] <= -0.13999999687075615) {
                                            var20 = new double[3] {0.07639073729039127, 0.0, 0.9236092627096086};
                                        } else {
                                            var20 = new double[3] {0.5097485165300932, 0.0, 0.4902514834699068};
                                        }
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.12999999895691872) {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[14] <= 0.1666666716337204) {
                            if (input[3] <= 0.22999999672174454) {
                                if (input[0] <= 0.5) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.04999999888241291) {
                                        if (input[3] <= 0.21000000089406967) {
                                            var20 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[7] <= 6.5) {
                                        if (input[11] <= 5.5) {
                                            var20 = new double[3] {0.30922809504850474, 0.6907719049514953, 0.0};
                                        } else {
                                            var20 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.13333333656191826) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.009999999776482582) {
                                        if (input[9] <= 1.5) {
                                            var20 = new double[3] {0.4069727697390908, 0.5930272302609092, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var20 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        } else {
                                            var20 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.7000000178813934) {
                                if (input[5] <= 0.5) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.30000001192092896) {
                                        if (input[3] <= 0.4099999964237213) {
                                            var20 = new double[3] {0.6683234563181036, 0.3316765436818964, 0.0};
                                        } else {
                                            var20 = new double[3] {0.21418147048462582, 0.7858185295153741, 0.0};
                                        }
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.1666666716337204) {
                        if (input[3] <= 0.7299999892711639) {
                            if (input[7] <= 1.5) {
                                if (input[0] <= 0.5) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[8] <= 0.5) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.6247025740860913, 0.37529742591390874, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var20 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[4] <= 0.03333333507180214) {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= -0.10000000521540642) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                } else {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 2.5) {
                                    if (input[0] <= 0.5) {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.14999999850988388) {
                                            var20 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var20 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    }
                                } else {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[8] <= 0.5) {
                            var20 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var20 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[10] <= 3.5) {
                    if (input[0] <= 0.5) {
                        if (input[4] <= 0.23333334177732468) {
                            if (input[11] <= 5.5) {
                                if (input[13] <= -0.3400000035762787) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[7] <= 0.5) {
                                            var20 = new double[3] {0.26170212765957446, 0.0, 0.7382978723404255};
                                        } else {
                                            var20 = new double[3] {0.07018980275400069, 0.0, 0.9298101972459992};
                                        }
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var20 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[12] <= 5.0) {
                            if (input[14] <= -0.10000000521540642) {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[3] <= 0.28999999165534973) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[9] <= 0.5) {
                                            var20 = new double[3] {0.16159273219290615, 0.8384072678070938, 0.0};
                                        } else {
                                            var20 = new double[3] {0.23098841258785538, 0.7690115874121446, 0.0};
                                        }
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[3] <= 0.6599999964237213) {
                                    if (input[7] <= 0.5) {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= 0.009999999776482582) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[7] <= 6.5) {
                                        if (input[1] <= 0.26999999582767487) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.14999999664723873) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var20 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[9] <= 0.5) {
                        if (input[8] <= 0.5) {
                            if (input[14] <= 0.10000000521540642) {
                                if (input[1] <= 0.9600000083446503) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[11] <= 3.5) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var20 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 4.5) {
                                    if (input[3] <= 0.7199999988079071) {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var20 = new double[3] {0.0, 1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.03333333507180214) {
                                var20 = new double[3] {0.0, 0.0, 1.0};
                            } else {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[14] <= 0.03333333507180214) {
                            if (input[0] <= 0.5) {
                                if (input[8] <= 0.5) {
                                    if (input[4] <= 0.10000000521540642) {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 2.5) {
                                            var20 = new double[3] {0.2209250112258644, 0.0, 0.7790749887741356};
                                        } else {
                                            var20 = new double[3] {0.02558502340093604, 0.0, 0.974414976599064};
                                        }
                                    }
                                } else {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= -0.06999999843537807) {
                                    if (input[5] <= 0.5) {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.9000000059604645) {
                                            var20 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[7] <= 4.0) {
                                var20 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[0] <= 0.5) {
                                    var20 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 5.5) {
                                        if (input[8] <= 0.5) {
                                            var20 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var20 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    } else {
                                        var20 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var21;
            if (input[0] <= 0.5) {
                if (input[3] <= 0.6299999952316284) {
                    if (input[3] <= 0.45000000298023224) {
                        if (input[11] <= 0.5) {
                            var21 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[12] <= 3.5) {
                                    var21 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[4] <= 0.1666666716337204) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {0.24859246427024684, 0.0, 0.7514075357297532};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var21 = new double[3] {0.1327271428911476, 0.0, 0.8672728571088525};
                                        } else {
                                            var21 = new double[3] {0.03423323128305037, 0.0, 0.9657667687169496};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 6.5) {
                                    if (input[13] <= 0.0800000000745058) {
                                        if (input[7] <= 0.5) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 3.0) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.1699999962002039) {
                                            var21 = new double[3] {0.1056701030927835, 0.0, 0.8943298969072165};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 3.5) {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[9] <= 0.5) {
                                    var21 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 2.0) {
                                        if (input[9] <= 1.5) {
                                            var21 = new double[3] {0.01985311919941894, 0.0, 0.9801468808005811};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= -0.1666666716337204) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {0.07494858709726561, 0.0, 0.9250514129027344};
                                        }
                                    }
                                }
                            } else {
                                var21 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var21 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 0.6700000166893005) {
                        var21 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[11] <= 2.5) {
                            var21 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[4] <= 0.03333333507180214) {
                                var21 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 4.5) {
                                    if (input[7] <= 4.5) {
                                        if (input[1] <= 0.75) {
                                            var21 = new double[3] {0.5695857107417515, 0.0, 0.4304142892582486};
                                        } else {
                                            var21 = new double[3] {0.2262667930207926, 0.0, 0.7737332069792074};
                                        }
                                    } else {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var21 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[9] <= 2.5) {
                    if (input[10] <= 5.5) {
                        if (input[13] <= 0.10999999940395355) {
                            if (input[11] <= 3.5) {
                                if (input[12] <= 2.5) {
                                    if (input[5] <= 0.5) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var21 = new double[3] {0.36189775652813533, 0.0, 0.6381022434718646};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var21 = new double[3] {0.3413116428825037, 0.6095614531519126, 0.04912690396558361};
                                        } else {
                                            var21 = new double[3] {0.14909269249632173, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.12999999895691872) {
                                            var21 = new double[3] {0.6319630053879766, 0.36803699461202344, 0.0};
                                        } else {
                                            var21 = new double[3] {0.3733294806039151, 0.626670519396085, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 4.5) {
                                    if (input[12] <= 2.5) {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.25999999791383743) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {0.23939339817175107, 0.7606066018282488, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[12] <= 3.5) {
                                            var21 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[10] <= 1.5) {
                                    if (input[13] <= 0.1899999976158142) {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.39000000059604645) {
                                            var21 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var21 = new double[3] {0.18937860146394642, 0.8106213985360536, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        if (input[1] <= 0.6899999976158142) {
                                            var21 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var21 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[12] <= 5.0) {
                                    var21 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[6] <= 0.5) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.23333334177732468) {
                                            var21 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var21 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 6.5) {
                            var21 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var21 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= 0.5) {
                        var21 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        var21 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            double[] var22;
            if (input[13] <= 0.21000000089406967) {
                if (input[12] <= 3.5) {
                    if (input[8] <= 0.5) {
                        if (input[12] <= 2.5) {
                            if (input[0] <= 0.5) {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[9] <= 0.5) {
                                    if (input[2] <= 0.10000000521540642) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.47999998927116394) {
                                            var22 = new double[3] {0.25738336424596947, 0.0, 0.7426166357540306};
                                        } else {
                                            var22 = new double[3] {0.6984182165826526, 0.0, 0.3015817834173475};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.7600000202655792) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                if (input[13] <= 0.009999999776482582) {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[5] <= 6.5) {
                                            var22 = new double[3] {0.310516119417813, 0.689483880582187, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.6800000071525574) {
                                            var22 = new double[3] {0.35685160014827627, 0.6431483998517238, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[5] <= 6.5) {
                                            var22 = new double[3] {0.45854571933839555, 0.5414542806616045, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[1] <= 0.8100000023841858) {
                                    if (input[14] <= 0.23333334177732468) {
                                        if (input[9] <= 0.5) {
                                            var22 = new double[3] {0.2689812083930227, 0.7310187916069772, 0.0};
                                        } else {
                                            var22 = new double[3] {0.6092870332837904, 0.3907129667162096, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.12999999895691872) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 2.5) {
                                            var22 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[14] <= 0.10000000521540642) {
                            if (input[5] <= 0.5) {
                                if (input[14] <= -0.23333334177732468) {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.08999999985098839) {
                                        if (input[12] <= 2.5) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.22162404665769406, 0.778375953342306, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.15359955397588682, 0.8464004460241131, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.4999999850988388) {
                                    if (input[7] <= 0.5) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[12] <= 2.5) {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.1399999987334013) {
                                        if (input[7] <= 4.5) {
                                            var22 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[9] <= 0.5) {
                            if (input[5] <= 0.5) {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.75) {
                                    if (input[13] <= 0.029999999329447746) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.23500881834215165, 0.0, 0.7649911816578483};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var22 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.14999999850988388) {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[10] <= 5.5) {
                                        if (input[13] <= -0.029999999329447746) {
                                            var22 = new double[3] {0.0699317738791423, 0.0, 0.9300682261208577};
                                        } else {
                                            var22 = new double[3] {0.1087082608335405, 0.0, 0.8912917391664595};
                                        }
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.8199999928474426) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[7] <= 1.5) {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[1] <= 0.9600000083446503) {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[5] <= 0.5) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.5600000023841858) {
                                            var22 = new double[3] {0.11614875191034131, 0.8838512480896588, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[9] <= 0.5) {
                                    if (input[14] <= 0.13333333656191826) {
                                        if (input[12] <= 5.0) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.2209250112258644, 0.0, 0.7790749887741356};
                                        }
                                    } else {
                                        var22 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.22999999672174454) {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.029999999329447746) {
                                        if (input[11] <= 4.5) {
                                            var22 = new double[3] {0.18455271815760613, 0.8154472818423938, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[10] <= 1.5) {
                    if (input[12] <= 3.5) {
                        if (input[1] <= 0.6899999976158142) {
                            if (input[3] <= 0.08999999798834324) {
                                if (input[2] <= 0.03333333507180214) {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 2.5) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var22 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var22 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[9] <= 0.5) {
                                    var22 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                } else {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 6.5) {
                            if (input[6] <= 0.5) {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.10000000149011612) {
                                    var22 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                } else {
                                    if (input[9] <= 0.5) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var22 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var22 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[9] <= 0.5) {
                        var22 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[3] <= 0.39000000059604645) {
                            var22 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[13] <= 0.25) {
                                    if (input[2] <= 0.13333334028720856) {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var22 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                }
                            } else {
                                if (input[1] <= 0.9900000095367432) {
                                    if (input[9] <= 1.5) {
                                        if (input[3] <= 0.4999999850988388) {
                                            var22 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        } else {
                                            var22 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var22 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var22 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var23;
            if (input[13] <= -0.04999999888241291) {
                if (input[0] <= 0.5) {
                    if (input[12] <= 3.5) {
                        var23 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[12] <= 5.0) {
                            if (input[3] <= 0.22999999672174454) {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 5.5) {
                                    if (input[7] <= 2.5) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814234};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.2500000074505806) {
                                        if (input[11] <= 0.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 3.0) {
                                            var23 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.1899999976158142) {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[7] <= 0.5) {
                        if (input[2] <= 0.03333333507180214) {
                            if (input[3] <= 0.8400000035762787) {
                                if (input[10] <= 0.5) {
                                    if (input[9] <= 0.5) {
                                        if (input[12] <= 2.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[13] <= -0.12999999895691872) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        var23 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.9699999988079071) {
                                if (input[5] <= 2.5) {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[9] <= 1.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var23 = new double[3] {0.13838768415825192, 0.861612315841748, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 2.5) {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var23 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    var23 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var23 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 2.5) {
                            var23 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 0.5) {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 3.5) {
                                    if (input[9] <= 2.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var23 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var23 = new double[3] {0.3304432838508833, 0.6695567161491167, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.21000000089406967) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.12999999895691872) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var23 = new double[3] {0.4791353947763434, 0.5208646052236565, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.5999999791383743) {
                                            var23 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var23 = new double[3] {0.34454098979977327, 0.6554590102002267, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    if (input[9] <= 0.5) {
                        if (input[13] <= -0.029999999329447746) {
                            if (input[7] <= 1.5) {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 3.5) {
                                    if (input[2] <= 0.03333333507180214) {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var23 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var23 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= 0.12999999895691872) {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            if (input[13] <= 0.26999999582767487) {
                                if (input[1] <= 0.7699999809265137) {
                                    if (input[11] <= 5.5) {
                                        if (input[5] <= 1.5) {
                                            var23 = new double[3] {0.043530636829532246, 0.0, 0.9564693631704678};
                                        } else {
                                            var23 = new double[3] {0.08258844265390912, 0.0, 0.9174115573460908};
                                        }
                                    } else {
                                        if (input[13] <= 0.04999999888241291) {
                                            var23 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[6] <= 0.5) {
                                        if (input[12] <= 3.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.07494858709726561, 0.0, 0.9250514129027343};
                                        }
                                    } else {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var23 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[3] <= 0.5999999940395355) {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[13] <= 0.08999999798834324) {
                                        if (input[10] <= 3.5) {
                                            var23 = new double[3] {0.38569573940752977, 0.6143042605924702, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[11] <= 3.5) {
                                        if (input[12] <= 2.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.3064462867372297, 0.6935537132627703, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 3.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.5324710320668283, 0.4675289679331717, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[10] <= 1.5) {
                                    var23 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[10] <= 2.5) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.09785326961646074, 0.9021467303835393, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var23 = new double[3] {0.17373083150776267, 0.8262691684922374, 0.0};
                                        } else {
                                            var23 = new double[3] {0.48417923125929074, 0.5158207687407094, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= 0.03333333507180214) {
                            if (input[5] <= 0.5) {
                                if (input[1] <= 0.30000000447034836) {
                                    if (input[2] <= 0.03333333507180214) {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var23 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var23 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.1666666716337204) {
                                    var23 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 1.5) {
                                        if (input[3] <= 0.4000000059604645) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.09999999776482582) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 3.5) {
                                var23 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    var23 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[4] <= 0.10000000521540642) {
                                            var23 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var23 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    } else {
                                        var23 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var24;
            if (input[9] <= 0.5) {
                if (input[13] <= 0.009999999776482582) {
                    if (input[12] <= 2.5) {
                        if (input[2] <= 0.10000000521540642) {
                            var24 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[2] <= 0.1666666716337204) {
                                    if (input[13] <= -0.14999999850988388) {
                                        if (input[11] <= 1.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 3.5) {
                            if (input[11] <= 1.5) {
                                if (input[12] <= 3.5) {
                                    if (input[6] <= 0.5) {
                                        if (input[10] <= 0.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.17966903073286053, 0.8203309692671394, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[12] <= 3.5) {
                                        if (input[1] <= 0.10999999940395355) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.10847844704538964, 0.8915215529546103, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 6.5) {
                                            var24 = new double[3] {0.3911568604515148, 0.6088431395484852, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.5499999821186066) {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[3] <= 0.6000000238418579) {
                                        if (input[6] <= 0.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var24 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[12] <= 3.5) {
                                            var24 = new double[3] {0.19698231972600205, 0.803017680273998, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[12] <= 3.5) {
                            var24 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[4] <= 0.1666666716337204) {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.06666667014360428) {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[7] <= 0.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[13] <= 0.25999999791383743) {
                            if (input[7] <= 6.5) {
                                if (input[11] <= 2.5) {
                                    if (input[13] <= 0.04999999888241291) {
                                        if (input[12] <= 2.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.35685160014827627, 0.6431483998517238, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.7800000011920929) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[13] <= 0.17000000178813934) {
                                            var24 = new double[3] {0.23892381927182335, 0.7610761807281767, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= 0.03999999910593033) {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[12] <= 4.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    if (input[4] <= 0.06666667014360428) {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var24 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.5299999862909317) {
                                if (input[13] <= 0.3699999898672104) {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[12] <= 2.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.031808035714285705, 0.9681919642857142, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[13] <= -0.06999999843537807) {
                    if (input[0] <= 0.5) {
                        if (input[10] <= 0.5) {
                            var24 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[12] <= 3.5) {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[8] <= 0.5) {
                                    if (input[10] <= 2.5) {
                                        if (input[5] <= 4.5) {
                                            var24 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var24 = new double[3] {0.24859246427024684, 0.0, 0.7514075357297532};
                                        } else {
                                            var24 = new double[3] {0.24859246427024684, 0.0, 0.7514075357297532};
                                        }
                                    }
                                } else {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[7] <= 1.5) {
                            if (input[10] <= 2.5) {
                                if (input[5] <= 6.5) {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.31844965300510675, 0.6815503469948934, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var24 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 1.5) {
                                        if (input[1] <= 0.4999999850988388) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.44086368030937806, 0.559136319690622, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.17999999970197678) {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 5.0) {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[4] <= 0.10000000521540642) {
                                            var24 = new double[3] {0.3867957870926698, 0.6132042129073301, 0.0};
                                        } else {
                                            var24 = new double[3] {0.13838768415825195, 0.861612315841748, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[9] <= 1.5) {
                        if (input[0] <= 0.5) {
                            if (input[14] <= -0.23333334177732468) {
                                var24 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.75) {
                                    if (input[10] <= 5.5) {
                                        if (input[12] <= 3.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.056534151599308635, 0.0, 0.9434658484006914};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.7400000095367432) {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.13018048128342247, 0.0, 0.8698195187165775};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.9600000083446503) {
                                if (input[1] <= 0.4299999922513962) {
                                    if (input[12] <= 3.5) {
                                        if (input[3] <= 0.3700000047683716) {
                                            var24 = new double[3] {0.4353316409555425, 0.5646683590444574, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var24 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[14] <= 0.03333333507180214) {
                                    if (input[5] <= 0.5) {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var24 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[14] <= 0.10000000521540642) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.06666667014360428) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var24 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[6] <= 0.5) {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[1] <= 0.21000000089406967) {
                                            var24 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var24 = new double[3] {0.6848090687788393, 0.31519093122116065, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[1] <= 0.4399999976158142) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.17373083150776264, 0.8262691684922373, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= 0.019999999552965164) {
                                    if (input[9] <= 2.5) {
                                        if (input[3] <= 0.5700000077486038) {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var24 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    } else {
                                        var24 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.4599999878555536) {
                                        var24 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var24 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var24 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var25;
            if (input[12] <= 3.5) {
                if (input[9] <= 2.5) {
                    if (input[0] <= 0.5) {
                        var25 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[2] <= 0.10000000521540642) {
                            if (input[7] <= 0.5) {
                                if (input[14] <= -0.03333333507180214) {
                                    if (input[12] <= 2.5) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.09615241497358042, 0.9038475850264196, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.1699999999254942) {
                                        if (input[3] <= 0.9600000083446503) {
                                            var25 = new double[3] {0.14484276936220553, 0.8551572306377946, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[10] <= 1.5) {
                                    if (input[11] <= 0.5) {
                                        if (input[4] <= 0.10000000149011612) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var25 = new double[3] {0.1427018480086965, 0.8572981519913035, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 2.5) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 6.5) {
                                            var25 = new double[3] {0.32014106583072055, 0.6798589341692793, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[10] <= 4.5) {
                                if (input[13] <= 0.10999999940395355) {
                                    if (input[5] <= 5.5) {
                                        if (input[3] <= 0.9900000095367432) {
                                            var25 = new double[3] {0.32793911072067, 0.6238753915574158, 0.04818549772191421};
                                        } else {
                                            var25 = new double[3] {0.21896101557576303, 0.781038984424237, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= -0.03333333507180214) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[11] <= 3.5) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 4.5) {
                                    if (input[12] <= 2.5) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.35999999940395355) {
                                            var25 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.3391195516134299, 0.6608804483865702, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 6.0) {
                                        var25 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[14] <= -0.1666666716337204) {
                        var25 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        var25 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[12] <= 5.0) {
                    if (input[13] <= -0.04999999888241291) {
                        if (input[0] <= 0.5) {
                            if (input[2] <= 0.03333333507180214) {
                                var25 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.5199999958276749) {
                                    if (input[5] <= 5.0) {
                                        if (input[2] <= 0.23333334177732468) {
                                            var25 = new double[3] {0.0643231847820758, 0.0, 0.9356768152179242};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 3.5) {
                                if (input[7] <= 4.5) {
                                    var25 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 1.5) {
                                        if (input[3] <= 0.32999999821186066) {
                                            var25 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var25 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[10] <= 1.5) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 1.5) {
                                            var25 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var25 = new double[3] {0.12294004650692548, 0.8770599534930745, 0.0};
                                        }
                                    }
                                } else {
                                    var25 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[14] <= -0.03333333507180214) {
                                if (input[8] <= 0.5) {
                                    if (input[0] <= 0.5) {
                                        if (input[13] <= 0.05999999865889549) {
                                            var25 = new double[3] {0.2063129002744739, 0.0, 0.7936870997255261};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= -0.029999999329447746) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[10] <= 1.5) {
                                    if (input[11] <= 1.5) {
                                        if (input[10] <= 0.5) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[3] <= 0.03999999910593033) {
                                    var25 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.3200000077486038) {
                                        if (input[7] <= 0.5) {
                                            var25 = new double[3] {0.23037113706934792, 0.0, 0.769628862930652};
                                        } else {
                                            var25 = new double[3] {0.07059498756456858, 0.0, 0.9294050124354314};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var25 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[7] <= 1.5) {
                        if (input[0] <= 0.5) {
                            var25 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[7] <= 0.5) {
                                var25 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[3] <= 0.6599999964237213) {
                                    if (input[3] <= 0.1900000013411045) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var25 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var25 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[7] <= 4.5) {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[5] <= 0.5) {
                                        var25 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[11] <= 3.5) {
                                            var25 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 0.5) {
                                    if (input[13] <= 0.0) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.1899999976158142) {
                                            var25 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var25 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var25 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var26;
            if (input[10] <= 3.5) {
                if (input[0] <= 0.5) {
                    if (input[9] <= 0.5) {
                        if (input[4] <= 0.10000000521540642) {
                            if (input[10] <= 0.5) {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[11] <= 1.5) {
                                if (input[3] <= 0.4699999988079071) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.10000000521540642) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.0) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 3.5) {
                            if (input[12] <= 3.5) {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 0.5) {
                                    if (input[7] <= 1.5) {
                                        if (input[1] <= 0.15999999456107616) {
                                            var26 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 4.5) {
                                            var26 = new double[3] {0.07132343101833268, 0.0, 0.9286765689816673};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.9300000071525574) {
                                        if (input[7] <= 2.5) {
                                            var26 = new double[3] {0.06778259971068404, 0.0, 0.9322174002893159};
                                        } else {
                                            var26 = new double[3] {0.01332358436916078, 0.0, 0.9866764156308392};
                                        }
                                    } else {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.5900000035762787) {
                                if (input[11] <= 2.5) {
                                    if (input[3] <= 0.06999999843537807) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.24000000208616257) {
                                        if (input[9] <= 1.5) {
                                            var26 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= -0.10000000521540642) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 3.5) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.8699999749660492) {
                                            var26 = new double[3] {0.06913466697325055, 0.0, 0.9308653330267493};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[12] <= 2.5) {
                        if (input[11] <= 1.5) {
                            var26 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[2] <= 0.10000000521540642) {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 3.5) {
                                    if (input[11] <= 2.5) {
                                        if (input[3] <= 0.29999999701976776) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        if (input[7] <= 2.5) {
                                            var26 = new double[3] {0.24859246427024684, 0.0, 0.7514075357297532};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[14] <= 0.23333334177732468) {
                            if (input[3] <= 0.22999999672174454) {
                                if (input[7] <= 5.5) {
                                    if (input[5] <= 1.5) {
                                        if (input[11] <= 2.5) {
                                            var26 = new double[3] {0.22602230483271377, 0.7739776951672863, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.17000000178813934) {
                                            var26 = new double[3] {0.36028443508032654, 0.6397155649196735, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.13999999687075615) {
                                        if (input[11] <= 1.0) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 1.5) {
                                            var26 = new double[3] {0.24859246427024684, 0.0, 0.7514075357297532};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[3] <= 0.3999999910593033) {
                                            var26 = new double[3] {0.17059838297341673, 0.8294016170265832, 0.0};
                                        } else {
                                            var26 = new double[3] {0.2683273672338543, 0.7316726327661457, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.029999999329447746) {
                                            var26 = new double[3] {0.221624046657694, 0.778375953342306, 0.0};
                                        } else {
                                            var26 = new double[3] {0.4767476928644671, 0.523252307135533, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 2.5) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var26 = new double[3] {0.7540751240255138, 0.2459248759744862, 0.0};
                                        } else {
                                            var26 = new double[3] {0.3403320518778252, 0.6596679481221748, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 3.5) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[10] <= 2.0) {
                                if (input[3] <= 0.39000000059604645) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 1.5) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var26 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 4.5) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var26 = new double[3] {0.0, 0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[13] <= 0.06999999843537807) {
                    if (input[13] <= -0.17000000178813934) {
                        if (input[12] <= 2.5) {
                            var26 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[11] <= 3.5) {
                                    if (input[14] <= -0.10000000521540642) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 4.5) {
                                            var26 = new double[3] {0.17966903073286056, 0.8203309692671394, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[12] <= 2.5) {
                            var26 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[12] <= 5.0) {
                                    if (input[3] <= 0.7800000011920929) {
                                        if (input[11] <= 1.5) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {0.1459092251649109, 0.8540907748350891, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var26 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 1.5) {
                                    if (input[13] <= -0.029999999329447746) {
                                        if (input[9] <= 1.5) {
                                            var26 = new double[3] {0.38030487137285446, 0.38302764231728087, 0.23666748630986462};
                                        } else {
                                            var26 = new double[3] {0.8525537520183564, 0.14744624798164357, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var26 = new double[3] {0.36637206924256815, 0.633627930757432, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[11] <= 3.5) {
                                            var26 = new double[3] {0.6366492146596859, 0.3633507853403142, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.03333333507180214) {
                        if (input[12] <= 3.5) {
                            var26 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 1.5) {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[9] <= 0.5) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var26 = new double[3] {0.0, 0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.5600000023841858) {
                            if (input[1] <= 0.4999999850988388) {
                                if (input[5] <= 3.5) {
                                    if (input[3] <= 0.0800000000745058) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 2.5) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 6.5) {
                                            var26 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[10] <= 5.0) {
                                            var26 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[14] <= -0.03333333507180214) {
                                    var26 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.6200000047683716) {
                                        var26 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var26 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        } else {
                                            var26 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var26 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var27;
            if (input[13] <= 0.009999999776482582) {
                if (input[0] <= 0.5) {
                    if (input[2] <= 0.03333333507180214) {
                        if (input[12] <= 5.0) {
                            if (input[11] <= 2.5) {
                                var27 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 3.5) {
                                    if (input[13] <= -0.029999999329447746) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 2.5) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 4.5) {
                                        if (input[7] <= 2.0) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {0.17538022813688212, 0.0, 0.8246197718631179};
                                        }
                                    } else {
                                        var27 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var27 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 0.3700000047683716) {
                            if (input[11] <= 3.5) {
                                if (input[14] <= -0.03333333507180214) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[7] <= 0.5) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var27 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var27 = new double[3] {0.14193867457962414, 0.0, 0.8580613254203758};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= 0.03333333507180214) {
                                    if (input[3] <= 0.22999999672174454) {
                                        var27 = new double[3] {0.00936393742149138, 0.0, 0.9906360625785087};
                                    } else {
                                        if (input[11] <= 4.5) {
                                            var27 = new double[3] {0.05578231292517007, 0.0, 0.94421768707483};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.0) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 4.5) {
                                if (input[12] <= 3.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[7] <= 0.5) {
                                            var27 = new double[3] {0.4305874630784378, 0.0, 0.5694125369215622};
                                        } else {
                                            var27 = new double[3] {0.07973833097595473, 0.0, 0.9202616690240452};
                                        }
                                    } else {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.13000000268220901) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.30000001192092896) {
                        if (input[13] <= -0.12999999895691872) {
                            if (input[5] <= 0.5) {
                                if (input[3] <= 0.6100000143051147) {
                                    if (input[3] <= 0.5600000023841858) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var27 = new double[3] {0.5678704856787049, 0.43212951432129515, 0.0};
                                        } else {
                                            var27 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var27 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 2.5) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.8299999833106995) {
                                            var27 = new double[3] {0.3519832673489206, 0.6480167326510794, 0.0};
                                        } else {
                                            var27 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[11] <= 3.5) {
                                    if (input[14] <= 0.23333334177732468) {
                                        if (input[12] <= 2.5) {
                                            var27 = new double[3] {0.6093222247241612, 0.0, 0.39067777527583875};
                                        } else {
                                            var27 = new double[3] {0.4371877770809451, 0.5628122229190549, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var27 = new double[3] {0.19414770088248953, 0.8058522991175104, 0.0};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= -0.03333333507180214) {
                                            var27 = new double[3] {0.0654960680814392, 0.9345039319185608, 0.0};
                                        } else {
                                            var27 = new double[3] {0.3098647573587908, 0.6901352426412092, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                if (input[12] <= 2.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[13] <= -0.10999999940395355) {
                                            var27 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var27 = new double[3] {0.2875318922630546, 0.7124681077369454, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var27 = new double[3] {0.08464740019930826, 0.9153525998006916, 0.0};
                                        } else {
                                            var27 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.06000000052154064) {
                                    if (input[1] <= 0.550000011920929) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var27 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        } else {
                                            var27 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 4.0) {
                                        var27 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var27 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[9] <= 0.5) {
                    if (input[0] <= 0.5) {
                        if (input[5] <= 6.5) {
                            if (input[7] <= 1.5) {
                                if (input[12] <= 3.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.10000000521540642) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var27 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[12] <= 2.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 0.2199999988079071) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var27 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.03333333507180214) {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[12] <= 5.0) {
                                    if (input[11] <= 1.5) {
                                        if (input[8] <= 0.5) {
                                            var27 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        } else {
                                            var27 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                } else {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[8] <= 0.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var27 = new double[3] {0.0, 0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.1666666716337204) {
                                if (input[3] <= 0.029999999329447746) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[11] <= 0.5) {
                                            var27 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var27 = new double[3] {0.16466056812710636, 0.8353394318728936, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.25999999791383743) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var27 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[9] <= 1.5) {
                            if (input[12] <= 3.5) {
                                var27 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.23333334177732468) {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[10] <= 3.5) {
                                            var27 = new double[3] {0.0670237250220473, 0.0, 0.9329762749779528};
                                        } else {
                                            var27 = new double[3] {0.2209250112258644, 0.0, 0.7790749887741356};
                                        }
                                    } else {
                                        if (input[13] <= 0.26999999582767487) {
                                            var27 = new double[3] {0.03290896524046288, 0.0, 0.9670910347595372};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 4.0) {
                                        if (input[10] <= 1.5) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var27 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                var27 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var27 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[9] <= 2.5) {
                            if (input[5] <= 2.5) {
                                if (input[14] <= -0.1666666716337204) {
                                    if (input[9] <= 1.5) {
                                        var27 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var27 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                    }
                                } else {
                                    if (input[13] <= 0.04999999888241291) {
                                        if (input[1] <= 0.4699999988079071) {
                                            var27 = new double[3] {0.10459315327713745, 0.8954068467228625, 0.0};
                                        } else {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.10000000521540642) {
                                            var27 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var27 = new double[3] {0.5018662072925638, 0.4981337927074361, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 0.5) {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var27 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var27 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var28;
            if (input[10] <= 3.5) {
                if (input[3] <= 0.8799999952316284) {
                    if (input[4] <= 0.03333333507180214) {
                        if (input[6] <= 0.5) {
                            if (input[5] <= 0.5) {
                                if (input[12] <= 3.5) {
                                    if (input[12] <= 2.5) {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {0.24728850325379612, 0.752711496746204, 0.0};
                                        } else {
                                            var28 = new double[3] {0.6776890209920119, 0.3223109790079881, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.23333334177732468) {
                                        if (input[10] <= 0.5) {
                                            var28 = new double[3] {0.17538022813688212, 0.0, 0.8246197718631179};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.019999999552965164) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.6400000154972076) {
                                    if (input[0] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.17538022813688212, 0.0, 0.8246197718631179};
                                        }
                                    } else {
                                        if (input[13] <= 0.06999999843537807) {
                                            var28 = new double[3] {0.27260446266362326, 0.7273955373363767, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[0] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.7000000178813934) {
                                            var28 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                var28 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 2.5) {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        var28 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[13] <= -0.06999999843537807) {
                            if (input[10] <= 2.5) {
                                if (input[1] <= 0.0800000000745058) {
                                    if (input[3] <= 0.22999999672174454) {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var28 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.12999999895691872) {
                                        if (input[13] <= -0.17999999970197678) {
                                            var28 = new double[3] {0.7863037319866979, 0.21369626801330213, 0.0};
                                        } else {
                                            var28 = new double[3] {0.33661061133055975, 0.10111139381207085, 0.5622779948573695};
                                        }
                                    } else {
                                        if (input[3] <= 0.2800000011920929) {
                                            var28 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var28 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= 0.03333333507180214) {
                                    if (input[0] <= 0.5) {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var28 = new double[3] {0.44762814390321554, 0.5523718560967845, 0.0};
                                        } else {
                                            var28 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var28 = new double[3] {0.44550974752317035, 0.0, 0.5544902524768297};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.2900000065565109) {
                                if (input[5] <= 0.5) {
                                    if (input[13] <= 0.17000000178813934) {
                                        if (input[3] <= 0.4099999964237213) {
                                            var28 = new double[3] {0.4384718215718004, 0.06673233424798893, 0.49479584418021055};
                                        } else {
                                            var28 = new double[3] {0.42020840295288153, 0.5797915970471184, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.1313707820166216, 0.0, 0.8686292179833783};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        if (input[7] <= 0.5) {
                                            var28 = new double[3] {0.8045951120621692, 0.19540488793783087, 0.0};
                                        } else {
                                            var28 = new double[3] {0.5067383931047148, 0.41612604696927363, 0.0771355599260117};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var28 = new double[3] {0.23500881834215168, 0.0, 0.7649911816578484};
                                        } else {
                                            var28 = new double[3] {0.09541699000687377, 0.019107626692281394, 0.8854753833008449};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[13] <= 0.3400000035762787) {
                                        if (input[11] <= 0.5) {
                                            var28 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var28 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= 1.5) {
                        if (input[0] <= 0.5) {
                            var28 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[14] <= 0.0) {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[4] <= 0.06666667014360428) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.2472885032537961, 0.752711496746204, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.9199999868869781) {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 2.5) {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var28 = new double[3] {0.11123307720453714, 0.8887669227954629, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var28 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[14] <= 0.03333333507180214) {
                    if (input[11] <= 4.5) {
                        if (input[11] <= 2.5) {
                            if (input[14] <= -0.03333333507180214) {
                                if (input[6] <= 0.5) {
                                    if (input[3] <= 0.23000000789761543) {
                                        if (input[9] <= 2.5) {
                                            var28 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= 0.14999999850988388) {
                                    if (input[10] <= 4.5) {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 6.5) {
                                        if (input[0] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[7] <= 0.5) {
                                    if (input[5] <= 2.5) {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.04999999888241291) {
                                        if (input[7] <= 3.5) {
                                            var28 = new double[3] {0.05928067955900958, 0.0, 0.9407193204409904};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.4699999839067459) {
                                            var28 = new double[3] {0.3805783648696894, 0.0, 0.6194216351303106};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.1899999976158142) {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        if (input[8] <= 0.5) {
                                            var28 = new double[3] {0.2840845651593485, 0.7159154348406516, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 1.5) {
                            if (input[3] <= 0.44999998807907104) {
                                if (input[1] <= 0.4999999850988388) {
                                    if (input[9] <= 0.5) {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var28 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[7] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var28 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                    }
                                }
                            } else {
                                var28 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var28 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        var28 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[4] <= 0.10000000521540642) {
                            if (input[12] <= 2.5) {
                                var28 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.7800000011920929) {
                                    if (input[12] <= 3.5) {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {0.10224567939563282, 0.8977543206043672, 0.0};
                                        } else {
                                            var28 = new double[3] {0.4791353947763435, 0.5208646052236565, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.27436219155165203, 0.0, 0.725637808448348};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        if (input[14] <= 0.20000001043081284) {
                                            var28 = new double[3] {0.15694849368318756, 0.8430515063168125, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[14] <= 0.10000000521540642) {
                                if (input[5] <= 4.5) {
                                    if (input[5] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var28 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var28 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var28 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 4.0) {
                                        if (input[1] <= 0.39000000059604645) {
                                            var28 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var28 = new double[3] {0.36283510833639365, 0.6371648916636063, 0.0};
                                        }
                                    } else {
                                        var28 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var29;
            if (input[1] <= 0.9900000095367432) {
                if (input[1] <= 0.8499999940395355) {
                    if (input[0] <= 0.5) {
                        if (input[1] <= 0.8100000023841858) {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[12] <= 3.5) {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[1] <= 0.4999999850988388) {
                                            var29 = new double[3] {0.29842296805499396, 0.0, 0.7015770319450061};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 5.0) {
                                            var29 = new double[3] {0.09301178675346446, 0.0, 0.9069882132465356};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var29 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var29 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[14] <= -0.03333333507180214) {
                            if (input[7] <= 0.5) {
                                var29 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 5.5) {
                                    if (input[7] <= 2.5) {
                                        if (input[12] <= 2.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.31455178252281046, 0.6854482174771895, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.10999999940395355) {
                                            var29 = new double[3] {0.2594963721724285, 0.7405036278275716, 0.0};
                                        } else {
                                            var29 = new double[3] {0.09870129870129868, 0.9012987012987013, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 3.0) {
                                        if (input[1] <= 0.4700000137090683) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[12] <= 2.5) {
                                    if (input[3] <= 0.8799999952316284) {
                                        if (input[7] <= 3.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.6298271815660337, 0.0, 0.37017281843396627};
                                        }
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[5] <= 0.5) {
                                            var29 = new double[3] {0.213908148554953, 0.6215106373683981, 0.164581214076649};
                                        } else {
                                            var29 = new double[3] {0.21762265512265488, 0.7823773448773452, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 4.5) {
                                            var29 = new double[3] {0.4394908574013046, 0.5605091425986953, 0.0};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var29 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.20000000298023224) {
                        if (input[3] <= 0.9900000095367432) {
                            if (input[8] <= 0.5) {
                                if (input[4] <= 0.10000000521540642) {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 2.5) {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var29 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 3.5) {
                                    if (input[5] <= 0.5) {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var29 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 2.5) {
                                if (input[14] <= -0.10000000149011612) {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.20000001043081284) {
                                    if (input[9] <= 0.5) {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var29 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.5) {
                            if (input[12] <= 5.0) {
                                if (input[12] <= 3.5) {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.6699999868869781) {
                                        var29 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var29 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var29 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[12] <= 2.5) {
                    var29 = new double[3] {1.0, 0.0, 0.0};
                } else {
                    if (input[9] <= 2.5) {
                        if (input[2] <= 0.23333334177732468) {
                            if (input[0] <= 0.5) {
                                if (input[12] <= 3.5) {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.10000000521540642) {
                                        if (input[9] <= 0.5) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.20000001043081284) {
                                    if (input[4] <= 0.03333333507180214) {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var29 = new double[3] {0.2303711370693479, 0.769628862930652, 0.0};
                                        } else {
                                            var29 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.949999988079071) {
                                var29 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 0.5) {
                                    if (input[9] <= 1.5) {
                                        if (input[12] <= 3.5) {
                                            var29 = new double[3] {0.02143260011280316, 0.9785673998871969, 0.0};
                                        } else {
                                            var29 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        var29 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var29 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var29 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            double[] var30;
            if (input[4] <= 0.1666666716337204) {
                if (input[7] <= 0.5) {
                    if (input[9] <= 2.5) {
                        if (input[4] <= 0.10000000521540642) {
                            if (input[0] <= 0.5) {
                                var30 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 1.5) {
                                    if (input[3] <= 0.7100000083446503) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.6399999856948853) {
                                            var30 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var30 = new double[3] {0.2888549390766479, 0.7111450609233521, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[2] <= 0.1666666716337204) {
                                    if (input[12] <= 2.5) {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.3399999886751175) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.22602230483271374, 0.7739776951672863, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    if (input[10] <= 1.5) {
                                        if (input[11] <= 1.0) {
                                            var30 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        } else {
                                            var30 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.8700000047683716) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.24866477409421164, 0.7513352259057883, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[9] <= 1.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[13] <= -0.1600000038743019) {
                            var30 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var30 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[13] <= -0.06999999843537807) {
                        if (input[0] <= 0.5) {
                            if (input[9] <= 0.5) {
                                var30 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 0.5) {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[3] <= 0.3200000077486038) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.09418398245797222, 0.0, 0.9058160175420278};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 4.5) {
                                if (input[11] <= 5.5) {
                                    if (input[12] <= 2.5) {
                                        if (input[3] <= 0.3500000089406967) {
                                            var30 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var30 = new double[3] {0.3131921113265187, 0.6868078886734812, 0.0};
                                        } else {
                                            var30 = new double[3] {0.14909269249632173, 0.8509073075036784, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.20000001043081284) {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    if (input[4] <= 0.06666667014360428) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.0) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[12] <= 3.5) {
                                            var30 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[11] <= 2.5) {
                                if (input[1] <= 0.8100000023841858) {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[10] <= 3.5) {
                                            var30 = new double[3] {0.1454043936557975, 0.0, 0.8545956063442025};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= -0.04999999888241291) {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.9900000095367432) {
                                        if (input[5] <= 0.5) {
                                            var30 = new double[3] {0.6482870464220556, 0.0, 0.35171295357794446};
                                        } else {
                                            var30 = new double[3] {0.14960243982137023, 0.0, 0.8503975601786298};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 5.0) {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[12] <= 3.5) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.15694849368318756, 0.8430515063168126, 0.0};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.8100000023841858) {
                                        if (input[12] <= 2.5) {
                                            var30 = new double[3] {0.4526813880126183, 0.0, 0.5473186119873817};
                                        } else {
                                            var30 = new double[3] {0.35805727535087906, 0.641942724649121, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.5595328763645595, 0.44046712363544044, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.2499999925494194) {
                                    if (input[3] <= 0.21000000089406967) {
                                        if (input[7] <= 2.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var30 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[11] <= 3.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= 0.9199999868869781) {
                    if (input[9] <= 0.5) {
                        if (input[5] <= 6.5) {
                            if (input[3] <= 0.28999999165534973) {
                                var30 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.6299999952316284) {
                                    if (input[13] <= 0.06999999843537807) {
                                        if (input[12] <= 2.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.1291169543225607, 0.8708830456774393, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.23333334177732468) {
                                            var30 = new double[3] {0.398196323274367, 0.0, 0.6018036767256331};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.9500000178813934) {
                                        if (input[4] <= 0.23333334177732468) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.04999999888241291) {
                                if (input[7] <= 0.5) {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var30 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[11] <= 0.5) {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            if (input[12] <= 3.5) {
                                if (input[10] <= 2.5) {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[6] <= 0.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var30 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var30 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.23333334177732468) {
                                    if (input[0] <= 0.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var30 = new double[3] {0.08898379248783563, 0.0, 0.9110162075121643};
                                        } else {
                                            var30 = new double[3] {0.0305457254609797, 0.0, 0.9694542745390203};
                                        }
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= -0.10999999940395355) {
                                        if (input[11] <= 3.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.47999998927116394) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {0.03423323128305037, 0.0, 0.9657667687169496};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[14] <= -0.1666666716337204) {
                                if (input[5] <= 0.5) {
                                    if (input[9] <= 2.5) {
                                        var30 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                    } else {
                                        var30 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var30 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.23333334177732468) {
                        var30 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[3] <= 0.949999988079071) {
                            var30 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[0] <= 0.5) {
                                    var30 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        var30 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var30 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var30 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var31;
            if (input[11] <= 2.5) {
                if (input[0] <= 0.5) {
                    if (input[9] <= 0.5) {
                        if (input[1] <= 0.4299999922513962) {
                            var31 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[1] <= 0.45000000298023224) {
                                if (input[14] <= -0.10000000521540642) {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.06666667014360428) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var31 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            } else {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.4999999850988388) {
                            if (input[1] <= 0.28999999165534973) {
                                if (input[1] <= 0.17999999970197678) {
                                    if (input[7] <= 3.5) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 5.5) {
                                            var31 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        } else {
                                            var31 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        var31 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    } else {
                                        if (input[13] <= 0.0800000000745058) {
                                            var31 = new double[3] {0.00936393742149138, 0.0, 0.9906360625785087};
                                        } else {
                                            var31 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 5.5) {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[12] <= 3.5) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {0.09932514275826268, 0.0, 0.9006748572417373};
                                        }
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var31 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[9] <= 2.5) {
                        if (input[9] <= 0.5) {
                            if (input[12] <= 2.5) {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 5.5) {
                                    if (input[3] <= 0.1900000050663948) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var31 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var31 = new double[3] {0.6683234563181036, 0.3316765436818964, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var31 = new double[3] {0.16907413987548084, 0.8309258601245192, 0.0};
                                        } else {
                                            var31 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[3] <= 0.029999999329447746) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {0.08488722037789706, 0.9151127796221029, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 1.0) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                if (input[13] <= -0.029999999329447746) {
                                    if (input[7] <= 5.5) {
                                        if (input[13] <= -0.04999999888241291) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.3500000089406967) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {0.3251653053286659, 0.6748346946713342, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[12] <= 3.5) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var31 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 6.5) {
                                    if (input[10] <= 4.5) {
                                        if (input[7] <= 5.5) {
                                            var31 = new double[3] {0.3386988008326737, 0.6613011991673263, 0.0};
                                        } else {
                                            var31 = new double[3] {0.08055113937466878, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.17999999970197678) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var31 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= 0.03333333507180214) {
                    if (input[9] <= 0.5) {
                        if (input[3] <= 0.6300000250339508) {
                            var31 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[13] <= 0.10999999940395355) {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[7] <= 1.5) {
                                        if (input[14] <= -0.10000000521540642) {
                                            var31 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var31 = new double[3] {0.3445409897997733, 0.6554590102002268, 0.0};
                                        }
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            if (input[14] <= -0.10000000521540642) {
                                if (input[11] <= 3.5) {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.17999999970197678) {
                                        if (input[11] <= 4.5) {
                                            var31 = new double[3] {0.052257829570284055, 0.0, 0.947742170429716};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var31 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.009999999776482582) {
                                    if (input[3] <= 0.6800000071525574) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.5600000023841858) {
                                            var31 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 0.5) {
                                            var31 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var31 = new double[3] {0.05225782957028406, 0.0, 0.947742170429716};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[13] <= -0.13000000081956387) {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        var31 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[14] <= 0.1666666716337204) {
                        if (input[0] <= 0.5) {
                            if (input[12] <= 3.5) {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[11] <= 5.5) {
                                        if (input[13] <= 0.20000000298023224) {
                                            var31 = new double[3] {0.1010844514319404, 0.0, 0.8989155485680594};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.26999999582767487) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[10] <= 2.5) {
                                    if (input[6] <= 0.5) {
                                        if (input[13] <= 0.06999999843537807) {
                                            var31 = new double[3] {0.5324710320668283, 0.46752896793317167, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.0) {
                                            var31 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var31 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.5) {
                                        if (input[7] <= 4.5) {
                                            var31 = new double[3] {0.2822114365861776, 0.7177885634138224, 0.0};
                                        } else {
                                            var31 = new double[3] {0.4268252395110671, 0.573174760488933, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.9199999868869781) {
                                            var31 = new double[3] {0.45277729104608383, 0.5472227089539162, 0.0};
                                        } else {
                                            var31 = new double[3] {0.7779910428662827, 0.2220089571337172, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var31 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.9500000178813934) {
                            if (input[4] <= 0.03333333507180214) {
                                if (input[1] <= 0.6899999976158142) {
                                    if (input[9] <= 0.5) {
                                        if (input[12] <= 3.5) {
                                            var31 = new double[3] {0.5678704856787049, 0.4321295143212952, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.6800000071525574) {
                                        var31 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[7] <= 2.0) {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var31 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                if (input[5] <= 0.5) {
                                    if (input[9] <= 0.5) {
                                        var31 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var31 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                    }
                                } else {
                                    var31 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                var31 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var32;
            if (input[9] <= 0.5) {
                if (input[7] <= 4.5) {
                    if (input[14] <= -0.1666666716337204) {
                        if (input[3] <= 0.4299999922513962) {
                            if (input[10] <= 5.5) {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var32 = new double[3] {0.0, 1.0, 0.0};
                            }
                        } else {
                            if (input[11] <= 1.5) {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[12] <= 2.5) {
                            if (input[4] <= 0.1666666716337204) {
                                if (input[7] <= 0.5) {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var32 = new double[3] {0.3865645256334708, 0.0, 0.6134354743665292};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= -0.10000000521540642) {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[7] <= 0.5) {
                                if (input[3] <= 0.9699999988079071) {
                                    if (input[3] <= 0.6700000166893005) {
                                        if (input[12] <= 3.5) {
                                            var32 = new double[3] {0.24976217244659693, 0.7502378275534031, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 1.5) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 2.5) {
                                        if (input[12] <= 5.0) {
                                            var32 = new double[3] {0.223515120516591, 0.7764848794834089, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.06999999843537807) {
                                    if (input[12] <= 3.5) {
                                        if (input[5] <= 6.5) {
                                            var32 = new double[3] {0.08901813481966153, 0.9109818651803384, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var32 = new double[3] {0.36870830806549426, 0.6312916919345058, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[0] <= 0.5) {
                                            var32 = new double[3] {0.5172061960857063, 0.0, 0.4827938039142936};
                                        } else {
                                            var32 = new double[3] {0.2651052697147128, 0.7348947302852871, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[14] <= 0.03333333507180214) {
                        if (input[14] <= -0.10000000521540642) {
                            if (input[4] <= 0.1666666716337204) {
                                var32 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                            } else {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var32 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var32 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[6] <= 0.5) {
                                if (input[14] <= 0.23333334177732468) {
                                    if (input[3] <= 0.2199999988079071) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 1.5) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {0.2397686442905968, 0.7602313557094031, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.3699999898672104) {
                                        if (input[12] <= 2.5) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        var32 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    }
                                }
                            } else {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[9] <= 1.5) {
                    if (input[0] <= 0.5) {
                        if (input[3] <= 0.4999999850988388) {
                            if (input[1] <= 0.03999999910593033) {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 6.5) {
                                    if (input[11] <= 3.5) {
                                        if (input[7] <= 0.5) {
                                            var32 = new double[3] {0.32093933463796476, 0.0, 0.6790606653620352};
                                        } else {
                                            var32 = new double[3] {0.12676157607132588, 0.0, 0.8732384239286741};
                                        }
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var32 = new double[3] {0.03597017107764293, 0.0, 0.964029828922357};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[13] <= 0.03999999910593033) {
                                            var32 = new double[3] {0.007815478459778877, 0.0, 0.9921845215402211};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var32 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.12999999895691872) {
                                if (input[3] <= 0.5300000011920929) {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 5.5) {
                                        if (input[10] <= 5.0) {
                                            var32 = new double[3] {0.11453436836874482, 0.0, 0.8854656316312552};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[6] <= 0.5) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var32 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[11] <= 0.5) {
                            var32 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[11] <= 4.5) {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[12] <= 2.5) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 5.5) {
                                            var32 = new double[3] {0.3867957870926693, 0.6132042129073307, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[1] <= 0.5300000011920929) {
                        if (input[0] <= 0.5) {
                            var32 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[7] <= 4.5) {
                                if (input[1] <= 0.4999999850988388) {
                                    if (input[1] <= 0.3999999910593033) {
                                        if (input[7] <= 0.5) {
                                            var32 = new double[3] {0.3538175046554935, 0.6461824953445066, 0.0};
                                        } else {
                                            var32 = new double[3] {0.6277622827719374, 0.37223771722806265, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {0.46697388632872505, 0.5330261136712751, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.6700000166893005) {
                                        if (input[11] <= 3.0) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var32 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[9] <= 2.5) {
                                    if (input[3] <= 0.22999999672174454) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var32 = new double[3] {0.3445409897997733, 0.6554590102002267, 0.0};
                                        } else {
                                            var32 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 2.5) {
                            if (input[2] <= 0.1666666716337204) {
                                if (input[14] <= -0.1666666716337204) {
                                    if (input[3] <= 0.8599999845027924) {
                                        if (input[3] <= 0.5999999940395355) {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var32 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var32 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 4.5) {
                                        if (input[7] <= 2.0) {
                                            var32 = new double[3] {0.3867957870926699, 0.6132042129073303, 0.0};
                                        } else {
                                            var32 = new double[3] {0.5508672016567435, 0.4491327983432566, 0.0};
                                        }
                                    } else {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= 0.23333334177732468) {
                                    var32 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[6] <= 0.5) {
                                        var32 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var32 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= -0.3200000077486038) {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var32 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var33;
            if (input[12] <= 3.5) {
                if (input[3] <= 0.21000000089406967) {
                    if (input[2] <= 0.03333333507180214) {
                        var33 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[13] <= -0.04999999888241291) {
                            var33 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[3] <= 0.07000000029802322) {
                                if (input[9] <= 2.5) {
                                    if (input[9] <= 1.5) {
                                        if (input[12] <= 2.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 6.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= 0.019999999552965164) {
                                    if (input[12] <= 2.5) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.27517058905444924, 0.7248294109455509, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.17999999970197678) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        var33 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[1] <= 0.7100000083446503) {
                            if (input[1] <= 0.6700000166893005) {
                                if (input[3] <= 0.4699999988079071) {
                                    if (input[9] <= 2.5) {
                                        if (input[12] <= 2.5) {
                                            var33 = new double[3] {0.7067770829812405, 0.0, 0.2932229170187595};
                                        } else {
                                            var33 = new double[3] {0.22084268920882277, 0.7791573107911773, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[11] <= 5.5) {
                                            var33 = new double[3] {0.26404346860039984, 0.7359565313996, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 3.5) {
                                            var33 = new double[3] {0.5962567733785443, 0.40374322662145573, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 5.5) {
                                    if (input[3] <= 0.7899999916553497) {
                                        if (input[9] <= 2.5) {
                                            var33 = new double[3] {0.22602230483271377, 0.7739776951672863, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.0654960680814392, 0.9345039319185608, 0.0};
                                        }
                                    }
                                } else {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[10] <= 4.5) {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[1] <= 0.7700000107288361) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.24103237095363084, 0.7589676290463692, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var33 = new double[3] {0.6441998769567293, 0.3558001230432707, 0.0};
                                        } else {
                                            var33 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 2.5) {
                                        if (input[13] <= -0.17999999970197678) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.09870129870129869, 0.9012987012987013, 0.0};
                                        }
                                    } else {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    if (input[5] <= 3.5) {
                                        if (input[6] <= 0.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var33 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    if (input[11] <= 2.5) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var33 = new double[3] {0.09870129870129869, 0.9012987012987013, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[13] <= -0.04999999888241291) {
                    if (input[0] <= 0.5) {
                        if (input[5] <= 3.5) {
                            if (input[13] <= -0.3400000035762787) {
                                var33 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 5.5) {
                                        if (input[1] <= 0.04999999888241291) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.14977502561589523, 0.0, 0.8502249743841048};
                                        }
                                    } else {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.8299999833106995) {
                                var33 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 4.5) {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var33 = new double[3] {0.0, 0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[11] <= 3.5) {
                            if (input[5] <= 0.5) {
                                if (input[11] <= 2.5) {
                                    if (input[4] <= 0.06666667014360428) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 5.0) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var33 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 2.5) {
                                    if (input[5] <= 1.5) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var33 = new double[3] {0.3687083080654942, 0.6312916919345057, 0.0};
                                        } else {
                                            var33 = new double[3] {0.5678704856787049, 0.43212951432129515, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var33 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                } else {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[2] <= 0.03333333507180214) {
                                    var33 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    if (input[3] <= 0.4999999850988388) {
                                        if (input[7] <= 3.0) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.7299999892711639) {
                                            var33 = new double[3] {0.03618760415840013, 0.9638123958415998, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var33 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[9] <= 0.5) {
                        if (input[14] <= 0.23333334177732468) {
                            if (input[2] <= 0.23333334177732468) {
                                if (input[11] <= 4.5) {
                                    if (input[2] <= 0.1666666716337204) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.10000000521540642) {
                                            var33 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    if (input[12] <= 5.0) {
                                        if (input[5] <= 0.5) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[13] <= 0.09999999776482582) {
                                if (input[7] <= 2.5) {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var33 = new double[3] {0.0, 0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[7] <= 0.5) {
                            if (input[3] <= 0.5700000077486038) {
                                if (input[14] <= -0.03333333507180214) {
                                    if (input[1] <= 0.1899999976158142) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 2.0) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {0.05578231292517007, 0.0, 0.9442176870748299};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 2.5) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.08999999985098839) {
                                            var33 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 0.5) {
                                    var33 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.9099999964237213) {
                                        if (input[4] <= 0.13333333656191826) {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var33 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var33 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[12] <= 5.0) {
                                if (input[0] <= 0.5) {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[4] <= 0.10000000521540642) {
                                            var33 = new double[3] {0.07350192623107146, 0.0, 0.9264980737689285};
                                        } else {
                                            var33 = new double[3] {0.03202410176299935, 0.0, 0.9679758982370007};
                                        }
                                    } else {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var33 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var33 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var34;
            if (input[9] <= 1.5) {
                if (input[13] <= -0.04999999888241291) {
                    if (input[0] <= 0.5) {
                        if (input[12] <= 5.0) {
                            if (input[7] <= 0.5) {
                                if (input[10] <= 3.5) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 3.5) {
                                        if (input[9] <= 0.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328564};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= -0.23333334177732468) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 3.5) {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var34 = new double[3] {0.06461244971592088, 0.0, 0.9353875502840792};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var34 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 0.7699999809265137) {
                            if (input[4] <= 0.03333333507180214) {
                                if (input[13] <= -0.09999999776482582) {
                                    if (input[10] <= 3.5) {
                                        if (input[13] <= -0.3100000023841858) {
                                            var34 = new double[3] {0.36283510833639365, 0.6371648916636063, 0.0};
                                        } else {
                                            var34 = new double[3] {0.6821762227514196, 0.31782377724858035, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var34 = new double[3] {0.2063129002744739, 0.0, 0.7936870997255261};
                                        } else {
                                            var34 = new double[3] {0.5324710320668283, 0.4675289679331717, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[12] <= 3.5) {
                                            var34 = new double[3] {0.092731392713962, 0.907268607286038, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 4.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.14999999850988388) {
                                    if (input[1] <= 0.1900000050663948) {
                                        if (input[5] <= 3.0) {
                                            var34 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var34 = new double[3] {0.17280962335423772, 0.8271903766457623, 0.0};
                                        } else {
                                            var34 = new double[3] {0.5595328763645595, 0.44046712363544044, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[6] <= 0.5) {
                                        if (input[12] <= 2.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.16900444748546012, 0.8309955525145398, 0.0};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                if (input[9] <= 0.5) {
                                    var34 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                } else {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[9] <= 0.5) {
                                    if (input[12] <= 2.5) {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.8499999940395355) {
                                            var34 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[8] <= 0.5) {
                            if (input[3] <= 0.9099999964237213) {
                                if (input[1] <= 0.75) {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[12] <= 2.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.37332948060391496, 0.6266705193960851, 0.0};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.9900000095367432) {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.17000000178813934) {
                                            var34 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[11] <= 3.5) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[0] <= 0.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.22950528466116, 0.7704947153388401, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[14] <= 0.10000000521540642) {
                                if (input[0] <= 0.5) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var34 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var34 = new double[3] {0.22351512051659103, 0.776484879483409, 0.0};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[13] <= 0.14999999850988388) {
                                if (input[12] <= 5.0) {
                                    if (input[10] <= 2.5) {
                                        if (input[10] <= 1.5) {
                                            var34 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var34 = new double[3] {0.5508672016567434, 0.44913279834325653, 0.0};
                                        } else {
                                            var34 = new double[3] {0.12628997857001728, 0.07207668184834867, 0.801633339581634};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var34 = new double[3] {0.2063129002744739, 0.0, 0.7936870997255261};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.9600000083446503) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[10] <= 5.5) {
                                if (input[3] <= 0.06000000052154064) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[5] <= 4.5) {
                                            var34 = new double[3] {0.05578231292517009, 0.0, 0.9442176870748299};
                                        } else {
                                            var34 = new double[3] {0.16374027404806174, 0.0, 0.8362597259519383};
                                        }
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[14] <= 0.10000000521540642) {
                    if (input[10] <= 1.5) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[1] <= 0.13999999687075615) {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[13] <= -0.4399999976158142) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        if (input[3] <= 0.6400000154972076) {
                                            var34 = new double[3] {0.10459315327713745, 0.8954068467228625, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 5.5) {
                            if (input[7] <= 0.5) {
                                if (input[8] <= 0.5) {
                                    if (input[5] <= 4.5) {
                                        if (input[13] <= 0.019999999552965164) {
                                            var34 = new double[3] {0.36283510833639365, 0.6371648916636063, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var34 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.4699999988079071) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[7] <= 6.5) {
                                            var34 = new double[3] {0.26479589434530815, 0.7352041056546919, 0.0};
                                        } else {
                                            var34 = new double[3] {0.6683234563181036, 0.3316765436818964, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 3.5) {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var34 = new double[3] {0.3251653053286659, 0.6748346946713342, 0.0};
                                        } else {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var34 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 0.3700000047683716) {
                        var34 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[13] <= -0.06999999843537807) {
                            if (input[4] <= 0.03333333507180214) {
                                if (input[13] <= -0.22999999672174454) {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.17999999970197678) {
                                        if (input[1] <= 0.4999999850988388) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var34 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 0.7000000178813934) {
                                if (input[11] <= 4.5) {
                                    if (input[5] <= 0.5) {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.12740989103101424, 0.8725901089689857, 0.0};
                                        }
                                    }
                                } else {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= -0.029999999329447746) {
                                    if (input[9] <= 2.5) {
                                        if (input[5] <= 0.5) {
                                            var34 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var34 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        var34 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var34 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var35;
            if (input[9] <= 0.5) {
                if (input[12] <= 2.5) {
                    if (input[3] <= 0.3500000089406967) {
                        if (input[5] <= 0.5) {
                            if (input[7] <= 4.5) {
                                if (input[8] <= 0.5) {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var35 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var35 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.5) {
                            var35 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var35 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[14] <= -0.03333333507180214) {
                            if (input[3] <= 0.3999999910593033) {
                                if (input[11] <= 2.5) {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 3.5) {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.2199999988079071) {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var35 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328564};
                                        }
                                    }
                                }
                            } else {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[11] <= 3.5) {
                            if (input[10] <= 5.5) {
                                if (input[13] <= -0.009999999776482582) {
                                    if (input[5] <= 4.5) {
                                        if (input[12] <= 5.0) {
                                            var35 = new double[3] {0.12806338132261208, 0.8719366186773879, 0.0};
                                        } else {
                                            var35 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var35 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 4.5) {
                                        if (input[4] <= 0.1666666716337204) {
                                            var35 = new double[3] {0.5064813686049819, 0.493518631395018, 0.0};
                                        } else {
                                            var35 = new double[3] {0.1646605681271064, 0.8353394318728936, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.23333334177732468) {
                                            var35 = new double[3] {0.14399475908224138, 0.6767865127917266, 0.17921872812603212};
                                        } else {
                                            var35 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.4699999839067459) {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[7] <= 6.5) {
                                if (input[6] <= 0.5) {
                                    if (input[7] <= 0.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var35 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.3500000089406967) {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var35 = new double[3] {0.0856306903883548, 0.9143693096116452, 0.0};
                                        }
                                    }
                                } else {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[12] <= 3.5) {
                    if (input[3] <= 0.17999999970197678) {
                        if (input[5] <= 6.5) {
                            if (input[0] <= 0.5) {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.22999999672174454) {
                                    if (input[10] <= 2.5) {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 2.5) {
                                        var35 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[11] <= 4.5) {
                            if (input[10] <= 0.5) {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[1] <= 0.13999999687075615) {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var35 = new double[3] {0.25949637217242855, 0.7405036278275715, 0.0};
                                        } else {
                                            var35 = new double[3] {0.46821553362348983, 0.5317844663765102, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var35 = new double[3] {0.5678704856787049, 0.4321295143212952, 0.0};
                                        } else {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var35 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[14] <= -0.23333334177732468) {
                        var35 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[14] <= 0.10000000521540642) {
                            if (input[3] <= 0.7000000178813934) {
                                if (input[7] <= 5.5) {
                                    if (input[8] <= 0.5) {
                                        if (input[0] <= 0.5) {
                                            var35 = new double[3] {0.09611878093253454, 0.0, 0.9038812190674654};
                                        } else {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.4699999988079071) {
                                            var35 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        } else {
                                            var35 = new double[3] {0.020573292354011164, 0.0, 0.9794267076459888};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.2199999988079071) {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.3200000077486038) {
                                            var35 = new double[3] {0.03107423511109339, 0.0, 0.9689257648889066};
                                        } else {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[14] <= -0.1666666716337204) {
                                        if (input[7] <= 2.5) {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var35 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var35 = new double[3] {0.26808690149757436, 0.0, 0.7319130985024257};
                                        } else {
                                            var35 = new double[3] {0.5982866404260245, 0.4017133595739754, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.9600000083446503) {
                                        if (input[10] <= 3.5) {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var35 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        }
                                    } else {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[4] <= 0.03333333507180214) {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.6800000071525574) {
                                        var35 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    var35 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.23333334177732468) {
                                        if (input[10] <= 3.5) {
                                            var35 = new double[3] {0.07973833097595474, 0.0, 0.9202616690240453};
                                        } else {
                                            var35 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var35 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var36;
            if (input[12] <= 3.5) {
                if (input[12] <= 2.5) {
                    if (input[0] <= 0.5) {
                        var36 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[2] <= 0.10000000521540642) {
                            var36 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[10] <= 2.5) {
                                if (input[3] <= 0.5300000011920929) {
                                    if (input[1] <= 0.17000000178813934) {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.009999999776482582) {
                                            var36 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.1666666716337204) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 4.5) {
                                        if (input[1] <= 0.22999999672174454) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.32093933463796476, 0.0, 0.6790606653620352};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= 2.5) {
                        if (input[6] <= 0.5) {
                            if (input[0] <= 0.5) {
                                var36 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.10000000521540642) {
                                    if (input[9] <= 0.5) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var36 = new double[3] {0.26898120839302275, 0.7310187916069774, 0.0};
                                        } else {
                                            var36 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.6700000166893005) {
                                            var36 = new double[3] {0.7617739942331453, 0.2382260057668546, 0.0};
                                        } else {
                                            var36 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.9199999868869781) {
                                        if (input[9] <= 0.5) {
                                            var36 = new double[3] {0.08723516189200822, 0.9127648381079918, 0.0};
                                        } else {
                                            var36 = new double[3] {0.49075432932198393, 0.5092456706780162, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 3.5) {
                                            var36 = new double[3] {0.3663720692425681, 0.6336279307574318, 0.0};
                                        } else {
                                            var36 = new double[3] {0.5018662072925639, 0.4981337927074362, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.3999999910593033) {
                                var36 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[0] <= 0.5) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[13] <= -0.22999999672174454) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.42682523951106704, 0.5731747604889329, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.4399999976158142) {
                                            var36 = new double[3] {0.4907543293219841, 0.5092456706780158, 0.0};
                                        } else {
                                            var36 = new double[3] {0.166838169719421, 0.8331618302805791, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[5] <= 3.5) {
                                var36 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 0.5) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.029999999329447746) {
                                        if (input[0] <= 0.5) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.08789822311008307, 0.912101776889917, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var36 = new double[3] {0.2827614716825134, 0.7172385283174866, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                if (input[3] <= 0.3700000047683716) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[1] <= 0.39000000059604645) {
                                            var36 = new double[3] {0.12740989103101424, 0.8725901089689858, 0.0};
                                        } else {
                                            var36 = new double[3] {0.44762814390321554, 0.5523718560967845, 0.0};
                                        }
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.23999999463558197) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[13] <= -0.17000000178813934) {
                    if (input[3] <= 0.75) {
                        if (input[3] <= 0.4299999922513962) {
                            var36 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[3] <= 0.6100000143051147) {
                                if (input[13] <= -0.35999999940395355) {
                                    if (input[12] <= 5.0) {
                                        var36 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[10] <= 1.5) {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.10459315327713745, 0.8954068467228625, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.7199999988079071) {
                                    if (input[3] <= 0.6400000154972076) {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var36 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var36 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[9] <= 0.5) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[7] <= 2.5) {
                                if (input[2] <= 0.10000000521540642) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[4] <= 0.1666666716337204) {
                                            var36 = new double[3] {0.6683234563181036, 0.3316765436818964, 0.0};
                                        } else {
                                            var36 = new double[3] {0.26170212765957446, 0.0, 0.7382978723404255};
                                        }
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[11] <= 1.5) {
                                    if (input[7] <= 6.5) {
                                        if (input[3] <= 0.20999999716877937) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.6400000154972076) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.04999999888241291) {
                                            var36 = new double[3] {0.31844965300510675, 0.6815503469948934, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[7] <= 3.5) {
                                if (input[3] <= 0.6700000166893005) {
                                    if (input[5] <= 0.5) {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 4.5) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.7899999916553497) {
                                        if (input[5] <= 0.5) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        if (input[3] <= 0.9699999988079071) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 0.5) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.06999999843537807) {
                                        if (input[11] <= 3.5) {
                                            var36 = new double[3] {0.04767505684936878, 0.9523249431506312, 0.0};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[10] <= 5.5) {
                                if (input[14] <= 0.03333333507180214) {
                                    if (input[13] <= 0.29999999701976776) {
                                        if (input[7] <= 6.5) {
                                            var36 = new double[3] {0.05396258343517911, 0.0, 0.9460374165648209};
                                        } else {
                                            var36 = new double[3] {0.006706469289277829, 0.0, 0.9932935307107222};
                                        }
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.9900000095367432) {
                                        if (input[10] <= 3.5) {
                                            var36 = new double[3] {0.15055079559363527, 0.0, 0.8494492044063647};
                                        } else {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var36 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var36 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.3999999910593033) {
                                if (input[3] <= 0.3700000047683716) {
                                    var36 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.04999999888241291) {
                                        var36 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        if (input[5] <= 4.5) {
                                            var36 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var36 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var36 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var37;
            if (input[9] <= 0.5) {
                if (input[12] <= 2.5) {
                    if (input[2] <= 0.10000000521540642) {
                        var37 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[13] <= -0.14999999850988388) {
                            if (input[1] <= 0.17000000178813934) {
                                var37 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    if (input[13] <= -0.20000000298023224) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[14] <= 0.10000000521540642) {
                                var37 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[11] <= 1.5) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.4299999922513962) {
                                        if (input[11] <= 1.5) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.009999999776482582) {
                        if (input[5] <= 4.5) {
                            if (input[2] <= 0.1666666716337204) {
                                if (input[0] <= 0.5) {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[1] <= 0.4599999934434891) {
                                        if (input[10] <= 4.5) {
                                            var37 = new double[3] {0.23786514386119043, 0.7621348561388096, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var37 = new double[3] {0.11185052469925773, 0.8881494753007422, 0.0};
                                        } else {
                                            var37 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.04999999888241291) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var37 = new double[3] {0.030873914588940236, 0.9691260854110597, 0.0};
                                        } else {
                                            var37 = new double[3] {0.13371692146746236, 0.8662830785325377, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.19414770088248953, 0.8058522991175104, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= -0.17999999970197678) {
                                if (input[12] <= 3.5) {
                                    if (input[4] <= 0.06666667014360428) {
                                        var37 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    } else {
                                        if (input[13] <= -0.22999999672174454) {
                                            var37 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var37 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[5] <= 0.5) {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 0.5300000011920929) {
                                    if (input[6] <= 0.5) {
                                        if (input[5] <= 0.5) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.13315013739695228, 0.0, 0.8668498626030477};
                                        }
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[12] <= 3.5) {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[11] <= 4.5) {
                                        if (input[1] <= 0.45000000298023224) {
                                            var37 = new double[3] {0.17543621427116574, 0.8245637857288344, 0.0};
                                        } else {
                                            var37 = new double[3] {0.08918259580644167, 0.9108174041935584, 0.0};
                                        }
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[7] <= 4.5) {
                                    if (input[3] <= 0.8499999940395355) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.41206370721789226, 0.5879362927821078, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.20000001043081284) {
                                            var37 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 0.5) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.12999999895691872) {
                                            var37 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.1666666716337204) {
                    if (input[12] <= 3.5) {
                        if (input[11] <= 2.5) {
                            if (input[1] <= 0.13999999687075615) {
                                if (input[1] <= 0.0800000000745058) {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.029999999329447746) {
                                        if (input[4] <= 0.10000000521540642) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[9] <= 2.5) {
                                    if (input[13] <= 0.06999999843537807) {
                                        if (input[9] <= 1.5) {
                                            var37 = new double[3] {0.43158239598121656, 0.5684176040187835, 0.0};
                                        } else {
                                            var37 = new double[3] {0.16748120634807798, 0.832518793651922, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var37 = new double[3] {0.5836333093352531, 0.4163666906647468, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= 0.8400000035762787) {
                                if (input[6] <= 0.5) {
                                    if (input[11] <= 3.5) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 6.5) {
                                            var37 = new double[3] {0.8029080995115301, 0.19709190048846986, 0.0};
                                        } else {
                                            var37 = new double[3] {0.3251653053286659, 0.6748346946713342, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.4699999988079071) {
                                        if (input[5] <= 1.5) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.5) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 3.5) {
                                    if (input[9] <= 1.5) {
                                        if (input[14] <= 0.10000000521540642) {
                                            var37 = new double[3] {0.3519832673489206, 0.6480167326510794, 0.0};
                                        } else {
                                            var37 = new double[3] {0.036187604158400125, 0.9638123958416, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.7002591419522027, 0.29974085804779727, 0.0};
                                        }
                                    }
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 3.5) {
                            if (input[5] <= 6.5) {
                                if (input[3] <= 0.6100000143051147) {
                                    if (input[13] <= -0.06999999843537807) {
                                        if (input[7] <= 6.5) {
                                            var37 = new double[3] {0.12740989103101424, 0.8725901089689857, 0.0};
                                        } else {
                                            var37 = new double[3] {0.06928620863131388, 0.19771640127521314, 0.7329973900934731};
                                        }
                                    } else {
                                        if (input[13] <= 0.4399999976158142) {
                                            var37 = new double[3] {0.08469151875321908, 0.019334182241688834, 0.895974299005092};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[13] <= 0.2900000065565109) {
                                            var37 = new double[3] {0.03488105755701713, 0.0, 0.9651189424429829};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.2499999925494194) {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[3] <= 0.3999999910593033) {
                                    var37 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        if (input[1] <= 0.7800000011920929) {
                                            var37 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        } else {
                                            var37 = new double[3] {0.11192629244156288, 0.0, 0.8880737075584372};
                                        }
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[11] <= 3.5) {
                                    if (input[6] <= 0.5) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= -0.06999999843537807) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.05999999865889549) {
                                            var37 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[10] <= 4.5) {
                        if (input[4] <= 0.23333334177732468) {
                            if (input[12] <= 3.5) {
                                if (input[13] <= -0.009999999776482582) {
                                    if (input[13] <= -0.26999999582767487) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.12999999895691872) {
                                        var37 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[10] <= 2.5) {
                                    if (input[7] <= 0.5) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var37 = new double[3] {0.08636124275934702, 0.0, 0.9136387572406529};
                                        } else {
                                            var37 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.009999999776482582) {
                                        var37 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[5] <= 3.0) {
                                            var37 = new double[3] {0.02919782288010581, 0.0, 0.9708021771198942};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.9699999988079071) {
                                if (input[9] <= 1.5) {
                                    if (input[13] <= -0.1600000001490116) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= -0.23333334177732468) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.4599999878555536) {
                                            var37 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var37 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 3.5) {
                                    if (input[0] <= 0.5) {
                                        var37 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var37 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var37 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var37 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            var37 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var37 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var38;
            if (input[14] <= -0.03333333507180214) {
                if (input[1] <= 0.7800000011920929) {
                    if (input[3] <= 0.9500000178813934) {
                        if (input[13] <= -0.06999999843537807) {
                            if (input[12] <= 3.5) {
                                if (input[1] <= 0.2199999988079071) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 2.5) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.7299999892711639) {
                                            var38 = new double[3] {0.17698046487558752, 0.8230195351244124, 0.0};
                                        } else {
                                            var38 = new double[3] {0.3150414528227398, 0.6849585471772601, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= -0.10000000521540642) {
                                    if (input[0] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.6599999964237213) {
                                        if (input[3] <= 0.21000000089406967) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[7] <= 0.5) {
                                    if (input[9] <= 0.5) {
                                        if (input[13] <= 0.0800000000745058) {
                                            var38 = new double[3] {0.421987784564131, 0.578012215435869, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.05928067955900958, 0.0, 0.9407193204409904};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.09999999776482582) {
                                        if (input[12] <= 3.5) {
                                            var38 = new double[3] {0.7340180898359651, 0.265981910164035, 0.0};
                                        } else {
                                            var38 = new double[3] {0.0878760918796506, 0.0, 0.9121239081203494};
                                        }
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var38 = new double[3] {0.22720334268019932, 0.5637840382582177, 0.20901261906158314};
                                        } else {
                                            var38 = new double[3] {0.1760368061550738, 0.1255854682068475, 0.6983777256380787};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 5.5) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.03999999910593033) {
                                            var38 = new double[3] {0.18937860146394642, 0.8106213985360535, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[12] <= 3.5) {
                                if (input[12] <= 2.5) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var38 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[8] <= 0.5) {
                            if (input[3] <= 0.8100000023841858) {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 3.0) {
                                    if (input[3] <= 0.8299999833106995) {
                                        if (input[9] <= 1.0) {
                                            var38 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.13143403267646658, 0.8685659673235333, 0.0};
                                        }
                                    }
                                } else {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var38 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[13] <= 0.1600000038743019) {
                            if (input[12] <= 5.0) {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[11] <= 3.5) {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[9] <= 0.5) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var38 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                } else {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[13] <= 0.06999999843537807) {
                    if (input[12] <= 3.5) {
                        if (input[3] <= 0.6700000166893005) {
                            if (input[12] <= 2.5) {
                                if (input[10] <= 2.5) {
                                    if (input[6] <= 0.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.4731248102034619, 0.0, 0.5268751897965381};
                                        }
                                    } else {
                                        var38 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[10] <= 3.5) {
                                            var38 = new double[3] {0.24136423261915133, 0.7586357673808486, 0.0};
                                        } else {
                                            var38 = new double[3] {0.33783086006779944, 0.6621691399322005, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var38 = new double[3] {0.09512882027745906, 0.9048711797225409, 0.0};
                                        } else {
                                            var38 = new double[3] {0.7863037319866979, 0.21369626801330213, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[11] <= 2.5) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        if (input[7] <= 0.5) {
                                            var38 = new double[3] {0.16817259819288213, 0.8318274018071178, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 4.5) {
                                    if (input[5] <= 3.0) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var38 = new double[3] {0.5873959571938167, 0.4126040428061834, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.699999988079071) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.8199999928474426) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.6700000166893005) {
                            if (input[10] <= 2.5) {
                                if (input[0] <= 0.5) {
                                    if (input[7] <= 5.5) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.03999999910593033) {
                                        if (input[13] <= -0.3699999898672104) {
                                            var38 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.0) {
                                            var38 = new double[3] {0.7486600028972911, 0.251339997102709, 0.0};
                                        } else {
                                            var38 = new double[3] {0.3805783648696894, 0.0, 0.6194216351303106};
                                        }
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[3] <= 0.3400000035762787) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.1829312961121867, 0.8170687038878134, 0.0};
                                        }
                                    } else {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[10] <= 3.5) {
                                if (input[1] <= 0.8499999940395355) {
                                    if (input[13] <= -0.17000000178813934) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.03643230034432967, 0.0, 0.9635676996556704};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.10000000521540642) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.9699999988079071) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.23489060173755727, 0.26811525922017226, 0.4969941390422705};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.9600000083446503) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.03333333507180214) {
                                            var38 = new double[3] {0.04380834551793948, 0.40003936565065795, 0.5561522888314026};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.7699999809265137) {
                        if (input[12] <= 3.5) {
                            if (input[0] <= 0.5) {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 1.5) {
                                    var38 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 4.5) {
                                        if (input[7] <= 3.5) {
                                            var38 = new double[3] {0.5508672016567435, 0.4491327983432566, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var38 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 4.5) {
                                if (input[2] <= 0.1666666716337204) {
                                    if (input[13] <= 0.08999999985098839) {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.03545617394527149, 0.0, 0.9645438260547285};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[1] <= 0.3799999952316284) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.052257829570284055, 0.0, 0.947742170429716};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                }
                            } else {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var38 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[3] <= 0.9099999964237213) {
                                if (input[10] <= 3.5) {
                                    if (input[12] <= 3.5) {
                                        if (input[2] <= 0.20000001043081284) {
                                            var38 = new double[3] {0.13621427860201135, 0.8637857213979887, 0.0};
                                        } else {
                                            var38 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        }
                                    } else {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[12] <= 4.5) {
                                            var38 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var38 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    } else {
                                        var38 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var38 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var39;
            if (input[0] <= 0.5) {
                if (input[10] <= 4.5) {
                    if (input[12] <= 3.5) {
                        var39 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        if (input[3] <= 0.03999999910593033) {
                            var39 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[3] <= 0.32999999821186066) {
                                if (input[9] <= 0.5) {
                                    var39 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.1666666716337204) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.35999999940395355) {
                                            var39 = new double[3] {0.049566482177600645, 0.0, 0.9504335178223994};
                                        } else {
                                            var39 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[9] <= 0.5) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 1.5) {
                                            var39 = new double[3] {0.04512933406714364, 0.0, 0.9548706659328563};
                                        } else {
                                            var39 = new double[3] {0.1056701030927835, 0.0, 0.8943298969072165};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.3500000089406967) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var39 = new double[3] {1.0, 0.0, 0.0};
                }
            } else {
                if (input[9] <= 2.5) {
                    if (input[5] <= 2.5) {
                        if (input[11] <= 3.5) {
                            if (input[10] <= 5.5) {
                                if (input[13] <= 0.06999999843537807) {
                                    if (input[12] <= 2.5) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var39 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var39 = new double[3] {0.5695857107417515, 0.0, 0.4304142892582486};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var39 = new double[3] {0.1841061043291199, 0.7450681548702099, 0.07082574080067035};
                                        } else {
                                            var39 = new double[3] {0.34339843346827337, 0.6566015665317267, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[12] <= 4.5) {
                                            var39 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var39 = new double[3] {0.19114219114219116, 0.0, 0.8088578088578089};
                                        }
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var39 = new double[3] {0.5054631828978622, 0.49453681710213776, 0.0};
                                        } else {
                                            var39 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var39 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[10] <= 2.5) {
                                if (input[11] <= 5.0) {
                                    if (input[9] <= 0.5) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.5200000107288361) {
                                            var39 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var39 = new double[3] {0.2827614716825134, 0.7172385283174866, 0.0};
                                        }
                                    }
                                } else {
                                    var39 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= 0.12999999895691872) {
                                    if (input[9] <= 1.5) {
                                        if (input[10] <= 4.5) {
                                            var39 = new double[3] {0.16796980880298562, 0.8320301911970144, 0.0};
                                        } else {
                                            var39 = new double[3] {0.5508672016567434, 0.44913279834325653, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var39 = new double[3] {0.1697240389216781, 0.8302759610783219, 0.0};
                                        } else {
                                            var39 = new double[3] {0.6776890209920119, 0.32231097900798816, 0.0};
                                        }
                                    }
                                } else {
                                    var39 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[14] <= 0.10000000521540642) {
                            if (input[10] <= 4.5) {
                                if (input[12] <= 3.5) {
                                    if (input[13] <= -0.22999999672174454) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= -0.03333333507180214) {
                                            var39 = new double[3] {0.46194876883954594, 0.538051231160454, 0.0};
                                        } else {
                                            var39 = new double[3] {0.2838329238329238, 0.7161670761670762, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.03333333507180214) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var39 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var39 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.17000000178813934) {
                                    var39 = new double[3] {0.0, 0.0, 1.0};
                                } else {
                                    if (input[2] <= 0.03333333507180214) {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var39 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var39 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[8] <= 0.5) {
                        var39 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        var39 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            double[] var40;
            if (input[9] <= 0.5) {
                if (input[3] <= 0.4699999988079071) {
                    if (input[5] <= 0.5) {
                        if (input[13] <= -0.14999999850988388) {
                            var40 = new double[3] {0.0, 0.0, 1.0};
                        } else {
                            if (input[1] <= 0.10999999940395355) {
                                if (input[12] <= 3.5) {
                                    if (input[3] <= 0.12999999895691872) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 0.5) {
                                            var40 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var40 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    }
                                } else {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[1] <= 0.3099999949336052) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[5] <= 6.5) {
                                if (input[5] <= 1.5) {
                                    if (input[1] <= 0.4999999850988388) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[13] <= 0.07000000029802322) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[7] <= 0.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[12] <= 2.5) {
                                if (input[6] <= 0.5) {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[3] <= 0.23999999463558197) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 3.0) {
                                            var40 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= 0.2800000011920929) {
                                    if (input[13] <= 0.12999999895691872) {
                                        if (input[7] <= 0.5) {
                                            var40 = new double[3] {0.44984673924532287, 0.5501532607546771, 0.0};
                                        } else {
                                            var40 = new double[3] {0.2108614572910034, 0.7891385427089966, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.08999999798834324) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.3100000023841858) {
                                            var40 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[12] <= 2.5) {
                        if (input[13] <= -0.17000000178813934) {
                            if (input[3] <= 0.8799999952316284) {
                                var40 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.13333333656191826) {
                                    if (input[2] <= 0.13333333656191826) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.0) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.9699999988079071) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var40 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[10] <= 3.5) {
                                if (input[14] <= 0.10000000521540642) {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.7199999988079071) {
                                        if (input[5] <= 0.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var40 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[10] <= 5.5) {
                                if (input[1] <= 0.8100000023841858) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[12] <= 5.0) {
                                            var40 = new double[3] {0.13293353323338333, 0.8670664667666168, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.30000001192092896) {
                                            var40 = new double[3] {0.11424357592603096, 0.8857564240739692, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.7999999821186066) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 3.0) {
                                            var40 = new double[3] {0.18641561158604772, 0.8135843884139522, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[14] <= 0.03333333507180214) {
                    if (input[0] <= 0.5) {
                        if (input[12] <= 3.5) {
                            var40 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[2] <= 0.1666666716337204) {
                                    if (input[13] <= -0.2199999988079071) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.04999999888241291) {
                                            var40 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var40 = new double[3] {0.07111958197704303, 0.0, 0.928880418022957};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 6.5) {
                                        if (input[5] <= 0.5) {
                                            var40 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var40 = new double[3] {0.011677584733694105, 0.0, 0.9883224152663059};
                                        }
                                    } else {
                                        var40 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                }
                            } else {
                                if (input[10] <= 3.5) {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 0.5) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.010000001639127731) {
                                            var40 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var40 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 2.5) {
                            if (input[1] <= 0.3999999910593033) {
                                if (input[13] <= -0.04999999888241291) {
                                    if (input[5] <= 6.5) {
                                        if (input[7] <= 6.5) {
                                            var40 = new double[3] {0.08055113937466878, 0.9194488606253312, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.3200000077486038) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.25999999791383743) {
                                            var40 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        } else {
                                            var40 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.10000000521540642) {
                                    if (input[13] <= -0.06000000052154064) {
                                        if (input[1] <= 0.5799999833106995) {
                                            var40 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[11] <= 2.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.243129271484659, 0.7568707285153411, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.03333333507180214) {
                                var40 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var40 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 3.5) {
                        if (input[2] <= 0.23333334177732468) {
                            if (input[10] <= 3.5) {
                                if (input[13] <= -0.019999999552965164) {
                                    if (input[7] <= 1.5) {
                                        if (input[11] <= 2.5) {
                                            var40 = new double[3] {0.34454098979977327, 0.6554590102002267, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var40 = new double[3] {0.2748620670101252, 0.4482008329535407, 0.2769371000363341};
                                        } else {
                                            var40 = new double[3] {0.23037113706934792, 0.0, 0.769628862930652};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[1] <= 0.570000022649765) {
                                            var40 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var40 = new double[3] {0.31060907078390193, 0.6893909292160981, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[8] <= 0.5) {
                                    if (input[13] <= 0.06999999843537807) {
                                        if (input[7] <= 0.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.3965217391304348, 0.6034782608695652, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.28999999910593033) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.3499999940395355) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.9399999976158142) {
                                if (input[0] <= 0.5) {
                                    if (input[11] <= 2.5) {
                                        var40 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        if (input[5] <= 1.5) {
                                            var40 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 1.5) {
                                            var40 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.949999988079071) {
                                    if (input[5] <= 0.5) {
                                        if (input[0] <= 0.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {0.5324710320668283, 0.4675289679331717, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        if (input[0] <= 0.5) {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var40 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var40 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            if (input[1] <= 0.2800000011920929) {
                                var40 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 0.5) {
                                    var40 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[3] <= 0.510000005364418) {
                                            var40 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var40 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        }
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[3] <= 0.32999999821186066) {
                                    if (input[10] <= 2.5) {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 2.5) {
                                        var40 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                    } else {
                                        var40 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var40 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var41;
            if (input[9] <= 0.5) {
                if (input[0] <= 0.5) {
                    if (input[13] <= 0.029999999329447746) {
                        if (input[14] <= -0.23333334177732468) {
                            var41 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var41 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[14] <= -0.10000000521540642) {
                            var41 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[4] <= 0.1666666716337204) {
                                if (input[5] <= 2.0) {
                                    if (input[1] <= 0.75) {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.10999999940395355) {
                                            var41 = new double[3] {0.3420553659461509, 0.0, 0.6579446340538491};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[5] <= 0.5) {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    }
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.06999999843537807) {
                        if (input[1] <= 0.3700000047683716) {
                            if (input[10] <= 4.5) {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[13] <= -0.03999999910593033) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        }
                                    } else {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.1900000050663948) {
                                        if (input[1] <= 0.17000000178813934) {
                                            var41 = new double[3] {0.3867957870926698, 0.6132042129073302, 0.0};
                                        } else {
                                            var41 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    } else {
                                        if (input[3] <= 0.5499999970197678) {
                                            var41 = new double[3] {0.26347813782368756, 0.7365218621763125, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var41 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 0.30000001192092896) {
                                if (input[4] <= 0.03333333507180214) {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[12] <= 2.5) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.35685160014827627, 0.6431483998517238, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 5.0) {
                                            var41 = new double[3] {0.243129271484659, 0.756870728515341, 0.0};
                                        } else {
                                            var41 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 2.5) {
                                        if (input[3] <= 0.8799999952316284) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.29842296805499396, 0.0, 0.7015770319450061};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var41 = new double[3] {0.5982866404260245, 0.4017133595739754, 0.0};
                                        } else {
                                            var41 = new double[3] {0.09139399111662817, 0.9086060088833718, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 3.5) {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[7] <= 5.5) {
                            if (input[2] <= 0.1666666716337204) {
                                if (input[12] <= 3.5) {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[10] <= 2.5) {
                                            var41 = new double[3] {0.16159273219290615, 0.8384072678070938, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= 0.10999999940395355) {
                                            var41 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.9600000083446503) {
                                        if (input[1] <= 0.21000000089406967) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var41 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var41 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[14] <= 0.10000000521540642) {
                    if (input[12] <= 3.5) {
                        if (input[9] <= 2.5) {
                            if (input[5] <= 1.5) {
                                if (input[3] <= 0.8100000023841858) {
                                    if (input[11] <= 3.5) {
                                        if (input[1] <= 0.2199999988079071) {
                                            var41 = new double[3] {0.43158239598121656, 0.5684176040187835, 0.0};
                                        } else {
                                            var41 = new double[3] {0.784284470968544, 0.2157155290314559, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.29385429385429385, 0.7061457061457062, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[11] <= 2.5) {
                                            var41 = new double[3] {0.055182428752949715, 0.9448175712470502, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var41 = new double[3] {0.2171755151150549, 0.782824484884945, 0.0};
                                        } else {
                                            var41 = new double[3] {0.5324710320668283, 0.4675289679331717, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.3700000047683716) {
                                    if (input[3] <= 0.029999999329447746) {
                                        var41 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        if (input[5] <= 3.5) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.5083035764892592, 0.4916964235107407, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 4.5) {
                                        if (input[1] <= 0.75) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.5595328763645595, 0.44046712363544044, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.44999998807907104) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                var41 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var41 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            if (input[10] <= 5.5) {
                                if (input[13] <= -0.04999999888241291) {
                                    if (input[5] <= 3.5) {
                                        if (input[1] <= 0.9099999964237213) {
                                            var41 = new double[3] {0.1313707820166216, 0.0, 0.8686292179833783};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= 0.26999999582767487) {
                                        if (input[13] <= 0.08999999985098839) {
                                            var41 = new double[3] {0.07259546320114925, 0.0, 0.9274045367988508};
                                        } else {
                                            var41 = new double[3] {0.035805017465862184, 0.0, 0.9641949825341377};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                }
                            } else {
                                var41 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.10000000521540642) {
                                if (input[13] <= -0.029999999329447746) {
                                    if (input[1] <= 0.4299999922513962) {
                                        if (input[3] <= 0.6800000071525574) {
                                            var41 = new double[3] {0.11993462210449192, 0.880065377895508, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[5] <= 2.0) {
                                    if (input[14] <= -0.1666666716337204) {
                                        if (input[13] <= -0.06999999843537807) {
                                            var41 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.06666667014360428) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.06999999843537807) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[13] <= -0.14999999850988388) {
                                if (input[5] <= 4.5) {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var41 = new double[3] {0.0, 0.0, 1.0};
                                }
                            } else {
                                if (input[9] <= 1.5) {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[13] <= 0.009999999776482582) {
                                if (input[10] <= 2.5) {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 4.5) {
                                        if (input[3] <= 0.9900000095367432) {
                                            var41 = new double[3] {0.4489614431810964, 0.5510385568189037, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[13] <= 0.03999999910593033) {
                                        var41 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        if (input[9] <= 2.0) {
                                            var41 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.5999999940395355) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 3.5) {
                                            var41 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.9900000095367432) {
                            if (input[4] <= 0.03333333507180214) {
                                var41 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 4.5) {
                                    if (input[0] <= 0.5) {
                                        if (input[10] <= 3.5) {
                                            var41 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        } else {
                                            var41 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var41 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                if (input[11] <= 3.5) {
                                    var41 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var41 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                }
                            } else {
                                var41 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var42;
            if (input[14] <= 0.03333333507180214) {
                if (input[3] <= 0.6899999976158142) {
                    if (input[7] <= 0.5) {
                        if (input[3] <= 0.4599999934434891) {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[10] <= 2.5) {
                                    if (input[9] <= 1.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.23999999463558197) {
                                        if (input[4] <= 0.1666666716337204) {
                                            var42 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 3.5) {
                                            var42 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[11] <= 3.5) {
                                if (input[9] <= 0.5) {
                                    if (input[13] <= 0.1100000012665987) {
                                        if (input[10] <= 1.5) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                } else {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[13] <= 0.04999999888241291) {
                                        var42 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[14] <= -0.1666666716337204) {
                                            var42 = new double[3] {0.19114219114219116, 0.0, 0.8088578088578089};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 3.5) {
                            if (input[1] <= 0.1900000050663948) {
                                if (input[1] <= 0.17000000178813934) {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 2.5) {
                                        var42 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 5.5) {
                                    if (input[0] <= 0.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 5.0) {
                                            var42 = new double[3] {0.35685160014827616, 0.6431483998517238, 0.0};
                                        } else {
                                            var42 = new double[3] {0.7863037319866979, 0.21369626801330213, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.09999999776482582) {
                                            var42 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var42 = new double[3] {0.2992730210016155, 0.7007269789983844, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[12] <= 5.0) {
                                    if (input[9] <= 0.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var42 = new double[3] {0.14441704825642834, 0.0, 0.8555829517435717};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[6] <= 0.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= -0.04999999888241291) {
                                    if (input[10] <= 2.5) {
                                        if (input[0] <= 0.5) {
                                            var42 = new double[3] {0.20131962559459876, 0.0, 0.7986803744054013};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.06999999843537807) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.17999999970197678) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[10] <= 1.5) {
                                            var42 = new double[3] {0.1541890103767672, 0.0, 0.8458109896232328};
                                        } else {
                                            var42 = new double[3] {0.08015507472083236, 0.0, 0.9198449252791675};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[12] <= 3.5) {
                        if (input[12] <= 2.5) {
                            var42 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[2] <= 0.03333333507180214) {
                                if (input[0] <= 0.5) {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= -0.25) {
                                        if (input[9] <= 0.5) {
                                            var42 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= -0.03333333507180214) {
                                            var42 = new double[3] {0.046412213740458015, 0.953587786259542, 0.0};
                                        } else {
                                            var42 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[3] <= 0.9099999964237213) {
                                            var42 = new double[3] {0.7276722649505571, 0.2723277350494428, 0.0};
                                        } else {
                                            var42 = new double[3] {0.3046092184368738, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 2.5) {
                                            var42 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 0.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[7] <= 4.5) {
                            if (input[6] <= 0.5) {
                                if (input[0] <= 0.5) {
                                    if (input[7] <= 0.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.9900000095367432) {
                                            var42 = new double[3] {0.23500881834215165, 0.0, 0.7649911816578483};
                                        } else {
                                            var42 = new double[3] {0.03789279112754159, 0.0, 0.9621072088724584};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 3.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[0] <= 0.5) {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.8599999845027924) {
                                if (input[12] <= 5.0) {
                                    if (input[11] <= 1.5) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.03385677692393362, 0.9661432230760664, 0.0};
                                        }
                                    }
                                } else {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    if (input[13] <= 0.21000000089406967) {
                        if (input[10] <= 3.5) {
                            if (input[7] <= 0.5) {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 1.5) {
                                    if (input[3] <= 0.6500000059604645) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.13609958506224068, 0.0, 0.8639004149377594};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 1.5) {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[14] <= 0.1666666716337204) {
                            var42 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 0.5) {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var42 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                            }
                        }
                    }
                } else {
                    if (input[13] <= 0.06999999843537807) {
                        if (input[5] <= 5.5) {
                            if (input[12] <= 2.5) {
                                var42 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[11] <= 2.5) {
                                        if (input[11] <= 1.5) {
                                            var42 = new double[3] {0.3273745423217746, 0.6726254576782253, 0.0};
                                        } else {
                                            var42 = new double[3] {0.1978183810812199, 0.80218161891878, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.4299999922513962) {
                                            var42 = new double[3] {0.5678704856787048, 0.43212951432129515, 0.0};
                                        } else {
                                            var42 = new double[3] {0.3058530041655875, 0.6941469958344125, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 1.5) {
                                        if (input[1] <= 0.19999999552965164) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {0.06620021528525295, 0.0, 0.933799784714747};
                                        }
                                    } else {
                                        if (input[1] <= 0.17999999597668648) {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var42 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 0.7699999809265137) {
                            var42 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[8] <= 0.5) {
                                if (input[7] <= 4.0) {
                                    if (input[14] <= 0.10000000521540642) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.1899999976158142) {
                                            var42 = new double[3] {0.3129801219608775, 0.6870198780391225, 0.0};
                                        } else {
                                            var42 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var42 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[14] <= 0.23333334177732468) {
                                    if (input[1] <= 0.8199999928474426) {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var42 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var42 = new double[3] {0.0, 0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var43;
            if (input[11] <= 0.5) {
                if (input[3] <= 0.13999999687075615) {
                    var43 = new double[3] {1.0, 0.0, 0.0};
                } else {
                    if (input[1] <= 0.5400000065565109) {
                        if (input[12] <= 2.5) {
                            var43 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[14] <= -0.03333333507180214) {
                                if (input[9] <= 2.5) {
                                    if (input[0] <= 0.5) {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.26000000536441803) {
                                            var43 = new double[3] {0.10459315327713745, 0.8954068467228625, 0.0};
                                        } else {
                                            var43 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    }
                                } else {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.23333334177732468) {
                                    if (input[1] <= 0.4000000059604645) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var43 = new double[3] {0.4120637072178922, 0.5879362927821078, 0.0};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var43 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 1.5) {
                                        if (input[13] <= -0.3699999898672104) {
                                            var43 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var43 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    } else {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.03333333507180214) {
                            if (input[9] <= 0.5) {
                                if (input[0] <= 0.5) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var43 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                }
                            } else {
                                var43 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var43 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[12] <= 3.5) {
                    if (input[12] <= 2.5) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[14] <= -0.23333334177732468) {
                                var43 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var43 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.1666666716337204) {
                                if (input[3] <= 0.4299999922513962) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.1666666716337204) {
                                        if (input[11] <= 3.5) {
                                            var43 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var43 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[13] <= 0.06999999843537807) {
                            if (input[9] <= 0.5) {
                                if (input[0] <= 0.5) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[1] <= 0.8799999952316284) {
                                            var43 = new double[3] {0.06702372502204726, 0.9329762749779527, 0.0};
                                        } else {
                                            var43 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var43 = new double[3] {0.24103237095363075, 0.7589676290463692, 0.0};
                                        } else {
                                            var43 = new double[3] {0.08055113937466878, 0.9194488606253312, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[7] <= 2.5) {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[8] <= 0.5) {
                                            var43 = new double[3] {0.3445409897997732, 0.6554590102002268, 0.0};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.10000000521540642) {
                                            var43 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var43 = new double[3] {0.6423417851989278, 0.35765821480107224, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[9] <= 2.5) {
                                        if (input[2] <= 0.23333334177732468) {
                                            var43 = new double[3] {0.2846344145134688, 0.7153655854865312, 0.0};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.28999999165534973) {
                                if (input[3] <= 0.45000000298023224) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[10] <= 3.5) {
                                        if (input[3] <= 0.8799999952316284) {
                                            var43 = new double[3] {0.8045951120621692, 0.19540488793783087, 0.0};
                                        } else {
                                            var43 = new double[3] {0.5125035122225344, 0.4874964877774656, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.8100000023841858) {
                                            var43 = new double[3] {0.14909269249632173, 0.8509073075036783, 0.0};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= 0.48000000417232513) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[9] <= 1.0) {
                                            var43 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[8] <= 0.5) {
                        if (input[12] <= 5.0) {
                            if (input[9] <= 0.5) {
                                if (input[0] <= 0.5) {
                                    if (input[13] <= 0.029999999329447746) {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 2.0) {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var43 = new double[3] {0.2350088183421517, 0.0, 0.7649911816578484};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.22999999672174454) {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.2199999988079071) {
                                            var43 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        } else {
                                            var43 = new double[3] {0.43533164095554255, 0.5646683590444576, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 6.5) {
                                    if (input[10] <= 5.5) {
                                        if (input[3] <= 0.4999999850988388) {
                                            var43 = new double[3] {0.07531527394238964, 0.03684360910433628, 0.887841116953274};
                                        } else {
                                            var43 = new double[3] {0.19252303685561103, 0.1433184220299565, 0.6641585411144324};
                                        }
                                    } else {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.10000000521540642) {
                                var43 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 1.5) {
                                    if (input[0] <= 0.5) {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 3.5) {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var43 = new double[3] {0.1796690307328605, 0.8203309692671394, 0.0};
                                        }
                                    }
                                } else {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 5.0) {
                            if (input[13] <= -0.1899999976158142) {
                                var43 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.4099999964237213) {
                                    if (input[10] <= 4.5) {
                                        if (input[5] <= 1.5) {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var43 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    } else {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.8100000023841858) {
                                        if (input[5] <= 2.5) {
                                            var43 = new double[3] {0.06913466697325057, 0.0, 0.9308653330267495};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var43 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= -0.09999999962747097) {
                                if (input[1] <= 0.3100000023841858) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.10000000149011612) {
                                        var43 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var43 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var43 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var44;
            if (input[12] <= 3.5) {
                if (input[13] <= -0.14999999850988388) {
                    if (input[13] <= -0.21000000089406967) {
                        if (input[0] <= 0.5) {
                            var44 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[13] <= -0.22999999672174454) {
                                    if (input[13] <= -0.3400000035762787) {
                                        if (input[13] <= -0.4399999976158142) {
                                            var44 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.2346713718570798, 0.7653286281429201, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[8] <= 0.5) {
                                        if (input[5] <= 1.0) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        }
                                    } else {
                                        var44 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= 0.03333333507180214) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[7] <= 3.5) {
                                            var44 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    } else {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.10000000521540642) {
                            if (input[1] <= 0.48999999463558197) {
                                var44 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 2.5) {
                                    if (input[11] <= 4.0) {
                                        if (input[9] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var44 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                    }
                                } else {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.1666666716337204) {
                                if (input[11] <= 3.5) {
                                    if (input[10] <= 4.0) {
                                        if (input[10] <= 2.5) {
                                            var44 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var44 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[10] <= 4.5) {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        var44 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[10] <= 5.5) {
                        if (input[9] <= 2.5) {
                            if (input[9] <= 0.5) {
                                if (input[6] <= 0.5) {
                                    if (input[7] <= 1.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var44 = new double[3] {0.5166323062350253, 0.48336769376497457, 0.0};
                                        } else {
                                            var44 = new double[3] {0.19453192637297817, 0.8054680736270218, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.25256938888546987, 0.7474306111145301, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[10] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.7300000190734863) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[14] <= -0.1666666716337204) {
                                    if (input[11] <= 0.5) {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.04993976563355602, 0.9500602343664439, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 4.5) {
                                        if (input[13] <= -0.029999999329447746) {
                                            var44 = new double[3] {0.33360768175582944, 0.6663923182441706, 0.0};
                                        } else {
                                            var44 = new double[3] {0.6768595181253276, 0.3231404818746722, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 5.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var44 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        var44 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            } else {
                if (input[7] <= 0.5) {
                    if (input[14] <= -0.03333333507180214) {
                        if (input[5] <= 3.5) {
                            if (input[0] <= 0.5) {
                                if (input[11] <= 1.5) {
                                    var44 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                } else {
                                    if (input[4] <= 0.23333334177732468) {
                                        if (input[9] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.05225782957028405, 0.0, 0.9477421704297159};
                                        }
                                    } else {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[1] <= 0.4400000050663948) {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                var44 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var44 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[12] <= 5.0) {
                            if (input[5] <= 0.5) {
                                var44 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 2.5) {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 0.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.017219893508553304, 0.9827801064914466, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.05999999865889549) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.12740989103101424, 0.8725901089689858, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var44 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= 0.5) {
                        if (input[12] <= 5.0) {
                            if (input[14] <= -0.23333334177732468) {
                                if (input[3] <= 0.2299999985843897) {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.10999999940395355) {
                                        if (input[9] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    } else {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[11] <= 5.5) {
                                    if (input[3] <= 0.8799999952316284) {
                                        if (input[9] <= 0.5) {
                                            var44 = new double[3] {0.32634439914579694, 0.0, 0.6736556008542031};
                                        } else {
                                            var44 = new double[3] {0.0689396107613051, 0.0, 0.9310603892386949};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.11502167814333078, 0.0, 0.8849783218566692};
                                        }
                                    }
                                } else {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var44 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[13] <= -0.06999999843537807) {
                            if (input[10] <= 1.5) {
                                var44 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 0.5) {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 1.5) {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.5600000023841858) {
                                            var44 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var44 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[13] <= 0.10999999940395355) {
                                if (input[11] <= 1.5) {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.1056701030927835, 0.0, 0.8943298969072165};
                                        }
                                    } else {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 0.1666666716337204) {
                                        var44 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.1666666716337204) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {0.3251653053286659, 0.6748346946713342, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 3.5) {
                                    var44 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 3.5) {
                                        if (input[6] <= 0.5) {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var44 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var44 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            }
            double[] var45;
            if (input[0] <= 0.5) {
                if (input[3] <= 0.6899999976158142) {
                    if (input[9] <= 0.5) {
                        if (input[13] <= 0.06999999843537807) {
                            if (input[13] <= -0.3699999898672104) {
                                var45 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var45 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[13] <= 0.14999999850988388) {
                                if (input[10] <= 2.5) {
                                    if (input[14] <= -0.1666666716337204) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.11502167814333078, 0.0, 0.8849783218566692};
                                        }
                                    }
                                }
                            } else {
                                var45 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 6.5) {
                            if (input[9] <= 1.5) {
                                if (input[3] <= 0.17999999970197678) {
                                    if (input[4] <= 0.03333333507180214) {
                                        var45 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                    } else {
                                        if (input[10] <= 0.5) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[10] <= 5.5) {
                                        if (input[8] <= 0.5) {
                                            var45 = new double[3] {0.06521794904687382, 0.0, 0.9347820509531263};
                                        } else {
                                            var45 = new double[3] {0.09611878093253452, 0.0, 0.9038812190674655};
                                        }
                                    } else {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= -0.23333334177732468) {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.13333333656191826) {
                                if (input[10] <= 1.5) {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var45 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                }
                            } else {
                                var45 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.10000000521540642) {
                        if (input[10] <= 1.5) {
                            if (input[12] <= 3.5) {
                                var45 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[7] <= 3.5) {
                                    if (input[9] <= 0.5) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var45 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                    }
                                } else {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            var45 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            var45 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 0.5) {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[2] <= 0.1666666716337204) {
                                        if (input[1] <= 0.9699999988079071) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.5208505937586302, 0.0, 0.47914940624136976};
                                        }
                                    } else {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var45 = new double[3] {0.10567010309278352, 0.0, 0.8943298969072165};
                                    }
                                }
                            } else {
                                if (input[5] <= 5.5) {
                                    if (input[12] <= 3.5) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.055782312925170066, 0.0, 0.94421768707483};
                                        }
                                    }
                                } else {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= 0.8799999952316284) {
                    if (input[2] <= 0.30000001192092896) {
                        if (input[12] <= 2.5) {
                            var45 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[7] <= 0.5) {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[11] <= 3.5) {
                                        if (input[3] <= 0.9900000095367432) {
                                            var45 = new double[3] {0.5743166985622454, 0.42568330143775457, 0.0};
                                        } else {
                                            var45 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var45 = new double[3] {0.19886101277512697, 0.801138987224873, 0.0};
                                        } else {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.03999999910593033) {
                                        if (input[13] <= -0.23999999463558197) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.38385352957424146, 0.6161464704257585, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[3] <= 0.08999999798834324) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.26248671625929826, 0.7375132837407018, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 2.5) {
                                            var45 = new double[3] {0.29334987561955217, 0.7066501243804477, 0.0};
                                        } else {
                                            var45 = new double[3] {0.46922713240815395, 0.530772867591846, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        if (input[14] <= 0.1666666716337204) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.1666666716337204) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var45 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[14] <= 0.03333333507180214) {
                        if (input[4] <= 0.03333333507180214) {
                            if (input[12] <= 3.5) {
                                var45 = new double[3] {0.0, 1.0, 0.0};
                            } else {
                                var45 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[7] <= 0.5) {
                                if (input[12] <= 2.5) {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 3.5) {
                                        if (input[9] <= 1.5) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    } else {
                                        if (input[10] <= 2.5) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.7299999892711639) {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.05999999865889549) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var45 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var45 = new double[3] {0.4791353947763434, 0.5208646052236565, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[10] <= 3.5) {
                            if (input[9] <= 1.5) {
                                if (input[14] <= 0.10000000521540642) {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.10000000521540642) {
                                            var45 = new double[3] {0.028374089975732684, 0.9716259100242673, 0.0};
                                        } else {
                                            var45 = new double[3] {0.13838768415825192, 0.861612315841748, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 2.5) {
                                    var45 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[5] <= 0.5) {
                                        var45 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.06666667014360428) {
                                            var45 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var45 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var45 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var46;
            if (input[12] <= 3.5) {
                if (input[11] <= 0.5) {
                    if (input[1] <= 0.5400000065565109) {
                        if (input[0] <= 0.5) {
                            var46 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 2.5) {
                                if (input[12] <= 2.5) {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[3] <= 0.30000000447034836) {
                                            var46 = new double[3] {0.1399334324764535, 0.8600665675235466, 0.0};
                                        } else {
                                            var46 = new double[3] {0.04196576477084484, 0.9580342352291552, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var46 = new double[3] {0.12740989103101424, 0.8725901089689857, 0.0};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        var46 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[1] <= 0.1900000050663948) {
                        if (input[14] <= 0.03333333507180214) {
                            if (input[10] <= 1.5) {
                                if (input[2] <= 0.13333333656191826) {
                                    if (input[9] <= 0.5) {
                                        if (input[10] <= 0.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.243129271484659, 0.7568707285153411, 0.0};
                                        }
                                    } else {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.27000000327825546) {
                                    if (input[10] <= 3.0) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[14] <= -0.03333333507180214) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var46 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[9] <= 1.5) {
                                if (input[3] <= 0.17999999970197678) {
                                    if (input[9] <= 0.5) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.13333333656191826) {
                                            var46 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[11] <= 2.5) {
                                        if (input[7] <= 4.0) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.02143260011280316, 0.9785673998871969, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.1666666716337204) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= 0.5) {
                            var46 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[1] <= 0.4299999922513962) {
                                if (input[7] <= 3.5) {
                                    if (input[13] <= -0.04999999888241291) {
                                        if (input[2] <= 0.1666666716337204) {
                                            var46 = new double[3] {0.2859662531600917, 0.7140337468399083, 0.0};
                                        } else {
                                            var46 = new double[3] {0.45160882483089954, 0.5483911751691004, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.3999999910593033) {
                                            var46 = new double[3] {0.4874878676625733, 0.5125121323374267, 0.0};
                                        } else {
                                            var46 = new double[3] {0.2209250112258644, 0.0, 0.7790749887741356};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.10000000521540642) {
                                        if (input[9] <= 0.5) {
                                            var46 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        } else {
                                            var46 = new double[3] {0.8614991618104894, 0.13850083818951067, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.19999999552965164) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.1161487519103413, 0.8838512480896586, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.6299999952316284) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[6] <= 0.5) {
                                            var46 = new double[3] {0.21845170424076016, 0.7815482957592398, 0.0};
                                        } else {
                                            var46 = new double[3] {0.14909269249632173, 0.8509073075036783, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.5600000023841858) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.3445409897997733, 0.6554590102002267, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[1] <= 0.5600000023841858) {
                                            var46 = new double[3] {0.3716044911264034, 0.6283955088735965, 0.0};
                                        } else {
                                            var46 = new double[3] {0.7103989317309297, 0.2896010682690703, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.9099999964237213) {
                                            var46 = new double[3] {0.4817629683714443, 0.5182370316285558, 0.0};
                                        } else {
                                            var46 = new double[3] {0.3345728626457001, 0.6654271373542999, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    if (input[11] <= 3.5) {
                        if (input[5] <= 3.5) {
                            if (input[9] <= 0.5) {
                                if (input[14] <= 0.10000000521540642) {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 2.0) {
                                        if (input[1] <= 0.139999995008111) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 3.5) {
                                    if (input[10] <= 1.5) {
                                        if (input[3] <= 0.4099999964237213) {
                                            var46 = new double[3] {0.03423323128305037, 0.0, 0.9657667687169496};
                                        } else {
                                            var46 = new double[3] {0.07840220970997556, 0.0, 0.9215977902900244};
                                        }
                                    } else {
                                        if (input[11] <= 1.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.09196261682242993, 0.0, 0.90803738317757};
                                        }
                                    }
                                } else {
                                    if (input[13] <= 0.06999999843537807) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[14] <= -0.10000000521540642) {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[9] <= 0.5) {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.2799999937415123) {
                                        if (input[6] <= 0.5) {
                                            var46 = new double[3] {0.16726661867050638, 0.0, 0.8327333813294937};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[10] <= 3.5) {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 5.0) {
                                    if (input[13] <= 0.10999999940395355) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.6899999976158142) {
                                if (input[7] <= 4.5) {
                                    if (input[1] <= 0.13000000081956387) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {0.03921667337897706, 0.0, 0.960783326621023};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.0) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= -0.09999999776482582) {
                                            var46 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.7800000011920929) {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[14] <= -0.10000000521540642) {
                                        var46 = new double[3] {0.0, 0.0, 1.0};
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var46 = new double[3] {0.07030329010824135, 0.0, 0.9296967098917587};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= 0.5) {
                        if (input[12] <= 5.0) {
                            if (input[9] <= 0.5) {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    if (input[2] <= 0.03333333507180214) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[8] <= 0.5) {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var46 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.21000000089406967) {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[11] <= 3.5) {
                                    if (input[8] <= 0.5) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var46 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.04000000096857548) {
                                            var46 = new double[3] {0.0, 0.0, 1.0};
                                        } else {
                                            var46 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    }
                                } else {
                                    var46 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[11] <= 4.5) {
                            if (input[8] <= 0.5) {
                                if (input[5] <= 2.5) {
                                    if (input[3] <= 0.2199999988079071) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var46 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        } else {
                                            var46 = new double[3] {0.1530388088845497, 0.8469611911154503, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.03333333507180214) {
                                        var46 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.3999999910593033) {
                                            var46 = new double[3] {0.5324710320668283, 0.4675289679331717, 0.0};
                                        } else {
                                            var46 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var46 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var46 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var47;
            if (input[13] <= 0.06999999843537807) {
                if (input[7] <= 6.5) {
                    if (input[4] <= 0.10000000521540642) {
                        if (input[14] <= 0.1666666716337204) {
                            if (input[7] <= 4.5) {
                                if (input[3] <= 0.9600000083446503) {
                                    if (input[7] <= 2.5) {
                                        if (input[0] <= 0.5) {
                                            var47 = new double[3] {0.6649932419385982, 0.0, 0.33500675806140184};
                                        } else {
                                            var47 = new double[3] {0.3111662531017366, 0.6888337468982635, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.20119705340699814, 0.7988029465930019, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.10000000521540642) {
                                        if (input[1] <= 0.699999988079071) {
                                            var47 = new double[3] {0.243129271484659, 0.7568707285153411, 0.0};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.8499999940395355) {
                                            var47 = new double[3] {0.11192629244156288, 0.0, 0.8880737075584372};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[10] <= 2.5) {
                                    if (input[5] <= 1.5) {
                                        if (input[10] <= 1.5) {
                                            var47 = new double[3] {0.30120346055323743, 0.31255263400709743, 0.3862439054396651};
                                        } else {
                                            var47 = new double[3] {0.3046092184368738, 0.6953907815631263, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var47 = new double[3] {0.15055079559363527, 0.0, 0.8494492044063648};
                                        } else {
                                            var47 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[12] <= 2.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.2135799111594597, 0.7864200888405403, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var47 = new double[3] {0.5595328763645595, 0.44046712363544044, 0.0};
                                        } else {
                                            var47 = new double[3] {0.04349009400057224, 0.4964165334933739, 0.46009337250605387};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.800000011920929) {
                                if (input[9] <= 0.5) {
                                    if (input[3] <= 0.17999999970197678) {
                                        if (input[7] <= 0.5) {
                                            var47 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[14] <= 0.23333334177732468) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 0.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.21000000089406967) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[9] <= 0.5) {
                            if (input[3] <= 0.2499999925494194) {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[7] <= 0.5) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 6.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                }
                            } else {
                                if (input[12] <= 2.5) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[3] <= 0.8599999845027924) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 1.5) {
                                        if (input[12] <= 3.5) {
                                            var47 = new double[3] {0.09870129870129872, 0.9012987012987014, 0.0};
                                        } else {
                                            var47 = new double[3] {0.728750846839335, 0.2712491531606651, 0.0};
                                        }
                                    } else {
                                        if (input[14] <= 0.10000000521540642) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[11] <= 2.5) {
                                if (input[7] <= 1.5) {
                                    if (input[14] <= -0.03333333507180214) {
                                        if (input[8] <= 0.5) {
                                            var47 = new double[3] {0.3251653053286659, 0.6748346946713341, 0.0};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= 0.4699999988079071) {
                                        if (input[11] <= 1.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var47 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                    }
                                }
                            } else {
                                if (input[7] <= 0.5) {
                                    if (input[6] <= 0.5) {
                                        if (input[10] <= 2.5) {
                                            var47 = new double[3] {0.398196323274367, 0.0, 0.6018036767256331};
                                        } else {
                                            var47 = new double[3] {0.4369233622328342, 0.5630766377671658, 0.0};
                                        }
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var47 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.5) {
                                        if (input[9] <= 1.5) {
                                            var47 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[3] <= 0.32999999821186066) {
                                            var47 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var47 = new double[3] {0.717564707797493, 0.28243529220250696, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[8] <= 0.5) {
                        if (input[1] <= 0.17999999970197678) {
                            if (input[5] <= 0.5) {
                                if (input[0] <= 0.5) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[3] <= 0.21000000089406967) {
                                        if (input[14] <= 0.03333333507180214) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var47 = new double[3] {0.0, 1.0, 0.0};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[13] <= 0.03999999910593033) {
                                if (input[12] <= 3.5) {
                                    if (input[1] <= 0.2199999988079071) {
                                        if (input[10] <= 2.0) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[12] <= 5.0) {
                                        if (input[2] <= 0.03333333507180214) {
                                            var47 = new double[3] {0.015509740873841498, 0.0, 0.9844902591261585};
                                        } else {
                                            var47 = new double[3] {0.07840220970997558, 0.0, 0.9215977902900244};
                                        }
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var47 = new double[3] {0.2209250112258644, 0.0, 0.7790749887741356};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[9] <= 1.5) {
                            if (input[10] <= 2.5) {
                                if (input[5] <= 1.5) {
                                    if (input[10] <= 1.5) {
                                        if (input[2] <= 0.23333334177732468) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.5125035122225344, 0.4874964877774657, 0.0};
                                        }
                                    } else {
                                        var47 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                    }
                                } else {
                                    var47 = new double[3] {0.0, 1.0, 0.0};
                                }
                            } else {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            var47 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[9] <= 0.5) {
                    if (input[12] <= 3.5) {
                        if (input[11] <= 1.5) {
                            if (input[3] <= 0.1099999975413084) {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[12] <= 2.5) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[0] <= 0.5) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.4100000113248825) {
                                            var47 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var47 = new double[3] {0.023335550892994217, 0.9766644491070059, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[5] <= 3.0) {
                                    if (input[11] <= 2.5) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[8] <= 0.5) {
                                            var47 = new double[3] {0.19698231972600205, 0.803017680273998, 0.0};
                                        } else {
                                            var47 = new double[3] {0.041965764770844835, 0.9580342352291552, 0.0};
                                        }
                                    }
                                } else {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= 0.1666666716337204) {
                            var47 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[5] <= 0.5) {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[10] <= 2.5) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 2.5) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[6] <= 0.5) {
                        if (input[12] <= 3.5) {
                            if (input[9] <= 1.5) {
                                if (input[2] <= 0.03333333507180214) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.14999999850988388) {
                                        if (input[3] <= 0.8799999952316284) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.440863680309378, 0.5591363196906219, 0.0};
                                        }
                                    } else {
                                        if (input[7] <= 5.0) {
                                            var47 = new double[3] {0.092731392713962, 0.907268607286038, 0.0};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.20000001043081284) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[9] <= 2.5) {
                                        var47 = new double[3] {0.0, 1.0, 0.0};
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.23333334177732468) {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[1] <= 0.9900000095367432) {
                                        if (input[0] <= 0.5) {
                                            var47 = new double[3] {0.10267577646514414, 0.0, 0.8973242235348557};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[7] <= 1.5) {
                                            var47 = new double[3] {0.015509740873841497, 0.0, 0.9844902591261585};
                                        } else {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[12] <= 3.5) {
                            if (input[13] <= 0.14999999850988388) {
                                if (input[10] <= 2.5) {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.1666666753590107) {
                                        if (input[9] <= 1.5) {
                                            var47 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var47 = new double[3] {0.06165494862087614, 0.9383450513791238, 0.0};
                                        }
                                    } else {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[5] <= 2.5) {
                                if (input[1] <= 0.44999998807907104) {
                                    if (input[5] <= 0.5) {
                                        var47 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var47 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                } else {
                                    var47 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var47 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var48;
            if (input[10] <= 3.5) {
                if (input[9] <= 0.5) {
                    if (input[0] <= 0.5) {
                        if (input[4] <= 0.10000000521540642) {
                            if (input[10] <= 2.5) {
                                var48 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= 0.10000000521540642) {
                                    if (input[5] <= 0.5) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[13] <= 0.06999999843537807) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.14999999850988388) {
                                            var48 = new double[3] {0.19114219114219116, 0.0, 0.8088578088578089};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[8] <= 0.5) {
                                var48 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var48 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[12] <= 5.0) {
                            if (input[2] <= 0.10000000521540642) {
                                if (input[1] <= 0.8799999952316284) {
                                    if (input[2] <= 0.03333333507180214) {
                                        if (input[5] <= 0.5) {
                                            var48 = new double[3] {0.04767505684936877, 0.9523249431506312, 0.0};
                                        } else {
                                            var48 = new double[3] {0.17543621427116574, 0.8245637857288343, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.14156407345964664, 0.8584359265403533, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[7] <= 3.0) {
                                        if (input[4] <= 0.03333333507180214) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.03333333507180214) {
                                            var48 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= 0.10999999940395355) {
                                    if (input[8] <= 0.5) {
                                        if (input[6] <= 0.5) {
                                            var48 = new double[3] {0.20267784296341543, 0.7040967971369223, 0.0932253598996622};
                                        } else {
                                            var48 = new double[3] {0.14445928916723913, 0.2998048644798564, 0.5557358463529045};
                                        }
                                    } else {
                                        if (input[13] <= -0.28999999165534973) {
                                            var48 = new double[3] {0.03385677692393362, 0.9661432230760664, 0.0};
                                        } else {
                                            var48 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    }
                                } else {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[14] <= 0.03333333507180214) {
                                if (input[2] <= 0.03333333507180214) {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        if (input[3] <= 0.6599999964237213) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.20812414422638065, 0.7918758557736194, 0.0};
                                        }
                                    } else {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= 0.009999999776482582) {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[7] <= 4.5) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[13] <= 0.1600000001490116) {
                                            var48 = new double[3] {0.011677584733694105, 0.0, 0.9883224152663059};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[10] <= 0.5) {
                        if (input[6] <= 0.5) {
                            if (input[12] <= 3.5) {
                                var48 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[14] <= -0.1666666753590107) {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[13] <= 0.12999999895691872) {
                                        if (input[11] <= 3.5) {
                                            var48 = new double[3] {0.049419241726934036, 0.0, 0.950580758273066};
                                        } else {
                                            var48 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    } else {
                                        var48 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var48 = new double[3] {1.0, 0.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 0.23333334177732468) {
                            if (input[12] <= 3.5) {
                                if (input[9] <= 2.5) {
                                    if (input[6] <= 0.5) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var48 = new double[3] {0.41395034622529936, 0.5860496537747006, 0.0};
                                        } else {
                                            var48 = new double[3] {0.665896398998652, 0.33410360100134806, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var48 = new double[3] {0.2827614716825134, 0.7172385283174866, 0.0};
                                        } else {
                                            var48 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.10000000521540642) {
                                    if (input[14] <= -0.23333334177732468) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[0] <= 0.5) {
                                            var48 = new double[3] {0.06861816344574967, 0.0, 0.9313818365542503};
                                        } else {
                                            var48 = new double[3] {0.3687083080654942, 0.6312916919345056, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[13] <= -0.20999999344348907) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[14] <= 0.1666666716337204) {
                                            var48 = new double[3] {0.07075696262794574, 0.0, 0.9292430373720542};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= 0.5) {
                                if (input[1] <= 0.9900000095367432) {
                                    if (input[9] <= 1.5) {
                                        if (input[11] <= 2.5) {
                                            var48 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var48 = new double[3] {0.15899175957343675, 0.0, 0.8410082404265633};
                                        }
                                    } else {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[14] <= 0.23333334177732468) {
                                    if (input[11] <= 3.5) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.8799999952316284) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.2594963721724285, 0.7405036278275715, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.5) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var48 = new double[3] {0.0, 1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= 0.5) {
                    if (input[14] <= 0.03333333507180214) {
                        if (input[5] <= 0.5) {
                            if (input[3] <= 0.949999988079071) {
                                var48 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[4] <= 0.1666666716337204) {
                                    if (input[9] <= 1.5) {
                                        if (input[9] <= 0.5) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.12417970721857646, 0.0, 0.8758202927814235};
                                        }
                                    } else {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    var48 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[11] <= 2.5) {
                                var48 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[1] <= 0.699999988079071) {
                                    if (input[1] <= 0.5499999821186066) {
                                        if (input[12] <= 3.5) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.0749485870972656, 0.0, 0.9250514129027343};
                                        }
                                    } else {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[9] <= 0.5) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.23333334177732468) {
                                            var48 = new double[3] {0.027575383925568884, 0.0, 0.9724246160744311};
                                        } else {
                                            var48 = new double[3] {0.08636124275934703, 0.0, 0.913638757240653};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var48 = new double[3] {1.0, 0.0, 0.0};
                    }
                } else {
                    if (input[9] <= 2.5) {
                        if (input[12] <= 2.5) {
                            var48 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[9] <= 0.5) {
                                if (input[13] <= -0.04999999888241291) {
                                    if (input[3] <= 0.949999988079071) {
                                        if (input[6] <= 0.5) {
                                            var48 = new double[3] {0.11614875191034131, 0.8838512480896588, 0.0};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.024419632098963768, 0.9755803679010362, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.8499999940395355) {
                                        if (input[12] <= 3.5) {
                                            var48 = new double[3] {0.29019500886403926, 0.7098049911359607, 0.0};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 3.5) {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var48 = new double[3] {0.04993976563355602, 0.9500602343664439, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[5] <= 2.5) {
                                    if (input[1] <= 0.570000022649765) {
                                        if (input[2] <= 0.10000000521540642) {
                                            var48 = new double[3] {0.3251653053286659, 0.6748346946713342, 0.0};
                                        } else {
                                            var48 = new double[3] {0.6441998769567299, 0.35580012304327024, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.03333333507180214) {
                                            var48 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var48 = new double[3] {0.3722690712755003, 0.6277309287244996, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        var48 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[11] <= 2.5) {
                                            var48 = new double[3] {0.17373083150776264, 0.8262691684922374, 0.0};
                                        } else {
                                            var48 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[14] <= -0.1666666716337204) {
                            var48 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            var48 = new double[3] {1.0, 0.0, 0.0};
                        }
                    }
                }
            }
            double[] var49;
            if (input[0] <= 0.5) {
                if (input[9] <= 0.5) {
                    if (input[4] <= 0.10000000521540642) {
                        if (input[2] <= 0.1666666716337204) {
                            if (input[13] <= -0.39000000059604645) {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.6700000166893005) {
                                if (input[4] <= 0.03333333507180214) {
                                    var49 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    var49 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.6899999976158142) {
                                    if (input[7] <= 0.5) {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.5) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.7299999892711639) {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 3.5) {
                            var49 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[6] <= 0.5) {
                                if (input[3] <= 0.4999999850988388) {
                                    if (input[14] <= -0.10000000521540642) {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.2199999988079071) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.030545725460979698, 0.0, 0.9694542745390203};
                                        }
                                    }
                                } else {
                                    var49 = new double[3] {1.0, 0.0, 0.0};
                                }
                            } else {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.10000000521540642) {
                        if (input[14] <= -0.10000000521540642) {
                            if (input[12] <= 3.5) {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[3] <= 0.8100000023841858) {
                                    if (input[5] <= 6.0) {
                                        if (input[7] <= 2.5) {
                                            var49 = new double[3] {0.05124599640653075, 0.0, 0.9487540035934693};
                                        } else {
                                            var49 = new double[3] {0.023085585585585586, 0.0, 0.9769144144144144};
                                        }
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[11] <= 3.5) {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[7] <= 0.5) {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            } else {
                                if (input[6] <= 0.5) {
                                    if (input[8] <= 0.5) {
                                        if (input[3] <= 0.0800000000745058) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.0899337179915121, 0.0, 0.9100662820084879};
                                        }
                                    } else {
                                        if (input[9] <= 1.5) {
                                            var49 = new double[3] {0.17538022813688212, 0.0, 0.8246197718631179};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                } else {
                                    var49 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[12] <= 3.5) {
                            var49 = new double[3] {1.0, 0.0, 0.0};
                        } else {
                            if (input[11] <= 5.5) {
                                if (input[11] <= 0.5) {
                                    var49 = new double[3] {1.0, 0.0, 0.0};
                                } else {
                                    if (input[11] <= 4.5) {
                                        if (input[14] <= -0.03333333507180214) {
                                            var49 = new double[3] {0.23500881834215165, 0.0, 0.7649911816578483};
                                        } else {
                                            var49 = new double[3] {0.05267383973020717, 0.0, 0.9473261602697928};
                                        }
                                    } else {
                                        if (input[5] <= 1.5) {
                                            var49 = new double[3] {0.1056701030927835, 0.0, 0.8943298969072165};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[9] <= 2.5) {
                    if (input[3] <= 0.1900000050663948) {
                        if (input[1] <= 0.12999999895691872) {
                            if (input[10] <= 2.0) {
                                if (input[2] <= 0.13333333656191826) {
                                    if (input[9] <= 1.0) {
                                        var49 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[4] <= 0.03333333507180214) {
                                        if (input[12] <= 3.5) {
                                            var49 = new double[3] {0.3046092184368737, 0.6953907815631263, 0.0};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[14] <= 0.06666667014360428) {
                                    if (input[2] <= 0.06666667014360428) {
                                        if (input[5] <= 1.5) {
                                            var49 = new double[3] {0.08055113937466879, 0.9194488606253313, 0.0};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[12] <= 2.5) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.0, 1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var49 = new double[3] {1.0, 0.0, 0.0};
                                }
                            }
                        } else {
                            if (input[5] <= 1.5) {
                                if (input[2] <= 0.03333333507180214) {
                                    var49 = new double[3] {0.0, 1.0, 0.0};
                                } else {
                                    if (input[2] <= 0.10000000521540642) {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                var49 = new double[3] {1.0, 0.0, 0.0};
                            }
                        }
                    } else {
                        if (input[13] <= -0.12999999895691872) {
                            if (input[14] <= 0.1666666716337204) {
                                if (input[10] <= 4.5) {
                                    if (input[10] <= 0.5) {
                                        if (input[9] <= 0.5) {
                                            var49 = new double[3] {0.34454098979977327, 0.6554590102002267, 0.0};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[9] <= 0.5) {
                                            var49 = new double[3] {0.23831922232674815, 0.7616807776732518, 0.0};
                                        } else {
                                            var49 = new double[3] {0.5351907841861533, 0.4648092158138467, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[11] <= 3.5) {
                                            var49 = new double[3] {0.045129334067143645, 0.0, 0.9548706659328563};
                                        } else {
                                            var49 = new double[3] {0.466973886328725, 0.533026113671275, 0.0};
                                        }
                                    } else {
                                        if (input[6] <= 0.5) {
                                            var49 = new double[3] {0.19414770088248953, 0.8058522991175104, 0.0};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[13] <= -0.1600000038743019) {
                                    if (input[3] <= 0.8400000035762787) {
                                        if (input[5] <= 0.5) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.38013576277241873, 0.6198642372275813, 0.0};
                                        }
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                } else {
                                    if (input[7] <= 1.0) {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    } else {
                                        var49 = new double[3] {0.0, 0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[6] <= 0.5) {
                                if (input[14] <= 0.1666666716337204) {
                                    if (input[4] <= 0.1666666716337204) {
                                        if (input[11] <= 5.5) {
                                            var49 = new double[3] {0.28921278552115237, 0.7107872144788476, 0.0};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.10999999940395355) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.3628351083363937, 0.6371648916636062, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[12] <= 3.5) {
                                        if (input[1] <= 0.3799999952316284) {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        } else {
                                            var49 = new double[3] {0.39115686045151477, 0.6088431395484852, 0.0};
                                        }
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[13] <= 0.04999999888241291) {
                                    if (input[1] <= 0.4299999922513962) {
                                        if (input[7] <= 0.5) {
                                            var49 = new double[3] {0.1490926924963217, 0.8509073075036783, 0.0};
                                        } else {
                                            var49 = new double[3] {0.0, 0.0, 1.0};
                                        }
                                    } else {
                                        if (input[13] <= -0.04000000096857548) {
                                            var49 = new double[3] {0.3445409897997733, 0.6554590102002267, 0.0};
                                        } else {
                                            var49 = new double[3] {0.1329335332333833, 0.8670664667666167, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= 0.23333334177732468) {
                                        if (input[10] <= 4.5) {
                                            var49 = new double[3] {0.4791353947763434, 0.5208646052236565, 0.0};
                                        } else {
                                            var49 = new double[3] {1.0, 0.0, 0.0};
                                        }
                                    } else {
                                        var49 = new double[3] {1.0, 0.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.03333333507180214) {
                        var49 = new double[3] {1.0, 0.0, 0.0};
                    } else {
                        var49 = new double[3] {1.0, 0.0, 0.0};
                    }
                }
            }
            return MulVectorNumber(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(var0, var1), var2), var3), var4), var5), var6), var7), var8), var9), var10), var11), var12), var13), var14), var15), var16), var17), var18), var19), var20), var21), var22), var23), var24), var25), var26), var27), var28), var29), var30), var31), var32), var33), var34), var35), var36), var37), var38), var39), var40), var41), var42), var43), var44), var45), var46), var47), var48), var49), 0.02);
        }
        private static double[] AddVectors(double[] v1, double[] v2) {
            double[] result = new double[v1.Length];
            for (int i = 0; i < v1.Length; ++i) {
                result[i] = v1[i] + v2[i];
            }
            return result;
        }
        private static double[] MulVectorNumber(double[] v1, double num) {
            double[] result = new double[v1.Length];
            for (int i = 0; i < v1.Length; ++i) {
                result[i] = v1[i] * num;
            }
            return result;
        }
    }
}
