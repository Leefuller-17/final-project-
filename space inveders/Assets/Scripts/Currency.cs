using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public int currency;
    Text textUIComp;
    private void Start()
    {
        var currecnyObject = GameObject.Find("Currency");
        textUIComp = currecnyObject.GetComponent<Text>();
        currency = int.Parse(textUIComp.text);

    }

    public void IncreaseTextUICurrency()
    {

        currency += 1;
        textUIComp.text = currency.ToString();

        int score = PlayerPrefs.GetInt("Score");
        PlayerPrefs.SetInt("Score", 1 + score);
    }


}