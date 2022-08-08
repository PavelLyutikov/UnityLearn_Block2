using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{

    [SerializeField] Text displayText;

    private string ShapeColor;
    public string shapeColor
    {
        get
        {
            return ShapeColor;
        }
        set
        {
            ShapeColor = value;
        }
    }

    public virtual void DisplayText(string text)
    {
        displayText.text = text;
    }


}
