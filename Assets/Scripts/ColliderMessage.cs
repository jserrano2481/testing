using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColliderMessage : MonoBehaviour
{
    public AudioClip soundClip;
    public TextMeshProUGUI textMesh;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collidable"))
        {
            AudioSource.PlayClipAtPoint(soundClip, transform.position);
            textMesh.gameObject.SetActive(true);
        }
    }
}
