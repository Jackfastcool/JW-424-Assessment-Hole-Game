using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{

    // Serialised Variables
    [SerializeField] float movementSpeed;
    [SerializeField] bool scalesWithScale;
    [SerializeField] Rigidbody rigidbody1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody1.velocity = moveValV3 * movementSpeed;
    }

    Vector2 moveVal;
    Vector3 moveValV3;
    void OnMove(InputValue val)
    {
        moveVal = val.Get<Vector2>();
        moveValV3 = new Vector3(moveVal.y * -1, 0, moveVal.x);
    }
}
