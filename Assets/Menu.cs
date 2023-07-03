using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    [SerializeField] private string SceneName;
   public void StartGeme()
    {
        SceneManager.LoadScene(SceneName);
        
    }

    // Update is called once per frame
    public void AnGeme()
    {
        Application.Quit();
    }
}
