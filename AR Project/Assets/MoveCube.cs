using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    float speed = 10f;
    float turnSpeed = 110f;
    
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
    
    	transform.Translate(Vector3.right * Time.deltaTime * speed);
    	//if (Input.GetKey(KeyCode.A)) {
    	  //  transform.Rotate(0f, Time.deltaTime * -turnSpeed, 0f);
    	//}
    	
        
    }
    
    void OnTriggerStay(Collider col) {
        if (col.gameObject.name == "RoadTurn_1") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -turnSpeed, 0f);
        }
        if (col.gameObject.name == "RoadTurn_2") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -(turnSpeed-20f), 0f);
        }
        if (col.gameObject.name == "RoadTurn_3") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -(turnSpeed-40f), 0f);
        }
        if (col.gameObject.name == "RoadTurn_4") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -(turnSpeed-20f), 0f);
        }
    }
    
    
}
