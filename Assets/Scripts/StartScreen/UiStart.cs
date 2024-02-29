using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiStart : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject settingsPanel;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public  void SettingsButtonOn()
    {
        settingsPanel.SetActive(true);
        startPanel.SetActive(false);
    }
    public void SettingsButtonOff()
    {
        settingsPanel.SetActive(false);
        startPanel.SetActive(true);
    }



}//class
