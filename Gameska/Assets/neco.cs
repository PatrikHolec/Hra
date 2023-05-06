using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neco : MonoBehaviour
{
    public void GameFinishedZapnout()
    {
        gameObject.SetActive(true);
    }

    public void GameFinishedVypnout()
    {
        gameObject.SetActive(false);
    }


}
