using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Rendering.LookDev;

namespace CapstoneProject
{

    public class BasketballScript : MonoBehaviour
    {
        public AudioClip soundClip;
        public GameObject particleEffect;
        public int basketPoints;
        public int basketsMade = 0;
        public TextMeshProUGUI basketsMadeText;
        public AudioClip soundClip2; 
       
        [SerializeField]
        private WalletSystem walletSystem;


        private void Start()
        {
            basketsMadeText.text = "Baskets Made: 0";
        }


        // when basketball collides with net, audio sources play and UI texts are update
        private void OnTriggerEnter(Collider other)
        {
            
            if (other.gameObject.CompareTag("Basketball"))
            {
                AudioSource.PlayClipAtPoint(soundClip, transform.position);
                AudioSource.PlayClipAtPoint(soundClip2, transform.position);

                walletSystem.walletAmount += basketPoints;
                walletSystem.TextUpdate();
               
                particleEffect.SetActive(true);
                Invoke("StopParticleEffect", 5f);

                basketsMade++;  
                basketsMadeText.text = "Baskets Made: " + basketsMade;
            }
        }

        private void StopParticleEffect()
        {
            particleEffect.SetActive(false);    
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetInt("BasketsMade", basketsMade);
            PlayerPrefs.Save();
        }

    }


}

