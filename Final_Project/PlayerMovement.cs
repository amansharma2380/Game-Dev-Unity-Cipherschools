using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
      public Rigidbody rb;
      public float ForwardForce;
    public float slideForce;
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
            {
            rb.AddForce(slideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
            {
            rb.AddForce(-slideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }

    }


}
