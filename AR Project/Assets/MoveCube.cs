using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MoveCube : MonoBehaviour
{ 
    // [SerializeField] private Text SpeedText;
    Rigidbody target;
    float speed = 10f;
    float turnSpeed = 110f;
    float speedDisplayed;
    [Header("UI")]
    public TextMeshProUGUI speedLabel;


    void Start()
    {
        target = this.gameObject.GetComponent<Rigidbody> ();
    }
    // Update is called once per frame
    void Update()
    {
    
    	transform.Translate(Vector3.right * Time.deltaTime * speed);
    	//if (Input.GetKey(KeyCode.A)) {
    	  //  transform.Rotate(0f, Time.deltaTime * -turnSpeed, 0f);
    	//}
      // SpeedText.text = (m_Rigidbody.velocity.magnitude * 2.23693629f).ToString("0") + (" m/h");
      // speed = target.velocity.magnitude;
      speedDisplayed = speed;
      if (speedLabel != null) {
        speedLabel.text = ((int)speedDisplayed + " m/h");
      }
    	
        
    }
    
    void OnTriggerStay(Collider col) {
        if (col.gameObject.name == "RoadTurn_1") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -turnSpeed, 0f);
        }
        else if (col.gameObject.name == "RoadTurn_2") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -(turnSpeed-20f), 0f);
        }
        else if (col.gameObject.name == "RoadTurn_3") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -(turnSpeed-40f), 0f);
        }
        else if (col.gameObject.name == "RoadTurn_4") {
        	print("ENTER");
        	transform.Rotate(0f, Time.deltaTime * -(turnSpeed-20f), 0f);
        }
    }
    
    
}
