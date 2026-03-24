using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float damage = 1f; // Шкода яку наносить вежа
    [SerializeField] float speed = 5f; // Швидкість снаряду

    [HideInInspector] public GameObject target; // посилання на ворога
}
