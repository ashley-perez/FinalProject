using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    private bool state = false;

    public void OnTriggerEnter (Collider other)
    {
        if (state) return;
        door.transform.position += new Vector3(0, 3, 0);
    }
}
