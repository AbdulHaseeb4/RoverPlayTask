using UnityEngine;
using System;

public class GoldManager : MonoBehaviour
{
    public static GoldManager Instance;

    public int gold = 0;
    public static event Action<int> OnGoldChanged;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddGold(int amount)
    {
        gold += amount;
        OnGoldChanged?.Invoke(gold);
    }
}
