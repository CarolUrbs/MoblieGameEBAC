using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;


public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    new private void Awake()
    {
        base.Awake();
        Reset();

    }
    private void Reset()
    {
        coins.value = 0;
    }
    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
    }

  
}

