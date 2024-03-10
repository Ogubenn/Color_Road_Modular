using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Intance
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("GameManagerSingleton");
                    _instance = singletonObject.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    #endregion

    #region veriables
    public int firstTouch = 0;

    [Header("Coins")]  
    public int heartCoin;
    public int starCoin;
    public int diamondCoinHexa;
    public int diamondCoin;

    [Header("Game Start")]
    public int GameStartGroundSpawn;

    [Header("Scripts")]
    public UIManager uiManager;
    public PlayerController playerController;

    [Header("Score")]
    public int currentLevel = 1;
    public float levelUzunlugu = 100f;

    public long VibrationPower1;
    public long VibrationPower2;
    #endregion


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        uiManager.CoinTextUpdate();
    }
}
