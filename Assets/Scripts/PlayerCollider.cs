using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public PlayerScripte playerscripte;
    public ScoreText score;
    public GameController gameController;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name=="Red Ammo")
        {
            score.AddScore(1);
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blue Ammo" || other.gameObject.name == "Green Ammo" || other.gameObject.name == "spike" || other.gameObject.name == "Roller")
        {
            gameController.GameOver();
            playerscripte.enabled = false;
        }
    }
    
}
