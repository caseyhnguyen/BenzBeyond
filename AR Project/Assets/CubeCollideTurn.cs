using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class CubeCollideTurn : MonoBehaviour
{
    // [SerializeField] private Text SpeedText;
    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "RoadTurn_1") {
        	transform.Rotate(Vector3.down * 2 * Time.deltaTime);
        }

        
    }
}

// private void Update() {
//     SpeedText.text = (m_Rigidbody.velocity.magnitude * 2.23693629f).ToString("0") + (" m/h");
// }
