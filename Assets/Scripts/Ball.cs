using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_rigidbody.IsSleeping())
        {
            _rigidbody.WakeUp();
        }
    }

    public void StopBall()
    {
        _rigidbody.isKinematic = true;
    }
}