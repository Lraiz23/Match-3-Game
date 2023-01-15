using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    private Board board;
    public TMP_Text scoreText;
    public int score;
    public Image scoreBar;  



    // Start is called before the first frame update
    void Start()
    {
        board = FindObjectOfType<Board>();
        UpdateBar();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        EndGame();
        
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        UpdateBar();
    }

    private void UpdateBar()
    {
        if (board != null && scoreBar != null)
        {

            int length = board.scoreGoals.Length;

            scoreBar.fillAmount = (float)score / (float)board.scoreGoals[length - 1];
        }
    }

    private void EndGame()
    {
        if (score == 500)
        {
            Debug.Log("Congratulations");
        }
    }
}
