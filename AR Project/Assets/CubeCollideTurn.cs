using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollideTurn : MonoBehaviour
{

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "RoadTurn_1") {
        	transform.Rotate(Vector3.down * 2 * Time.deltaTime);
        }

        
    }
}
