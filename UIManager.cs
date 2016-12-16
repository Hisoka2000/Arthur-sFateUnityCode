using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    GameObject[] pauseObjects;
    GameObject[] finishObjects;

public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void showFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnFinish tag
    public void hideFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }


    void Start()
    {
        Time.timeScale = 1;

        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFin");


        hidePaused();
        hideFinished();
    }


    void Update()
    {
        if(Time.timeScale == 1)
        {
            Cursor.visible = false;
        }
            else
            {
                Cursor.visible = true;
            }

        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 1 && AttackEnemy.Alive == true)
            {
                Time.timeScale = 0;
                showPaused();
            }
                else if (Time.timeScale == 0 && AttackEnemy.Alive == true)
                {
                    Debug.Log("high");
                    Time.timeScale = 1;
                    hidePaused();
                }
       }

        if (Time.timeScale == 0 && AttackEnemy.Alive == false)
        {
            showFinished();
        }
    }


    //Reloads the Level
    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    //controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag


    //loads inputted level
    public void ChangeToScene(int whatScenetoChange)
    {
        SceneManager.LoadScene(whatScenetoChange);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
