using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool PauseGame = false;
  

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) &&  PauseGame == false)
            {
          
            Time.timeScale = 0;
            PauseCanvas.SetActive(true);
            PauseGame = true;
           
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && PauseGame == true)
        {
            Time.timeScale = 1;
            PauseCanvas.SetActive(false);
            PauseGame = false;
           
        }

    }
}
