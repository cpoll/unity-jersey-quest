using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // TODO: Learn new input system (later)
    void Update()
    {
        float Speed = 1f;

        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W)) {
            pos.z += Speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S)) {
            pos.z -= Speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D)) {
            pos.x += Speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A)) {
            pos.x -= Speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("hi");
            pos.y += Speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftShift)) {
            pos.y -= Speed * Time.deltaTime;
        }

        transform.position = pos;

    }
}
