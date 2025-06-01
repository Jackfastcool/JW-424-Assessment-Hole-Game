using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysicsController : MonoBehaviour
{
    // Unity Serialized variables
    [SerializeField] float baseInactiveDistance;
    
    // Script only variables
    GameObject hole;
    Rigidbody body;

    // Gets the target object, and finds this object's rigidbody.
    private void Awake()
    {
        hole = GameObject.Find("Hole in floor main object");
        body = gameObject.GetComponent<Rigidbody>();
    }

    // Finds the distance between this object and the hole, if it's greater than a value multiplied by the local scale
    // then all constraints are activated.
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, hole.transform.position) < baseInactiveDistance * transform.localScale.x)
        {
            body.constraints = RigidbodyConstraints.None;
        }
        else
        {
            body.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
