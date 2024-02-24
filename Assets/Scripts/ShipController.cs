using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    [SerializeField]
    private float rotateSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // temperary controls before command system is set up
       if (Input.GetButton("Jump")) {
            Vector3 forwardDirection = this.gameObject.GetComponent<Transform>().forward;
            this.gameObject.GetComponent<Rigidbody>().AddForce(forwardDirection * speed);
       }
       if (Input.GetAxis("Horizontal") > 0.01f) 
       {
            this.transform.Rotate(0.0f, rotateSpeed, 0.0f);
       }
       if (Input.GetAxis("Horizontal") < -0.01f)
       {
            this.transform.Rotate(0.0f, -rotateSpeed, 0.0f);
       }  
       if (Input.GetAxis("Vertical") > 0.01f)
       {
            //this.transform.Rotate(0.0f, 0.0f, rotateSpeed);
            this.transform.Rotate(rotateSpeed, 0.0f, 0.0f);
       }
       if (Input.GetAxis("Vertical") < -0.01f)
       {
            //this.transform.Rotate(0.0f, 0.0f, -rotateSpeed);
            this.transform.Rotate(-rotateSpeed, 0.0f, 0.0f);
       }
    }
}
