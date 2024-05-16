using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veiculo : MonoBehaviour
{
    private float speed = 15;
    private float turnSpeed = 25;
    
    public float  forwardInput;
    public float  horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        forwardInput =Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Drive forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        //Conditional to invert Reverse Gear in back direction
        if(forwardInput > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        } 

        else if(forwardInput < 0)
        {
            transform.Rotate((Vector3.up * -1) * Time.deltaTime * turnSpeed * horizontalInput);
        }
    



        
    }
}
