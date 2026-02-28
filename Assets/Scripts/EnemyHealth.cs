using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : Health
{
    [SerializeField]
    private Image healthBar;

    [SerializeField]
    private int deathPoints = 100;

    protected override void UpdateHealthbar(int healthValue)
    {
        // Safety check - This avoids null reference error. 
        if (healthBar == null)
        {
            return;
        }
        // Since fillAmount is a normalized value of 0-1, we make sure we assign a float
        healthBar.fillAmount = (float)healthValue / maxHealth;
    }

    protected override void OnDeath()
    {
        // This is where we will add points
        ScoreManager.Instance.AddScore(deathPoints);
        base.OnDeath();
    }
}
