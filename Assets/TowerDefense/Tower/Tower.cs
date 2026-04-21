using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Снаряди")]
    [SerializeField] GameObject projcetilePrefab; // Шаблон снаряду
    [SerializeField] float shootInterval = 1.0f; // Затримка між пострілами
    [SerializeField] float towerDamage = 1f; // Шкода яку наносить вежа
    [SerializeField] float towerRange = 4f; // Дальність атаки
    [SerializeField] float projectileSpeed = 5f; //Швидкість снаряду

    [Header("Загальні данні")]
    [SerializeField] GameObject spawnPoint; // Точка появи проджектайлу
    [SerializeField] float baseBuildCost = 15f; // Ціна вежі

    private List<GameObject> enemiesList; // Вороги в зоні досяжності пострілу
    private void Start()
    {
        StartCoroutine(ProjectileSpawnCycle());
    } 
    private void ProjectileSpawn()
    {
        GameObject projectile = Instantiate( // Зберігаємо об'єкт в змінну
            projcetilePrefab, // посилання на шаблон
            spawnPoint.transform.position, // позиція спавну
            Quaternion.identity); // обертання
    }
    private IEnumerator ProjectileSpawnCycle()
    {
        while (true)
        {
            ProjectileSpawn(); // Момент створення снаряду
            yield return new WaitForSecondsRealtime(shootInterval); // Затримка
        }
    }
}
