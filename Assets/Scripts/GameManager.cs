using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}
    
    private int moneyBalance;


    private void Awake()
    {
        instance = this;
    }
}
