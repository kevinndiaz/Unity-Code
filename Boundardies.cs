using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Boundardies : MonoBehaviour
{ 
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.4f, 8.4f), 
                                         Mathf.Clamp(transform.position.y, -100f, 100f),
                                         transform.position.z);
    }
}
