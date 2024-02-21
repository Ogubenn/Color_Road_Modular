using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTake : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && gameObject.CompareTag("Heart"))
        {
            GameManager.Instance.heartCoin++;
            Debug.Log("Take Heart");
            Debug.Log(GameManager.Instance.heartCoin);
            gameObject.SetActive(false);
        }
        else if (other.CompareTag("Player") && gameObject.CompareTag("5Diamond"))
        {
            GameManager.Instance.diamondCoinHexa++;
            Debug.Log("Take 5Diamond");
            Debug.Log(GameManager.Instance.diamondCoinHexa);
            gameObject.SetActive(false);
        }
        else if (other.CompareTag("Player") && gameObject.CompareTag("Diamond"))
        {
            Debug.Log("Take Diamond");
            GameManager.Instance.diamondCoin++;
            Debug.Log(GameManager.Instance.diamondCoin);
            gameObject.SetActive(false);
        }
        else if (other.CompareTag("Player") && gameObject.CompareTag("Star"))
        {
            Debug.Log("Take Star");
            GameManager.Instance.starCoin++;
            Debug.Log(GameManager.Instance.starCoin);
            gameObject.SetActive(false);
        }
    }


}//class
