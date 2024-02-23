using UnityEngine;

public class GameManager : MonoBehaviour
{
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
    public int firstTouch = 0;

    [Header("Coins")]
    public int heartCoin;
    public int starCoin;
    public int diamondCoinHexa;
    public int diamondCoin;

    [Header("Game Start")]
    public int GameStartGroundSpawn;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
