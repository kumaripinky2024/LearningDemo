using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //void Start()
    //{
    //    //rb.useGravity = true;
    //    rb.AddForce(0, 200, 500);
    //}
    void Update()
    {
        //rb.useGravity = true;
        rb.AddForce(0, 0, 200*Time.deltaTime);
    }

}
