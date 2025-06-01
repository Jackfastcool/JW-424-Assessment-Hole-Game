using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{

    // Unity serialised Variables
    [SerializeField] float movementSpeed;
    [SerializeField] Rigidbody rigidbody1;

    // Script only variables
    Vector2 moveVal;
    float moveHor;
    float moveVert;

    // Update is called once per frame
    void Update()
    {
        rigidbody1.velocity = new Vector3(moveVert * -1, 0, moveHor) * movementSpeed;
    }


    void OnMove(InputValue val)
    {
        moveVal = val.Get<Vector2>();
        moveHor = moveVal.x;
        moveVert = moveVal.y;
    }
}
