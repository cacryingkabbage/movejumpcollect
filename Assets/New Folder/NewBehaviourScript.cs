using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed, rotSpeed, jumpVel;
    public Rigidbody rb;
    
    public int score;
    public float baseMoveSpeed;

    public bool grounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        baseMoveSpeed= moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = (Input.GetAxis("Horizontal") * rotSpeed) * Time.deltaTime,
        translation = (Input.GetAxis("Vertical") * moveSpeed) * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (grounded == true)
        {
            if (Input.GetButton("Jump"))
            {
                rb.AddForce(new Vector3(0, jumpVel, 0), ForceMode.Impulse);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
  }
