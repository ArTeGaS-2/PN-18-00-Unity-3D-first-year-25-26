using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvL_Gen : MonoBehaviour
{
    [Header("Шаблони труб")]
    public GameObject pipesPrefab; // шаблон труб (налаштований зразок)
    public List<GameObject> listOfAnotherPrefabs; // інші префаби

    [Header("Загальні налаштування")]
    [Range(0f, 5f)] public float heightRange; // діапазон висоти труб
    [Range(0.1f, 5f)] public float spawnInterval; // інтервал створення
    public int cycleCounter = 3; // підрахунок труб

    private int listCounter = 0; // пам'ять про номер останнього шаблону

    private IEnumerator SpawnPipes()
    {
        Vector3 pos = transform.position;
        float height = 0f;
        float currentCycleNum = 0f;

        while (true)
        {
            pos.y = Random.Range(-heightRange, heightRange);

            if (currentCycleNum > cycleCounter)
            {
                Instantiate( // Створити об'єкт
                listOfAnotherPrefabs[0], // шаблон об'єкту
                pos, // положення
                Quaternion.identity); // обертання

                currentCycleNum = 0;
            }
            else
            {
                Instantiate( // Створити об'єкт
               pipesPrefab, // шаблон об'єкту
               pos, // положення
               Quaternion.identity); // обертання

                currentCycleNum++;
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    private void Start()
    {
        StartCoroutine(SpawnPipes()); 
    }
}
