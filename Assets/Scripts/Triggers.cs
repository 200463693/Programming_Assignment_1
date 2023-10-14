using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    float initialSpeed;
    PlayerMovement player;

    private void Start()
    {
        player = GetComponent<PlayerMovement>();
        initialSpeed = player.speed;
    }

    // Runs once on-enter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ColliderTag tag = collision.GetComponent<ColliderTag>();
        if (tag != null)
        {
            if (tag.type == ColliderTag.Type.SPEED_UP)
            {
                player.speed *= 2.0f;
            }

            else if (tag.type == ColliderTag.Type.SPEED_DOWN)
            {
                player.speed /= 2.0f;
            }
        }
    }

    // Runs once on-exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.speed = initialSpeed;
    }
}
