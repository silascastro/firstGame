using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().gameState)
            scoreText.text = player.position.z.ToString(); 
        else
            scoreText.text = "GAME OVER!";
    }
}
