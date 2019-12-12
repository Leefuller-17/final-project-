using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{

    public int Alien;
    GameObject currency;
    Currency script;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Alien")
        {
            IncreaseTextUICurrency();
        }
    }
void IncreaseTextUICurrency()
    {
        var currecnyObject = GameObject.Find("Currency");
        var textUIComp = currecnyObject.GetComponent<Text>();

        int currency = int.Parse(textUIComp.text);

        currency += 1;

        textUIComp.text = currency.ToString();
    }
}