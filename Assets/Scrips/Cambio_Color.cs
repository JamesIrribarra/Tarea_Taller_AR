using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_Color : MonoBehaviour
{
    public GameObject sphere;

    public void RamdomColorSphere()
    {
        sphere.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
