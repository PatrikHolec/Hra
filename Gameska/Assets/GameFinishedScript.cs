using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFinishedScript : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("546515");
    }

    public void QuitGameButton()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
