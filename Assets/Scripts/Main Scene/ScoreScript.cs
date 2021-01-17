using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        AiScore,PlayerScore
    }
    public int MaxScore;
    public UiManager uiManager;
    #region Scores
    private int aiScore, playerScore;
    private int AiScore
    {
        get { return aiScore; }
        set
        {
            aiScore = value;
            if(value == MaxScore)
            {
                uiManager.ShowRestartCanvas(true);
            }
        }
    }
    private int PlayerScore
    {
        get { return playerScore; }
        set
        {
            playerScore = value;
            if (value == MaxScore)
            {
                uiManager.ShowRestartCanvas(false);
            }
        }
    }
    #endregion
    public Text AiScoretxt, PlayerScoretxt;
    private int aiscore, playerscore;
    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoretxt.text = (++AiScore).ToString();
        else
            PlayerScoretxt.text = (++PlayerScore).ToString();
    }
    public void ResetScores()
    {
        AiScore = PlayerScore = 0;
        AiScoretxt.text = PlayerScoretxt.text = "0";
    }
}
