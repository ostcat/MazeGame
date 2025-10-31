using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _offsetY;
    [SerializeField] private float _offsetZ;

    private void LateUpdate()
    {
        Vector3 offset = new Vector3(0, _offsetY, _offsetZ);

        transform.position = _target.position + offset;
    }
}