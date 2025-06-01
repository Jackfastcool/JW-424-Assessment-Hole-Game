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

    private void Awake()
    {
        hole = GameObject.Find("Hole in floor main object");
        body = gameObject.GetComponent<Rigidbody>();
    }

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
