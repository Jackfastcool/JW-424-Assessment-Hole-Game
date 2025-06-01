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
    Renderer rend;

    // On awake, the cube is assigned a random location, random scale and relative points worth, and a random colour.
    private void Awake()
    {
        randomValuePositionX = Random.Range(-1000f, 1000f);
        randomValuePositionZ = Random.Range(-1000f, 1000f);
        randomValueScale = Random.Range(1f, 15f);

        gameObject.transform.localScale = new Vector3(randomValueScale, randomValueScale, randomValueScale);
        gameObject.transform.position = new Vector3(randomValuePositionX, randomValueScale / 2, randomValuePositionZ);

        gameObject.GetComponent<ObjectPointsScript>().SetPointsWorth(randomValueScale * randomValueScale * scaledPointsModifier);

        rend = GetComponent<Renderer>();
        rend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0f, 1f);
    }

}
