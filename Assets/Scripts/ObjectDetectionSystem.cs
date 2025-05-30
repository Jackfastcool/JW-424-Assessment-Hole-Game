using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetectionSystem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ObjectPointsScript>().DetectionBoxActivated();
        print("DEBUG: Detection Stage 1");
    }
}
