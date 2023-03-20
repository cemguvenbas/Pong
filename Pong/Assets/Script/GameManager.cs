using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;

    public void OnClick_StartButton()
    {
        _canvas.enabled = false;
        BallController.Instance.OnStart();
    }
}
