using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion_Iz_De : MonoBehaviour
{
    public float rotation;
    public float movement;
    private Rigidbody rb;

    public float rotationSpeed = 1;
    public float movementSpeed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * movement * movementSpeed;
    }

    private void Update()
    {
        movement = Input.GetAxisRaw("Vertical");
        rotation = Input.GetAxisRaw("Horizontal");
        transform.eulerAngles = transform.eulerAngles + (Vector3.up*rotation*rotationSpeed);
    }
}
