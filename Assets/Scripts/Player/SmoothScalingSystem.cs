using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothScalingSystem : MonoBehaviour
{
    //Script only variables
    bool StartScaling = false;
    Vector3 currentScale ;
    Vector3 newScale;
    float scaleDeltaTime;

    private void Awake()
    {
        currentScale = transform.localScale;
    }

    // If start scaling is true, and the scaleDeltaTime is more than 1, it gets reset to zero and StartScaling is set to false.
    // currentScale is updated to match the previous newScale.
    // Uses Mathf.Lerp and a Delta Time Counter to scale smoothly the hole to the new level.
    private void Update()
    {
        if (StartScaling)
        {
            if (scaleDeltaTime >= 1)
            {
                scaleDeltaTime = 0;
                StartScaling = false;
                currentScale = newScale;                
            }
            else
            {
                scaleDeltaTime += Time.deltaTime;
                transform.localScale = new Vector3(Mathf.Lerp(currentScale.x, newScale.x, scaleDeltaTime), currentScale.y, Mathf.Lerp(currentScale.z, newScale.z, scaleDeltaTime));
            }
        }
    }

    // Referenced from PlayerPointsSystem, activates the above code and sets newScale.
    public void SmoothAddValueToScale(float value)
    {
        newScale = new Vector3(currentScale.x + value, currentScale.y, currentScale.z + value);
        StartScaling = true;
    }
}
