using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectDetectionSystem : MonoBehaviour
{
    // Detects whether an object has entered the collider and activates a script in that object.
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ObjectPointsScript>().DetectionBoxActivated();
        other.GetComponent<ObjectDeletionSystem>().Destroy(15);
    }
}
