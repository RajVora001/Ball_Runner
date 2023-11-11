using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerScripte : MonoBehaviour
{

    public float maxZ;
    public float minZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + new Vector3(0, 0, -4f * Time.deltaTime);
        transform.position = transform.position + new Vector3(0, 0, 2.7f * Time.deltaTime);

        Vector3 vector3 = transform.position;
        if(vector3.magnitude <= minZ)
        {
            transform.position = transform.position + new Vector3(0 ,0 ,-2.7f * Time.deltaTime);
        }

        

    }
}
