using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Button1")
        {
            Physics.gravity = new Vector3(0f, 0f, 0f);
        }

        if (collider.gameObject.tag == "Button2")
        {
            Physics.gravity = new Vector3(0f, -1.62f, 0f);
        }

        if (collider.gameObject.tag == "Button3")
        {
            Physics.gravity = new Vector3(0f, -9.81f, 0f);
        }
    }
}