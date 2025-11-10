using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance;

    [Header("Лічильник та ін.")]
    public float clickCounter = 0; // Змінна лічильника
    public int coinsPerClick = 1; // Валюти за клік

    [Header("Бонус до кліку")]
    public float clickBonusPrice = 10f; // Ціна за покращення(Базова)
    public float clickBonusPriceMod = 15f; // Модифікатор ціни
    
    [Header("Об'єкти на сцені")]
    public TextMeshProUGUI counterText; // Текст лічильника
    public TextMeshProUGUI coinsPerClickText; // Текст кількості монет за клік
    public TextMeshProUGUI clickBonusPriceText; // Текст поточної ціни

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        UpdatePerClickText();
        UpdatePerClickPriceText();
    }
    public float TakeCurrentPrice()
    {
        // поточнаЦіна = базова ціна + (монетЗаКлік - 1) * модифікатоЦіни
        float price =
            clickBonusPrice + (coinsPerClick - 1) * clickBonusPriceMod;
        return price;
    }
    public void UpdateCounterText()
    {
        counterText.text = "Монет: " + clickCounter.ToString();
    }
    public void UpdatePerClickText()
    {
        coinsPerClickText.text = $"+ {coinsPerClick} за клік";
    }
    public void UpdatePerClickPriceText()
    {
        clickBonusPriceText.text = $"Ціна за бонус: {TakeCurrentPrice()}";
    }
}
