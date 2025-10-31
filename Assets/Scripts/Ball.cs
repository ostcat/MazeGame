using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void StopBall()
    {
        _rigidbody.isKinematic = true;
    }
}
