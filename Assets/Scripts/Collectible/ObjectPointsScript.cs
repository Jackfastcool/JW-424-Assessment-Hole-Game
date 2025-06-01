using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPointsScript : MonoBehaviour
{
    // Unity serialized variables
    [SerializeField] float points;

    // Script only variables
    GameObject holeInFloorGO;

    void Awake()
    {
        holeInFloorGO = GameObject.Find("Hole in floor main object");
    }

    public void DetectionBoxActivated()
    {
        holeInFloorGO.GetComponent<PlayerPointsSystem>().AddPoints(Mathf.RoundToInt(points));
    }

    public void SetPointsWorth(float newPoints)
    {
        points = newPoints;
    }
}
