using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool IsExitFounded { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ball ball) == false)
            return;

        IsExitFounded = true;
    }
}