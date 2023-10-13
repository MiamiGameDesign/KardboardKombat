using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class krawdaddyControl : MonoBehaviour
{
    private Rigidbody rb;
    public Text health;

    public float PlayerSpeed = 100f;

    [SerializeField] private float currHealth = 1000f;
    [SerializeField] private float maxHealth = 1000f;

    private bool canHit = true;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        currHealth = 1000f;
        maxHealth = 1000f;
    }

    void Update()
    {
        health.text = "Health: " + currHealth + " / " + maxHealth;
        if (currHealth <= 0)
            SceneManager.LoadScene("SampleScene");
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

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (canHit)
                other.gameObject.GetComponent<NewtonControl>().TakeDamage();

            canHit = false;
        }
        else
        {
            canHit = true;
        }
    }

    public void TakeDamage()
    {
        currHealth -= 100;
    }
}


    