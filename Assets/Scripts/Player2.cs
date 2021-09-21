using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    private Rigidbody2D RB;
    public float speed = 10.4f;

    void Start()
    {

        RB = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        var Player2_Velocity = RB.velocity;

        if (Input.GetKey(KeyCode.W))
            Player2_Velocity.y = speed;

        else if (Input.GetKey(KeyCode.S))
            Player2_Velocity.y = -speed;

        else
            Player2_Velocity.y = 0;

        RB.velocity = Player2_Velocity;

        var pos = transform.position;

        if (pos.y > 4)
            pos.y = 4;

        else if (pos.y < -4)
            pos.y = -4;

        transform.position = pos;

    }
}
