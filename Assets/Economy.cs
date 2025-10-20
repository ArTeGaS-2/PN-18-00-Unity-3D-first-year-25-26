using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance;

    public int clickCounter = 0; // «м≥нна л≥чильника
    public int coinsPerClick = 1; // ¬алюти за кл≥к

    private void Awake()
    {
        Instance = this;
    }
}
