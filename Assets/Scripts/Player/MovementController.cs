using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{

    // Unity serialised Variables
    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] Rigidbody rigidbody1;

    // Script only variables
    Vector2 moveVal;
    Vector3 moveHor;
    Vector3 moveVert;
    Vector3 finalMove;
    float rotateValue;

    void OnMove(InputValue val)
    {
        moveVal = val.Get<Vector2>();
        moveHor = moveVal.x * transform.forward * -1;
        moveVert = moveVal.y * transform.right;
        finalMove = (moveVert + moveHor) * movementSpeed;
        rigidbody1.velocity = finalMove;
    }

    void OnRotate(InputValue val)
    {
        rotateValue = val.Get<float>();
        rigidbody1.angularVelocity = new Vector3(0, rotateValue * rotationSpeed, 0);

    }
}
