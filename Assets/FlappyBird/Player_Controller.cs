using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    public GameObject camera; 
    private Rigidbody rb; // фізичний компонент

    public float jumpVelocity = 5f; // сила стрибка

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        // Стрибок
        if (Input.GetKeyDown(KeyCode.Space) ||
            Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.up * jumpVelocity,
                ForceMode.Impulse);
        }
    }
    private void LateUpdate()
    {
        camera.transform.position = new Vector3(
            camera.transform.position.x,
            transform.position.y,
            camera.transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(1);
    }
}
