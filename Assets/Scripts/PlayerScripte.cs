using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripte : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX;
    public float minX; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        if(playerPos.x<minX)
        {
            playerPos.x = minX;
            transform.position = playerPos;
        }
        if(playerPos.x>maxX)
        {
            playerPos.x = maxX;
            transform.position = playerPos;
        }


        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(4f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(-4f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, -10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 7.2f * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 10f * Time.deltaTime);
        }

        
    }
}
