using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
   [SerializeField] GameObject gameOverObj;
     void gameOver()
    {      
        gameOverObj.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject == null)
            gameOver();
    }
}
