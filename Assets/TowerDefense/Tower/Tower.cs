using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Снаряди")]
    [SerializeField] GameObject projcetilePrefab; // Шаблон снаряду
    [SerializeField] float shootInterval = 1.0f; // Затримка між пострілами

    private List<GameObject> enemies; // Вороги в зоні досяжності пострілу
}
