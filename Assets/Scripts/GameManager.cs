using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        gameState = false;
    }
}
