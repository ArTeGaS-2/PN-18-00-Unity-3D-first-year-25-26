using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    public GameObject GameObjFolder; // Папка з об'єктами гри
    public GameObject UIGameObjFolder; // Папка UI об'єктів гри

    public void SS_Button()
    {
        GameObjFolder.SetActive(!GameObjFolder.activeSelf);
        UIGameObjFolder.SetActive(!UIGameObjFolder.activeSelf);
    }
}
