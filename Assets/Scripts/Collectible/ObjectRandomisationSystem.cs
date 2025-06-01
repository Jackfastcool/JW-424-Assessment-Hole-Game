using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRandomisationSysttem : MonoBehaviour
{
    // Unity serialized variables
    [SerializeField] float scaledPointsModifier;

    // Script only variables
    float randomValuePositionX, randomValuePositionZ;
    float randomValueScale;

    private void Awake()
    {
        randomValuePositionX = Random.Range(-100f, 100f);
        randomValuePositionZ = Random.Range(-100f, 100f);
        randomValueScale = Random.Range(1f, 15f);

        gameObject.transform.localScale = new Vector3(randomValueScale, randomValueScale, randomValueScale);
        gameObject.transform.position = new Vector3(randomValuePositionX, randomValueScale / 2, randomValuePositionZ);

        gameObject.GetComponent<ObjectPointsScript>().SetPointsWorth(randomValueScale * randomValueScale * scaledPointsModifier);
    }

}
