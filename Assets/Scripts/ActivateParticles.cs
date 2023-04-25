using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParticles : MonoBehaviour
{
    public GameObject particles;
    public float activationTime = 3f;


    //uses coroutine activate particle effects throughout the experience
    public void Start()
    {
        StartCoroutine(ActivateObjectForTime());
    }

    IEnumerator ActivateObjectForTime()
    {
        particles.SetActive(true);
        yield return new WaitForSeconds(activationTime);
        particles.SetActive(false);
    }
}
