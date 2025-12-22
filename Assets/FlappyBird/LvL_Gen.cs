using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvL_Gen : MonoBehaviour
{
    public GameObject pipesPrefab; // шаблон труб (налаштований зразок)
    [Range(0f, 5f)] public float heightRange; // діапазон висоти труб
    [Range(0.1f, 5f)] public float spawnInterval; // інтервал створення
    public float retreat = 3f; // Відступ за межі екрану

    private IEnumerator SpawnPipes()
    {
        while (true)
        {
            Instantiate( // Створити об'єкт
            pipesPrefab, // шаблон об'єкту
            transform.position, // положення
            Quaternion.identity); // обертання

            yield return new WaitForSeconds(spawnInterval);
        }
    }
    private void Start()
    {
        StartCoroutine(SpawnPipes()); 
    }
}
