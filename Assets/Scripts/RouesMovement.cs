using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouesMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Vertical");

        if (input != 0) {
            transform.Translate(Vector3.forward * (input / 10) * Time.fixedDeltaTime);
        }

        input = Input.GetAxis("Horizontal");

        if (input != 0) {
            transform.Rotate(Vector3.up * input * Time.fixedDeltaTime);
        }
    }
}
