using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDeletionSystem : MonoBehaviour
{
    // Deletes the Cube if called
    public void Destroy(float time)
    {
        GameObject.Destroy(gameObject, time);
    }
}
