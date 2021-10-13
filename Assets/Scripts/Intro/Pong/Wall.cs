using UnityEngine;
using UnityEngine.Events;

namespace Intro.Pong
{
    public class Wall : MonoBehaviour
    {
        public BoxCollider2D Collider;

        [SerializeField]
        private UnityEvent _goalEvent;
        
        private void Start()
        {
            if (!Collider)
            {
                Collider = GetComponent<BoxCollider2D>();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Ball"))
            {
                _goalEvent.Invoke();
            }
        }
    }
}
