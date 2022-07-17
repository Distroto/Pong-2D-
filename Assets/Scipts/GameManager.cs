using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    public TextMeshPro playerScoreText;
    public TextMeshPro computerScoreText;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public BallMovement ball;

    public void PlayerScores(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();        
    }

    public void ComputerScores(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();        
    }

    private void ResetRound(){
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.AddStartingForce();
    }
}
