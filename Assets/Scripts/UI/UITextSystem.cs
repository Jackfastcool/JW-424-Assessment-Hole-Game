using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextSystem : MonoBehaviour
{
    // Unity serialized variables
    [SerializeField] string staticText;

    // Referenced from PlayerPointsSystem, sets the text to a value in the HUD.
    public virtual void SetValue(string value)
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = staticText + value;
    }
}