using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text scoretext;
    int score = 0;
    int count = 0;

   // public GameObject ball;
    public Vector2 respawnPoint;

    private void Start()
    {
      //  respawnPoint = transform.position;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="collide")
        {
            score++;
            scoretext.text = score.ToString();

        }

        if(other.tag =="gameover")
        {
            count++;
            ReStart();
           // transform.position = respawnPoint;
            /* if(count == 3)
             {
                 ReStart();
             }*/
            // Swaping();
        }

        void ReStart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    
}
