using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDeletionSystem : MonoBehaviour
{
    public void Destroy()
    {
        GameObject.Destroy(gameObject);
    }
}
