using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;



public class InGameMenu: MonoBehaviour
{
    public GameObject soundSettingsPanel;
    public GameObject menuPanel;

    public Slider backgroundSlider;
    public Slider sfxSlider;

    public string sfxName;
    public string backgroundName;
    public AudioMixer audioMixer;
    bool soundSettingsOpened = false;

    public void Start() {
        soundSettingsPanel.SetActive(false);
    }

    public void StartAgain() {
        LoadingScreen.instance.LoadScene(SceneManager.GetActiveScene().name);
        // LoadingScreen.instance.LoadScene("Level1");
    }

    public void ExitToMenu() {
        LoadingScreen.instance.LoadScene("MainMenu");        
    }

    public void openSoundSettings() {
        menuPanel.SetActive(false);
        soundSettingsPanel.SetActive(true);
    }

    public void closeSoundSettings() {
        menuPanel.SetActive(true);
        soundSettingsPanel.SetActive(false);        
    }

    public void OnEnable() {
        backgroundSlider.onValueChanged.AddListener(backgroundChange);
        audioMixer.GetFloat(backgroundName, out var sfxVal);
        backgroundSlider.value = sfxVal;

        sfxSlider.onValueChanged.AddListener(sfxChange);
        audioMixer.GetFloat(sfxName, out var backgroundVal);
        sfxSlider.value = backgroundVal;
    }

    public void OnDisable() {
        backgroundSlider.onValueChanged.RemoveListener(backgroundChange);
        sfxSlider.onValueChanged.AddListener(sfxChange);
    }

    private void backgroundChange(float value) {
        audioMixer.SetFloat(backgroundName, value);
    }

    private void sfxChange(float value) {
        audioMixer.SetFloat(sfxName, value);
    }
    
}
