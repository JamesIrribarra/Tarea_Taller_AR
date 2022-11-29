using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion_360 : MonoBehaviour
{
    public float rotation_Horizontal;
    public float rotation_Vetical;
    private Rigidbody rb;

    public float rotationSpeed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rotation_Vetical = Input.GetAxisRaw("Vertical");
        rotation_Horizontal = Input.GetAxisRaw("Horizontal");
        transform.eulerAngles = transform.eulerAngles + (Vector3.up * rotation_Horizontal * rotationSpeed);
        transform.eulerAngles = transform.eulerAngles + (Vector3.right * rotation_Vetical * rotationSpeed);
    }
}
