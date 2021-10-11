using UnityEngine;

namespace Intro.Pong
{
    public class Ball : MonoBehaviour
    {
        public float Speed = 2f;

        [SerializeField]
        private Vector2 _direction;
        
        [SerializeField]
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private CircleCollider2D _collider;

        private void Start()
        {
            if (_rigidbody == false)
            {
                _rigidbody = GetComponent<Rigidbody2D>();
            }

            if (_collider == false)
            {
                _collider = GetComponent<CircleCollider2D>();
            }

            _direction = Vector2.right;
        }

        private void FixedUpdate()
        {
            _rigidbody.position += _direction * (Speed * Time.fixedDeltaTime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Paddle"))
            {
                _direction = -_direction;
            }
        }
    }
}