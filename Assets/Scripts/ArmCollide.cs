using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "mannequin_body") {
            Debug.Log("collison");
        } 

    }
}