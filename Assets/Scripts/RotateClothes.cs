using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateClothes : MonoBehaviour
{
    public float rotationSpeed = 40f;

    void Update()
    {
        // Rotate the object on its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
