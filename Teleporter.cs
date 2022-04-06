using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
        player.transform.Rotate(0, 180, 0);
    }
}
