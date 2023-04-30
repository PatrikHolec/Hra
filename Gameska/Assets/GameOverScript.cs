using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public PlayerCollision playerCollision;

    public void Zapnout() 
    {
        gameObject.SetActive(true);

    }

    public void Vypnout()
    {
        gameObject.SetActive(false);
    }

    public void RestartButton()
    {
        playerCollision.Respawn();
    }
}
