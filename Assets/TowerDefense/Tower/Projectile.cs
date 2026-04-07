using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject target; // посилання на ворога

    [SerializeField] float damage = 1f; // Шкода яку наносить вежа
    [SerializeField] float speed = 5f; // Швидкість снаряду

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.transform.position,
            speed * Time.fixedDeltaTime);

        transform.LookAt(target.transform);
    }
}
