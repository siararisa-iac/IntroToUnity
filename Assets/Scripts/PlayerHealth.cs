using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    [SerializeField]
    private Image[] healthIcons;

    protected override void UpdateHealthbar(int healthValue)
    {
        for (int i = 0; i < healthIcons.Length; i++)
        {
            if(i < healthValue)
            {
                healthIcons[i].enabled = true;
            }
            else
            {
                healthIcons[i].enabled = false;
            }
        }
    }

    protected override void OnDeath()
    {
        ScoreManager.Instance.SetWinState(false);
        base.OnDeath();
    }
}
