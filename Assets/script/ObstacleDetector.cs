using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Knife;
    public Animator Animator;

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.down),out hit))
        {
            if (hit.collider.tag == "obstacle"&&Knife.GetComponent<knife>().isCutting)
            {
                Animator.SetBool("isHit", true);  

            }
        }
    }
}
