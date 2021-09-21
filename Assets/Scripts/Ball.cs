using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D RB;
    void Start()
    {

        RB = GetComponent<Rigidbody2D>();

        GoBall();

    }

    void GoBall()
    {
        float rand = Random.Range(0, 2);

        if (rand < 1)
        {
            RB.AddForce(new Vector2(20, -15));
        }
        else
        {
            RB.AddForce(new Vector2(-20, -15));
        }
    }

    void ResetBall()
    {
        RB.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        RB.velocity *= 1.1f;
    }

}