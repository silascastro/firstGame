using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMoviment moviment;

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag == "obstacle")
        {
            moviment.enabled = false;
        }

    }

}
