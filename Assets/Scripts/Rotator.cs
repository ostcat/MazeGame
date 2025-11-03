using UnityEngine;

public class Rotator : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [SerializeField] private float _rotationSpeed = 50f;

    private Rigidbody _rigidbody;
    private float _xInput;
    private float _yInput;
    private float _xRotation;
    private float _yRotation;
    private Quaternion _targetRotation;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _targetRotation = transform.rotation;
    }

    private void Update()
    {
        _xInput = Input.GetAxisRaw(HorizontalAxis);
        _yInput = Input.GetAxisRaw(VerticalAxis);
    }

    private void FixedUpdate()
    {
        _xRotation = _xInput * _rotationSpeed * Time.fixedDeltaTime;
        _yRotation = _yInput * _rotationSpeed * Time.fixedDeltaTime;

        Quaternion rotationXQuat = Quaternion.Euler(0, 0, -_xRotation);
        Quaternion rotationYQuat = Quaternion.Euler(_yRotation, 0, 0);

        _targetRotation = rotationXQuat * rotationYQuat * _targetRotation;

        _rigidbody.MoveRotation(_targetRotation);

        //transform.Rotate(Vector3.back, _xInput * _rotationForce, Space.World);
    }
}