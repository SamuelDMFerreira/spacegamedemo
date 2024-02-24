using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //[SerializeField]
    //private float _lerpConstant = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("CameraPos");
        Transform thisTran = this.gameObject.GetComponent<Transform>();
        Transform playerTran = player.gameObject.GetComponent<Transform>(); 
        //Vector3 newCameraVector = Vector3.Lerp(thisTran.position, playerTran.position, _lerpConstant);
        thisTran.position = playerTran.position;
        thisTran.rotation = playerTran.rotation; 
    }
}
