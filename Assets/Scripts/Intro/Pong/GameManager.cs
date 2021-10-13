using System;
using Final.Snake;
using TMPro;
using UnityEngine;

// You don't really need this.
namespace Intro.Pong
{
    public class GameManager : MonoBehaviour
    {
        public int Player1Score;
        public int Player2Score;

        public TMP_Text Player1ScoreUI;
        public TMP_Text Player2ScoreUI;

        [SerializeField]
        private Ball _ball;

        private void Start()
        {
            Player1ScoreUI.text = Player1Score.ToString();
            Player2ScoreUI.text = Player2Score.ToString();
        }

        public void Player1Scored()
        {
            Player1Score++;
            Player1ScoreUI.text = Player1Score.ToString();
            
            _ball.ResetPosition();
            _ball.AddForce();
        }

        public void Player2Scored()
        {
            Player2Score++;
            Player2ScoreUI.text = Player2Score.ToString();
            
            _ball.ResetPosition();
            _ball.AddForce();
        }
    }
}