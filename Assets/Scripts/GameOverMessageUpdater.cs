using TMPro;
using UnityEngine;

public class GameOverMessageUpdater : MonoBehaviour
{
    private void Start()
    {
        if(gameObject.TryGetComponent<TextMeshProUGUI>(out var text))
        {
            text.text = ScoreManager.Instance.DidWin ? "Congratulations" : "Try Again";
        }
    }
}
