using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    [SerializeField]
    private Transform boxPrefab;
    [SerializeField]
    private Transform spawnPoint;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Button")
        {
            Transform spawnPosition = Instantiate(boxPrefab);
            spawnPosition.position = spawnPoint.position;
        }
    }
}