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
    [SerializeField] bool speedScalesWithScale;

    // Script only variables
    Vector2 moveVal;
    Vector3 moveHor;
    Vector3 moveVert;
    Vector3 finalMove;
    float rotateValue;

    private void Update()
    {
        rigidbody1.velocity = finalMove;
    }

    void OnMove(InputValue val)
    {
        if (!speedScalesWithScale)
        {
            moveVal = val.Get<Vector2>();
            moveHor = moveVal.x * transform.forward;
            moveVert = moveVal.y * transform.right * -1;
            finalMove = (moveVert + moveHor) * movementSpeed;
        }
        else
        {
            moveVal = val.Get<Vector2>();
            moveHor = moveVal.x * transform.forward;
            moveVert = moveVal.y * transform.right * -1;
            finalMove = (moveVert + moveHor) * movementSpeed * (transform.localScale.x / 20);
        }
    }

    void OnRotate(InputValue val)
    {
        rotateValue = val.Get<float>();
        rigidbody1.angularVelocity = new Vector3(0, rotateValue * rotationSpeed, 0);

    }
}
