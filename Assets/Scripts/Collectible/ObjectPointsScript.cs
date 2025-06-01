using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPointsScript : MonoBehaviour
{
    // Unity serialized variables
    [SerializeField] float points;

    // Script only variables
    GameObject holeInFloorGO;

    // Finds the target object.
    void Awake()
    {
        holeInFloorGO = GameObject.Find("Hole in floor main object");
    }

    // Refrenced from ObjectDetectionSystem, adds points onto the player's total.
    public void DetectionBoxActivated()
    {
        holeInFloorGO.GetComponent<PlayerPointsSystem>().AddPoints(Mathf.RoundToInt(points));
    }

    // Referenced from ObjectRandomisationSystem, sets the points worth of the object.
    public void SetPointsWorth(float newPoints)
    {
        points = newPoints;
    }
}
