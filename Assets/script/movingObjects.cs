using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObjects : MonoBehaviour
{
    public float speed;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(-Vector3.right * Time.deltaTime * GameSystems.Systems.Level.CurrentSpeed, Space.World);
        
    }
}
