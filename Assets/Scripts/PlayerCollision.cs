using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMoviment moviment;
    public GameManager gameManager;
    public Text scoreText;

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag == "obstacle")
        {
            moviment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
