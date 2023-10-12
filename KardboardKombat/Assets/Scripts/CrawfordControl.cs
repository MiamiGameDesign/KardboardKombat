using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krawdaddyControl : MonoBehaviour
{

      
    public float verticalInput;
    public float horizontalInput;


[SerializeField] GameObject Crawford;

public float PlayerSpeed = 24f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveCrawford();
    }


private void MoveCrawford() {
    if (Input.GetKey(KeyCode.A)) {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
         transform.Translate(Vector3.up * verticalInput * PlayerSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * PlayerSpeed * Time.deltaTime);
}
    else if (Input.GetKey(KeyCode.D)) {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
         transform.Translate(Vector3.up * verticalInput * PlayerSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * PlayerSpeed * Time.deltaTime);
    //return -1 to +1, left and right respectively
}
else {}
}   

}


    