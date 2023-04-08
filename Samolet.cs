using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samolet : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed, Space.World);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed, Space.World);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * speed, Space.World);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down * speed, Space.World);
        }
    }
}
