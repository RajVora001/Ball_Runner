using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeScript : MonoBehaviour
{
    public GameController gameController;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        {
            Destroy(other.gameObject);
            gameController.GameOver();
        }
    }
}
