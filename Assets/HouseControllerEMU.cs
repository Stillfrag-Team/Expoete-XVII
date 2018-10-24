using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseControllerEMU : MonoBehaviour {

    public Color normalColor;
    public Color triggeredColor;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            gameObject.GetComponent<Image>().color = triggeredColor;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            gameObject.GetComponent<Image>().color = normalColor;
        }
    }
}
