using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonControl : MonoBehaviour
{


    


    
[SerializeField] GameObject Newton;

public float PlayerSpeed = 24f;

public float verticalInput;
public float horizontalInput;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveNewton();

    }

    private void MoveNewton() {
        // if (Input.GetKey(KeyCode.LeftArrow)) {
        //     horizontalInput = Input.GetAxis("Horizontal");
        //     verticalInput = Input.GetAxis("Vertical");
        //     transform.Translate(Vector3.up * verticalInput * PlayerSpeed * Time.deltaTime);
        //     transform.Translate(Vector3.right * horizontalInput * PlayerSpeed * Time.deltaTime);
        // }
        // else if (Input.GetKey(KeyCode.RightArrow)) {
        //     horizontalInput = Input.GetAxis("Horizontal");
        //     verticalInput = Input.GetAxis("Vertical");
        //     transform.Translate(Vector3.up * verticalInput * PlayerSpeed * Time.deltaTime);
        //     transform.Translate(Vector3.right * horizontalInput * PlayerSpeed * Time.deltaTime);
        // //return -1 to +1, left and right respectively
        // }
        // else {}
        horizontalInput = Input.GetAxis("Horizontal");
            //verticalInput = Input.GetAxis("Vertical");
            //transform.Translate(Vector3.up * verticalInput * PlayerSpeed * Time.deltaTime);
            transform.Translate(Vector3.right * horizontalInput * PlayerSpeed * Time.deltaTime);
    }   
        



}
