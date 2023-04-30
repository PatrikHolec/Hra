using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTrigger : MonoBehaviour
{
    public void BackgroundOFF()
    {
        gameObject.SetActive(false);
    }

    public void BackgroundON()
    {
        gameObject.SetActive(true);
    }
}
