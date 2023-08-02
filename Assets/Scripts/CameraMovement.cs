using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target; // Drag the object that will be followed in the inspector.
    public Transform Camera; // Drag the camera object in the inspector.
    Vector3 tempVec3 = new Vector3(); // Temporary vector 3.

    void LateUpdate()
    {
        // If the target is active in the scene, set the x camera position to target.
        if (Target != null)
        {
            tempVec3.x = Target.position.x;
            tempVec3.y = this.transform.position.y;
            tempVec3.z = this.transform.position.z;
            this.transform.position = tempVec3;
        }
        // If target is not active in the scene, set the x camera position to itself.
        else if (Target == null)
        {
            tempVec3.x = Camera.position.x;
            tempVec3.y = Camera.transform.position.y;
            tempVec3.z = Camera.transform.position.z;
            Camera.transform.position = tempVec3;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
