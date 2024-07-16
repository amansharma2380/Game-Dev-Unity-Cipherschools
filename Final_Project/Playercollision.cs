using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("collided");
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
