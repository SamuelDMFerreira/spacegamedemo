using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocity : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       gameObject.GetComponent<Rigidbody>().velocity =  new Vector3(speed, 0.0f, 0.0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
