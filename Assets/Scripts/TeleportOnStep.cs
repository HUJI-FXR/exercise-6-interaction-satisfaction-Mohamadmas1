using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnStep : MonoBehaviour
{
    [SerializeField] private Transform teleportDestination; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            other.transform.position = teleportDestination.position;
        }
    }
}
