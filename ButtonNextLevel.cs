using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextLevel : MonoBehaviour {

    

    public void ChangeToScene(int whatScenetoChange)
    {
        SceneManager.LoadScene(whatScenetoChange);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
