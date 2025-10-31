using UnityEngine;

public class Rotator : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [SerializeField] private float _rotationForce = 10f;

    private float _xInput;
    private float _yInput;

    private void Update()
    {
        _xInput = Input.GetAxisRaw(HorizontalAxis);
        _yInput = Input.GetAxisRaw(VerticalAxis);

        transform.Rotate(Vector3.right, _yInput * _rotationForce, Space.World);
        transform.Rotate(Vector3.back, _xInput * _rotationForce, Space.World);
    }
}