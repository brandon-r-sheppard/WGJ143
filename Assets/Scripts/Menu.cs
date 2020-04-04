using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;



public class Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Text Musicv;
   
    public void Play()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        
    }

    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
       
    }
    public void Quit()
    {
        Application.Quit();
        

    }

    public void setMusicVolume(float Music)
    {
        audioMixer.SetFloat("Music", Mathf.Log10 (Music) * 20);
      
        
    }

    public void setSfxVolume(float sfx)
    {
        audioMixer.SetFloat("Sfx", Mathf.Log10(sfx) * 20);
        

        
      
        
    }


}
