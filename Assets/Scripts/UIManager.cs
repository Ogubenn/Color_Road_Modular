using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Gems")]
    public TextMeshProUGUI StarCoin;
    public TextMeshProUGUI DiamondCoin;
    public TextMeshProUGUI HexaCoin;
    public TextMeshProUGUI HeartCoin;

    [Header("First Touch Object")]
    public GameObject StarCoinObject;
    public GameObject DiamondCoinObject;
    public GameObject HexacoinObject;
    public GameObject HeartCoinObject;
    public GameObject topToMove;
    public GameObject FirstTouchhand;
    public GameObject LevelTextParents;

    [Header("Score Object")]
    public TextMeshProUGUI ScoreText;
    public Vector3 FirstPlayerPos;
    float toplamMesafe = 0f;
    public TextMeshProUGUI levelText;

    public GameObject Player;
    


    public Image WhiteEffect�mage;
    private int effectControl = 0;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("Vibration"))
        {
            PlayerPrefs.SetInt("Vibration", 1);
        } 
    }

    private void Update()
    {
        toplamMesafe += GameManager.Instance.playerController.ballForwordSpeed * Time.deltaTime;
        if (toplamMesafe >= GameManager.Instance.levelUzunlugu)
        {
            GameManager.Instance.currentLevel++;
            levelText.text = GameManager.Instance.currentLevel.ToString();

            toplamMesafe = 0f;
        }
    }

    #region TextUpdate Fonk.
    public void CoinTextUpdate()
    {
        if(!StarCoin && !DiamondCoin && !HexaCoin && !HeartCoin)
        {
            Debug.Log("Coin De�i�kenlerinde hata var");
        }

        StarCoin.text = GameManager.Instance.starCoin.ToString();
        DiamondCoin.text = GameManager.Instance.diamondCoin.ToString();
        HexaCoin.text = GameManager.Instance.diamondCoinHexa.ToString();
        HeartCoin.text = GameManager.Instance.heartCoin.ToString();
    }

    #endregion

    public void  FirstTouchU�()
    {
        if (!StarCoinObject || !HexacoinObject || !DiamondCoinObject || !HexacoinObject)
            Debug.Log("FirstTouch objelerinde hata var");

        StarCoinObject.SetActive(true);
        HeartCoinObject.SetActive(true);
        DiamondCoinObject.SetActive(true);
        HexacoinObject.SetActive(true);
        topToMove.SetActive(false);
        FirstTouchhand.SetActive(false);
        LevelTextParents.SetActive(true);
    }

    #region White Effect Damage
    public IEnumerator WhiteEffect()
    {
        WhiteEffect�mage.gameObject.SetActive(true);
        while (effectControl == 0)
        {
            yield return new WaitForSeconds(0.001f);
            WhiteEffect�mage.color += new Color(0, 0, 0, 0.1f);
            if (WhiteEffect�mage.color == new Color(WhiteEffect�mage.color.r, WhiteEffect�mage.color.g, WhiteEffect�mage.color.b, 1))
                effectControl = 1;
        }
        while (effectControl == 1)
        {
            yield return new WaitForSeconds(0.001f);
            WhiteEffect�mage.color -= new Color(0, 0, 0, 0.1f);
            if (WhiteEffect�mage.color == new Color(WhiteEffect�mage.color.r, WhiteEffect�mage.color.g, WhiteEffect�mage.color.b, 0))
                effectControl = 2;
        }

        if (effectControl == 2)
        {
            Debug.Log("White effect bitti");
        }
    }
    #endregion



}//class
