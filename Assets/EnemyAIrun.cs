using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIrun : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float maxDist = 10f;
    public float minDist = 5f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the player and the AI
        float distance = Vector3.Distance(transform.position, player.position);

        // If the player is too close, run away
        if (distance < minDist)
        {
            // Calculate the direction away from the player
            Vector3 dir = transform.position - player.position;

            // Normalize the direction
            dir.Normalize();

            // Move the AI in the direction away from the player
            transform.position += dir * moveSpeed * Time.deltaTime;
        }
        // If the player is too far away, stop running
        else if (distance > maxDist)
        {
            // Stop moving
            transform.position += Vector3.zero;
        }
    }
}

