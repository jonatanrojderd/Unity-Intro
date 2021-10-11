using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public float Health = 100;

    private int _maxHealth = 200;

    [SerializeField]
    private string _name = "Jonte";

    // This happens first in the execution order.
    private void Awake()
    {
    }

    // This runs the first frame when the scene or the game object is loaded,
    // or a script is enabled.
    private void Start()
    {
    }

    // This runs every time a script is enabled.
    private void OnEnable()
    {
    }

    // This runs every time a script is disabled.
    private void OnDisable()
    {
    }

    // Update loop - runs every frame.
    private void Update()
    {
    }

    // FixedUpdate loop - runs at a fixed time step.
    private void FixedUpdate()
    {
    }

    // LateUpdate loop - runs every frame
    private void LateUpdate()
    {
    }
}