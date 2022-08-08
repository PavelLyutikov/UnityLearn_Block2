using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShape : Shape
{

    private string color = "Red";

    private void Start()
    {
        shapeColor = color;
    }

    private void OnMouseDown()
    {
        DisplayText(shapeColor);
    }

    public override void DisplayText(string text)
    {
        base.DisplayText(text);
    }
}
