using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerEMU : MonoBehaviour {
    bool pressed;
    Vector2 mousePos;

    void Update()
    {
        if (pressed)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x, mousePos.y);
        }
    }
    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pressed = !pressed;
        }
    }
}
