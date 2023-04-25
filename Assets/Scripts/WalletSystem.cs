using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace CapstoneProject
{

    public class WalletSystem : MonoBehaviour
    {
        public TMP_Text walletAmount_Text;
        public int walletAmount;


        // set item cost that is edited on inspector and subtracts it from total wallet amount 
        public void OnBuyNow(int itemCost)
        {
            if (walletAmount >= itemCost)
            {
                walletAmount -= itemCost;

            }

            TextUpdate();
        }

        public void TextUpdate()
        {
            walletAmount_Text.text = "Wallet:" + walletAmount.ToString();
        }
    }

}



