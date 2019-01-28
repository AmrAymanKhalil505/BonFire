using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodStopGrav : MonoBehaviour
{   

    float Clock = 0;
    void Start()
    {   
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().isTrigger = false;
        Clock =2; 
    }

    void Update()
    {
        Clock-=Time.deltaTime;
        if(Clock<0){
            GetComponent<BoxCollider>().isTrigger = true;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
