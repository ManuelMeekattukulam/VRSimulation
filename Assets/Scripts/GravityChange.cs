using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Button")
        {
            Physics.gravity = new Vector3(0f, 0f, 0f);
        }
    }
}