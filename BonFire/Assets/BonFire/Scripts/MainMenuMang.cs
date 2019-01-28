using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenuMang : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject OptionsPanel;
    public GameObject CreditsPanel;
    public GameObject HowToPlayPanel;

    public AudioMixer audioMixer;
    public string NewGameScene;
    void Start()
    {
        clearPanels();
        StartPanel.SetActive(true);
    }
    public  void newGameOnClick(){
        SceneManager.LoadScene(NewGameScene);
    }
    public void optionsOnClick (){
        clearPanels();
        OptionsPanel.SetActive(true);
       
    }
    public void backToStartOnClick (){
        clearPanels();
        StartPanel.SetActive(true);
        
    }
     public void creditsOnClick (){
        clearPanels();
         CreditsPanel.SetActive(true);
     }
    public void howToPlayOnClick(){
         clearPanels();
            HowToPlayPanel.SetActive(true);
    }
    public void exitOnClick(){
         Application.Quit();
    }

    void clearPanels(){
        StartPanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        HowToPlayPanel.SetActive(false);
    }

    public void MusicVolumeChange(float volume){
            audioMixer.SetFloat("MusicVol", volume);
        }
    public void MasterVolumeChange(float volume){
            audioMixer.SetFloat("MasterVol", volume);
        }

    public void EffectsVolumeChange(float volume){
            audioMixer.SetFloat("EffectVol", volume);
        }
    

}
