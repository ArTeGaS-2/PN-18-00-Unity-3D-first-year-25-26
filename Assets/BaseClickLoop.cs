using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseClickLoop : MonoBehaviour
{
    public int clickCounter = 0; // Змінна лічильника
    public TextMeshProUGUI textObj; // Об'єкт тексту на сцені
    public bool buttonPressStatus = false; // Чи натиснута кнопка

    private void OnMouseDown()
    {
        ClickButton();
        ClickImpactEffect();
    }
    private void OnMouseUp()
    {
        ClickImpactEffectDisable();
    }
    private void ClickButton()
    {
        clickCounter++;
        textObj.text = "Монет: " + clickCounter.ToString();
    }
    private void ClickImpactEffect()
    {
        if (buttonPressStatus == false)
        {
            transform.localPosition = new Vector3(0, 0.3f, 0); // 0  0.5  0
            buttonPressStatus = true;
        }
    }
    private void ClickImpactEffectDisable()
    {
        if (buttonPressStatus == true)
        {
            transform.localPosition = new Vector3(0, 0.5f, 0);
            buttonPressStatus = false;
        } 
    }
}
