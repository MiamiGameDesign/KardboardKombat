using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonControl : MonoBehaviour
{
    private Rigidbody rb;

    public float PlayerSpeed = 100f;

    [SerializeField] private float Health = 1000f;

    private bool canHit = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveNewton();

    }

    private void MoveNewton() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.Move(transform.position + -Vector3.right * PlayerSpeed * Time.deltaTime,
                Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.Move(transform.position + Vector3.right * PlayerSpeed * Time.deltaTime,
                Quaternion.identity);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.RightControl))
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
        Health -= 100;
    }
}
