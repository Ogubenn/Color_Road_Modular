using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UiStart : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject settingsPanel;

    [Header("Audio")]
    [SerializeField] private Slider MusicSlider;
    [SerializeField] private Slider SFXSlider;
    [SerializeField] private AudioMixer myMixer;


    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
            LoadVolume();

        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
    }

    #region Slider fonk.

    public void SetMusicVolume()
    {
        float volume = MusicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }
    public void LoadVolume()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetSFXVolume();
    }
    #endregion


    #region Button fonk.
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

    #endregion



}//class
