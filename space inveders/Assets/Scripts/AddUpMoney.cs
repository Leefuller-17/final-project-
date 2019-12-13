using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace store_value_in_array
{

    class AddUpMoney : MonoBehaviour
    {
        Currency currency;
        int score;
        void Start()
        {
            //get the value from playe prefs
            score = PlayerPrefs.GetInt("Score", 0);
            GetComponent<Text>().text = score.ToString();

        }
    }
}