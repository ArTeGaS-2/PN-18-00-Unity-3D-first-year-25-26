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
        Vector3 pos = transform.position;
        float height = 0f;

        while (true)
        {
            pos.y = Random.Range(-heightRange, heightRange);

            Instantiate( // Створити об'єкт
            pipesPrefab, // шаблон об'єкту
            pos, // положення
            Quaternion.identity); // обертання

            yield return new WaitForSeconds(spawnInterval);
        }
    }
    private void Start()
    {
        StartCoroutine(SpawnPipes()); 
    }
}
