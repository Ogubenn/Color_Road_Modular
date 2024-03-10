using UnityEngine;

public class Player : MonoBehaviour
{
    public CameraShake camerashakeScript;
    public PlayerController playerControllerScript;
    private float decreaseValue = 0.5f;
    private float currentforwordSpeed;
    private float decreaseRate;
    public UIManager uiManager;

    private void Start()
    {
        currentforwordSpeed = playerControllerScript.ballForwordSpeed;
        decreaseRate = currentforwordSpeed / decreaseValue;
    }

    private void Update()
    {
        if(GameManager.Instance.heartCoin <= 0 || GameManager.Instance.diamondCoin <= 0 || GameManager.Instance.diamondCoinHexa <= 0 || GameManager.Instance.starCoin <= 0)
        {
            float creaseAmount = decreaseRate * Time.deltaTime;
            camerashakeScript.CameraShakesCall();
            Vibration.VibrateCall(100);
            uiManager.StartCoroutine("WhiteEffect");
            Time.timeScale = 0.4f;
            playerControllerScript.ballForwordSpeed = 0;
            


        }
    }
}
