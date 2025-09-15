using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseClickLoop : MonoBehaviour
{
    public int clickCounter = 0; // Змінна лічильника
    public TextMeshProUGUI textObj; // Об'єкт тексту на сцені

    private void OnMouseDown()
    {
        clickCounter++;
        textObj.text = "Монет: " + clickCounter.ToString(); 
    }
}
