using System.Collections;
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

        public TMP_Text CountdownText;
        
        [SerializeField]
        private Ball _ball;

        [Range(1, 3)]
        [SerializeField]
        private int _numberOfSeconds;
        
        private WaitForSeconds _timeToWait;
        
        private void Start()
        {
            Player1ScoreUI.text = Player1Score.ToString();
            Player2ScoreUI.text = Player2Score.ToString();

            _timeToWait = new WaitForSeconds(1);
            CountdownText.text = _numberOfSeconds.ToString();
            StartCoroutine(Run());
        }

        private IEnumerator Run()
        {
            print("Run before");
            _ball.ResetPosition();

            for (int i = _numberOfSeconds; i > 0; i--)
            {
                CountdownText.text = i.ToString();
                yield return _timeToWait;
            }
            
            CountdownText.gameObject.SetActive(false);
            _ball.AddForceInRandomDirection();
            print("Run after");
        }

        public void Player1Scored()
        {
            Player1Score++;
            Player1ScoreUI.text = Player1Score.ToString();
            
            _ball.ResetPosition();
            _ball.AddForceInRandomDirection();
        }

        public void Player2Scored()
        {
            Player2Score++;
            Player2ScoreUI.text = Player2Score.ToString();
            
            _ball.ResetPosition();
            _ball.AddForceInRandomDirection();
        }
    }
}