using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
        //if (Input.GetButton("ExitToMainMenu")
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene());
        //}
    }
}
