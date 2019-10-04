using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Button")
        {
            //Physics.gravity.y = 0;

            //float g = 0;
            //Physics gamePhysics;
            //gamePhysics = 1;
           

            //float y = Physics.gravity.y;

            //Vector3 


            //Physics.bounceThreshold = 1;
            Physics.gravity = new Vector3(0f, 0f, 0f);





        }
    }
}