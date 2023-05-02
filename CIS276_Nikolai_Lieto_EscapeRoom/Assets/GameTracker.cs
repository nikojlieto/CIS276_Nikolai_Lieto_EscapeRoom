using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTracker : MonoBehaviour
{
    public int gameStateA = 0;
    //state 1: pick up windup key
    //state 2: solve puzzle 1, get desk key 1
    public int gameStateB = 0;
    //state 1: pick up scissors, necklace
    //state 2: solve puzzle 2, get desk key 2
    public int gameStateC = 0;
    //state 1: get desk key
    //state 2: get door key
}
