﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlienBullet : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    public float speed = 30;
    public Sprite explodedShipImage;

    void Start()
    {

        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Vector2.down * speed;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Player")
        {
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.shipExplosion);

            col.GetComponent<SpriteRenderer>().sprite = explodedShipImage;

            Destroy(gameObject);

            DestroyObject(col.gameObject, 0.5f);
            SceneManager.LoadScene(2);

        }

        if (col.tag == "Shield")
        {
            Destroy(gameObject);
            DestroyObject(col.gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //public void Reset()
    //{
    //    if (explodedShipImage)
    //    {
         
          
    //    }

    //}
}