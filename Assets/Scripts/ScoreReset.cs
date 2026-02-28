using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    public void ResetScore()
    {
        ScoreManager.Instance.ResetScore();
    }
}
