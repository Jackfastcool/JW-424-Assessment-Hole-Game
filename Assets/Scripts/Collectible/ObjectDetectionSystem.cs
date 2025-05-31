using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectDetectionSystem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ObjectPointsScript>().DetectionBoxActivated();
        other.GetComponent<ObjectDeletionSystem>().Destroy();
    }
}
