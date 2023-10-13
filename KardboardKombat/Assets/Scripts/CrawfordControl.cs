using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krawdaddyControl : MonoBehaviour
{
    private Rigidbody rb;

    public float PlayerSpeed = 300f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCrawford();
    }


    private void MoveCrawford()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.Move(transform.position + -Vector3.right * PlayerSpeed * Time.deltaTime,
                Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.Move(transform.position + Vector3.right * PlayerSpeed * Time.deltaTime, 
                Quaternion.identity);
        }
    }
}


    