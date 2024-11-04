using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public int health = 10;
    public int expc = 5;
    public int gold = 200;
    void Start()
    {
        health -= 1; 
        expc += 2;
        gold += 100;
        //var myVector= new Vector3(2,5,5);
        Debug.Log(health);
        Debug.Log(expc);
        Debug.Log(gold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
