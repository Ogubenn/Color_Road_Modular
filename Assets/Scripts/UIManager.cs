using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Gems")]
    public TextMeshProUGUI StarCoin;
    public TextMeshProUGUI DiamondCoin;
    public TextMeshProUGUI HexaCoin;
    public TextMeshProUGUI HeartCoin;

    public void CoinTextUpdate()
    {
        if(!StarCoin && !DiamondCoin && !HexaCoin && !HeartCoin)
        {
            Debug.Log("Coin Deðiþkenlerinde hata var");
        }

        StarCoin.text = GameManager.Instance.starCoin.ToString();
        DiamondCoin.text = GameManager.Instance.diamondCoin.ToString();
        HexaCoin.text = GameManager.Instance.diamondCoinHexa.ToString();
        HeartCoin.text = GameManager.Instance.heartCoin.ToString();
        Debug.Log("coinler güncellendi");
    }

   

}//class
