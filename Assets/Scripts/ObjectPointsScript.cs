using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPointsScript : MonoBehaviour
{

    [SerializeField] float points;

    GameObject holeInFloorGO;

    // Start is called before the first frame update
    void Awake()
    {
        holeInFloorGO = GameObject.Find("Hole in floor main object");
    }

    public void DetectionBoxActivated()
    {
        holeInFloorGO.GetComponent<PlayerPointsSystem>().AddPoints(points);
        //print("DEBUG: Detection Stage 2");
    }
}
