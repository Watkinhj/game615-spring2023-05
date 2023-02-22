using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    //public Material warningText;
    //public FirstPersonController pc; //ui must see the player controller to display the score
    //public TextMeshProUGUI scoreDisplay, winDisplay;
    [SerializeField] Text scoreDisplay;
    [SerializeField] Text winDisplay;
    //public TextMeshProUGUI timerDisplay;
    [SerializeField] Text timerDisplay;

    private float timer = 0f; 
    public float timerDuration = 120f; //setting the time
    public int coinCount = 0;
    int coins;

    void Start()
    {
        timer = timerDuration;

        //scoreDisplay.text = "";
        //timerDisplay = "";
        //winDisplay.text = "";
        
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;
        timerDisplay.text = timer.ToString ("0");

        coins = GameObject.FindGameObjectsWithTag("coin").Length;

        //if (timer <= 25)
        //{
        if (timer <= 0)
            {
                timer = 0;
                winDisplay.text = "Time's Up! Game Over";
            }
        //}

        if (GameObject.FindGameObjectsWithTag("coin").Length <= 0)
        {
            winDisplay.text = "You found all the coins! You win!";
        }

        scoreDisplay.text = "Coins Left: " + coins; //+ pc.score;
    }
}
