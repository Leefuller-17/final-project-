using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour
{

    public float speed = 30;


    public GameObject theBullet;
    private int remainingAliens;

    void FixedUpdate()
    {
        float horzMove = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove, 0) * speed;

    }

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(theBullet, transform.position, Quaternion.identity);
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.bulletFire);
        }

    }

}