using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitionalBodies : MonoBehaviour
{
    [SerializeField]
    private static float _gravitionalConstant = 1.0f;
    
    [SerializeField]
    private float _gravityFudge = 1.0f;

    /*[SerializeField]
    private float _torqueFudge = 1.0f;
    [SerializeField]
    private bool _doesRotate = false;*/

    // Start is called before the first frame update
    void Start()
    {
       float thisMass = this.gameObject.GetComponent<Rigidbody>().mass;
       this.gameObject.GetComponent<SphereCollider>().radius = Mathf.Sqrt(_gravitionalConstant * _gravityFudge * thisMass); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other) 
    {
        if (other.gameObject.GetComponent<GravitionalBodies>() != null) 
        {
            // Linear Transformation 
            Vector3 forceDirection = this.transform.position - other.transform.position;
            float radius = forceDirection.magnitude;
            forceDirection = forceDirection / radius;
            float inverseRadius = (1.0f / Mathf.Pow(radius, 2f));
            float thisMass = this.gameObject.GetComponent<Rigidbody>().mass;
            float otherMass = other.gameObject.GetComponent<Rigidbody>().mass;
            other.attachedRigidbody.AddForce(thisMass * otherMass * _gravitionalConstant * _gravityFudge * forceDirection * inverseRadius); 

            // Rotational transform
            /*if (_doesRotate) 
            {
                other.attachedRigidbody.AddTorque(Vector3.Cross(other.transform.forward, forceDirection) * thisMass * otherMass * _torqueFudge);

            }*/
             
        }
    }
}
