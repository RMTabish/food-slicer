using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider collidedObject)
    {

        if (collidedObject.tag == "obstacle" || collidedObject.tag == "Slice")
        {
            Destroy(collidedObject.gameObject.transform.parent.gameObject);

        }
        
    }
}
