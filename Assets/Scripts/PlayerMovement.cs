using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float forwardForce = 8000;
    private float sidewaysForce = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Adding Forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.Acceleration);
        
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
