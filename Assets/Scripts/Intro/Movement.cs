using System;
using UnityEngine;

namespace Intro
{
    public class Movement : MonoBehaviour
    {
        public float Speed = 6f;

        public Vector2 MovementDirection;
        
        [SerializeField]
        private Rigidbody2D _rigidbody;

        private void Start()
        {
            if (_rigidbody == false)
            {
                _rigidbody = GetComponent<Rigidbody2D>();
            }
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            MovementDirection = new Vector2(horizontal, vertical);
            print($"{horizontal}, {vertical}");
        }

        private void FixedUpdate()
        {
            _rigidbody.position += MovementDirection * (Speed * Time.fixedDeltaTime);
        }
    }
}