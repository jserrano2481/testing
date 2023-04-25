using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnCollision : MonoBehaviour
{
    public GameObject objectToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collidable"))
        {
            objectToActivate.SetActive(true);
        }
    }
}

