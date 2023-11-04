using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int hearts = 0;
    private bool hasWon = false; 
    public int winningScore = 6;
    public ExitTrigger exitTrigger; 
    public DoorController doorController;
  


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasWon)
        {
            scoreText.text = "Hjärtan: " + hearts.ToString();

            if (hearts >= winningScore)
            {
                doorController.HandleWin(); 
            }
        }
    }

    public void AddHearts()
    {
        if (!hasWon)
        {
            hearts++;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Hjärtan: " + hearts.ToString();
    }

    void UpdateTotalScoreText()
    { 
        scoreText.text = " / " + winningScore.ToString();
    }

   
    public void PlayerWins()
    {
        if (!hasWon && exitTrigger.IsPlayerInside())
        {

            hasWon = true;
            doorController.HandleWin();
            
           
        }
    }


}
