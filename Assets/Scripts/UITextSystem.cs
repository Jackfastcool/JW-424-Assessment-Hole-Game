using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextSystem : MonoBehaviour
{
    [SerializeField] string staticText;
    public virtual void SetValue(string value)
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = staticText + value;
    }
}