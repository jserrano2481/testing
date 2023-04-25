using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace CapstoneProject
{

    public class CashRegister : MonoBehaviour
    {
        [SerializeField]
        private WalletSystem walletSystem; 

        public TextMeshProUGUI messagePrefab; 
        public Canvas canvas; 


        public void AccountBalance()
        {
            TextMeshProUGUI messageText = Instantiate(messagePrefab, canvas.transform);

            
            if (walletSystem.walletAmount != 0)
            {
                // if remainingMoney is greater than zero, show the message with the remaining money
                messageText.text = "You still have $" + walletSystem.walletAmount + ". Do you want to check out?";
            }
            else
            {
                // if remainingMoney is zero, show the message that all money has been used
                messageText.text = "You have used all your $. Thanks for shopping with us!";
            }

        }

      

    }


}