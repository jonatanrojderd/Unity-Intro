using UnityEngine;

namespace Intro.Pong
{
    public class Ball : MonoBehaviour
    {
        public float Speed = 2f;
        
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
        }

        private void FixedUpdate()
        {
            _rigidbody.position += Vector2.right * (Speed * Time.fixedDeltaTime);
        }
    }
}
