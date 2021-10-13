using UnityEngine;

namespace Intro.Pong
{
    /* TODO:
     * Players / Paddles
     * Ball
     * Scores
     */
    public class Paddle : MonoBehaviour
    {
        public float Speed = Mathf.PI;
        public BoxCollider2D Collider;

        public KeyCode UpKey;
        public KeyCode DownKey;
        
        [SerializeField]
        private float _verticalDirection;

        [SerializeField]
        private Rigidbody2D _rigidbody;
      
        private void Start()
        {
            if (_rigidbody == false)
            {
                _rigidbody = GetComponent<Rigidbody2D>();
            }

            if (Collider == false)
            {
                Collider = GetComponent<BoxCollider2D>();
            }
        }

        private void Update()
        {
            if (Input.GetKey(UpKey))
            {
                _verticalDirection = 1;
            }
            else if (Input.GetKey(DownKey))
            {
                _verticalDirection = -1;
            }
            else
            {
                _verticalDirection = 0;
            }
        }

        private void FixedUpdate()
        {
            _rigidbody.position += new Vector2(0, _verticalDirection) * (Speed * Time.fixedDeltaTime);
        }
    }
}