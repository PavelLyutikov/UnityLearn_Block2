using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShape : Shape
{

    private string color = "Green";

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
