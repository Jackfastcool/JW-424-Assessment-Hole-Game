using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysicsController : MonoBehaviour
{
    //Script only variables
    GameObject hole;
    Rigidbody body;

    private void Awake()
    {
        hole = GameObject.Find("Hole in floor main object");
        body = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, hole.transform.position) < 30)
        {
            body.constraints = RigidbodyConstraints.None;
            print("unfrozen all constraints");
        }
        else
        {
            body.constraints = RigidbodyConstraints.FreezeAll;
            print("frozen all constraints");
        }
    }
}
