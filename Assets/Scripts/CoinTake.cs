using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTake : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Heart") && GameManager.Instance.diamondCoinHexa >= GameManager.Instance.heartCoin && GameManager.Instance.diamondCoin >= GameManager.Instance.heartCoin && GameManager.Instance.starCoin >= GameManager.Instance.heartCoin)
            {
                GameManager.Instance.heartCoin++;
                GameManager.Instance.uiManager.CoinTextUpdate();
                gameObject.SetActive(false);
                if(GameManager.Instance.heartCoin % 2 == 0)
                    Vibration.VibrateCall(GameManager.Instance.VibrationPower1);
            }
            else if (gameObject.CompareTag("5Diamond") && GameManager.Instance.heartCoin >= GameManager.Instance.diamondCoinHexa && GameManager.Instance.diamondCoin >= GameManager.Instance.diamondCoinHexa && GameManager.Instance.starCoin >= GameManager.Instance.diamondCoinHexa)
            {
                GameManager.Instance.diamondCoinHexa++;
                GameManager.Instance.uiManager.CoinTextUpdate();
                gameObject.SetActive(false);
                if (GameManager.Instance.diamondCoinHexa % 2 == 0)
                    Vibration.VibrateCall(GameManager.Instance.VibrationPower1);

            }
            else if ( gameObject.CompareTag("Diamond") && GameManager.Instance.heartCoin >= GameManager.Instance.diamondCoin && GameManager.Instance.diamondCoinHexa >= GameManager.Instance.diamondCoin && GameManager.Instance.starCoin >= GameManager.Instance.diamondCoin)
            {
                GameManager.Instance.diamondCoin++;
                GameManager.Instance.uiManager.CoinTextUpdate();
                gameObject.SetActive(false);
                if (GameManager.Instance.diamondCoin % 2 == 0)
                    Vibration.VibrateCall(GameManager.Instance.VibrationPower1);

            }
            else if (gameObject.CompareTag("Star") && GameManager.Instance.heartCoin >= GameManager.Instance.starCoin && GameManager.Instance.diamondCoin >= GameManager.Instance.starCoin && GameManager.Instance.diamondCoinHexa >= GameManager.Instance.starCoin)
            {
                GameManager.Instance.starCoin++;
                GameManager.Instance.uiManager.CoinTextUpdate();
                gameObject.SetActive(false);
                if (GameManager.Instance.starCoin % 2 == 0)
                    Vibration.VibrateCall(GameManager.Instance.VibrationPower1);
            }
            else
            {
                GameManager.Instance.starCoin--;
                GameManager.Instance.heartCoin--;
                GameManager.Instance.diamondCoinHexa--;
                GameManager.Instance.diamondCoin--;
                Debug.Log("Else durumu gerçekleþti");
                GameManager.Instance.uiManager.CoinTextUpdate();
                gameObject.SetActive(false);
            }
        }

        
            
    }



}//class
