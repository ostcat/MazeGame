using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Exit _exit;

    private string _winMessage = "�� ��������, �����������!";

    private void Update()
    {
        if (_exit.IsExitFounded == true)
        {
            Debug.Log(_winMessage);
            _ball.StopBall();
        }
    }
}
