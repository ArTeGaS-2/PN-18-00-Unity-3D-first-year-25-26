using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody rb; // фізичний компонент
    public float jumpVelocity = 5f; // сила стрибка
    public float forwardVelocity = 5f; // сила руху вперед

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
            rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }
    }
    private void FixedUpdate()
    {
        // рух вперед
        transform.Translate(
            Vector3.forward * forwardVelocity * Time.fixedDeltaTime);
        Debug.Log(rb.velocity.y);
    }

}
