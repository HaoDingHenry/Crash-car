using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 80.0f;
    private float horizontalInput;
    private float forwardInput;
    //25.0f for floating-point number (single precision)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Input.GetAxis("Horizontal")£ºIt will return a value.


        //Move the vihicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //Vector3.up£ºVector3.up£¨0,1,0£©£»Vector3.forward£ºVector3.up£¨0,0,1£©
        //Time.deltaTime£ºKeep moving objects moving at the same average speed at the same time
    }
}
