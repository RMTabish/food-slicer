using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutter : MonoBehaviour
{
    Vector3 randomAngle;

    public GameObject Knife;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Slice" && Knife.GetComponent<knife>().isCutting)
        {
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            col.gameObject.GetComponent<Rigidbody>().AddTorque(-Vector3.up * 12000f, ForceMode.Impulse);
            randomAngle = new Vector3(Random.Range(-0.8f, -0.2f), Random.Range(0.2f, 0.3f), Random.Range(-2f, 2f));
            GameSystems.Systems.Level.onVegetableCut();

            col.gameObject.GetComponent<Rigidbody>().AddForce(randomAngle * Random.Range(650, 1500), ForceMode.Impulse);
            Knife.GetComponent<knife>().SETcut(true);
            Destroy(col.gameObject, 4f);
           // Destroy(col.gameObject.transform.parent.gameObject, 4f);

         }

    }
}
 