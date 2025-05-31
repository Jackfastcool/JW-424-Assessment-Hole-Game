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

    //Unity Serialized variables
    [SerializeField] float scaleTime;

    private void Awake()
    {
        currentScale = transform.localScale;
    }

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

    public void SmoothAddValueToScale(float value)
    {
        newScale = new Vector3(currentScale.x + value, currentScale.y, currentScale.z + value);
        StartScaling = true;
    }
}
