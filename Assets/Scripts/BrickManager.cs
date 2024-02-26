using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public int BrickNumberTMP;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(gameObject.CompareTag("BrickStar"))
            {
                GameManager.Instance.starCoin -= BrickNumberTMP;
                GameManager.Instance.uiManager.CoinTextUpdate();
                Debug.Log("Kýrýldý");
            }
            else if(gameObject.CompareTag("BrickHexa"))
            {
                GameManager.Instance.diamondCoinHexa -= BrickNumberTMP;
                GameManager.Instance.uiManager.CoinTextUpdate();
                Debug.Log("Kýrýldý");
            }
            else if(gameObject.CompareTag("BrickDiamond"))
            {
                GameManager.Instance.diamondCoin -= BrickNumberTMP;
                GameManager.Instance.uiManager.CoinTextUpdate();
                Debug.Log("Kýrýldý");
            }
            else if(gameObject.CompareTag("BrickHeart"))
            {
                GameManager.Instance.heartCoin -= BrickNumberTMP;
                GameManager.Instance.uiManager.CoinTextUpdate();
                Debug.Log("Kýrýldý");
            }
        }
    }


}//class
