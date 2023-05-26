using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainManuManeger : MonoBehaviour
{
    

    public void ButtonSinglePlayer()
    {
        SceneManager.LoadScene(1);
    }
     public void ButtonMultiPlayer()
    {
        
    }
   public  void ButtonQuit()
    {
        Application.Quit();
    }





}
