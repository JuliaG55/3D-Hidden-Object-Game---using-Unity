using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOrExit : MonoBehaviour {

    public void Restart()
    {
        //Moving back to the first scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Restart");
    }

    public void Exit()
    {
        Debug.Log("Exit!");
        Application.Quit();
    }
}
