using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCollider : MonoBehaviour
{
    public RollerScripte rollerScripte;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
