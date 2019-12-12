using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddUpMoney : MonoBehaviour
{

    Currency script;

    public int addAmount;

    void Start()
    {
        script = GameObject.FindWithTag("Alien").GetComponent<Currency>();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Bullet")
        {
            script.Alien += addAmount;
            Destroy(gameObject);
        }
    }
}