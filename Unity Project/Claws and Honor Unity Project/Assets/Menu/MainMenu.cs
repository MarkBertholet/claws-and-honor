using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void NewGame (float newgame)
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame (float quitgame)
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
