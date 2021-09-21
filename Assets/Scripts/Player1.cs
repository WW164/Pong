using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    private Rigidbody2D RB;
    public float speed = 10.4f;
    GameObject The_Ball;
    void Start()
    {

        RB = GetComponent<Rigidbody2D>();
        The_Ball = GameObject.FindGameObjectWithTag("Ball");
    }

    void Update()
    {

        var Player1Velocity = RB.velocity;

        float distance = The_Ball.transform.position.y - transform.position.y;

        if (distance > 0)
            Player1Velocity.y = speed;

        else if (distance < 0)
            Player1Velocity.y = -speed;

        else
            Player1Velocity.y = 0;

        RB.velocity = Player1Velocity;
       

        var pos = transform.position;

        if (pos.y > 4)
            pos.y = 4;

        else if (pos.y < -4)
            pos.y = -4;

        transform.position = pos; 


    }
}
