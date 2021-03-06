using UnityEngine;

namespace Intro.Pong
{
    public class Ball : MonoBehaviour
    {
        public float Speed = 600f;

        [SerializeField]
        private Vector2 _direction;
        
        [SerializeField]
        private Vector2 _previousDirection;

        [SerializeField]
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private CircleCollider2D _collider;

        private Vector2 _initialPosition;

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

            _initialPosition = transform.position;
        }

        public void ResetPosition()
        {
            _previousDirection = _direction;
            
            _direction = Vector2.zero;
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.position = _initialPosition;
        }

        public void AddForceInRandomDirection()
        {
            int x = Random.Range(-1, 1);
            if (x == 0)
            {
                // TODO: Get another x value.
                x = 1;
            }
            
            float y = Random.Range(-0.5f, 0.5f);

            if (x == _previousDirection.x)
            {
                x = -x;
            }
            
            _direction = new Vector2(x, y);
            _rigidbody.AddForce(_direction * Speed);
        }
    }
}