using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTracker : MonoBehaviour
{
    [SerializeField]
    private Transform enemyContainer;

    private void Update()
    {
        if (enemyContainer == null)
        {
            return;
        }
        // Check if the child count of the container is 0
        if(enemyContainer.transform.childCount == 0)
        {
            ScoreManager.Instance.SetWinState(true);
        }
    }
}
