using UnityEngine;
using UnityEngine.UI;

// An abstract class is a class that is meant to be EXTENDED
// and it is NOT instantiated
public abstract class Health : MonoBehaviour // base class
{
    [SerializeField]
    protected int maxHealth = 3;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Bullet>(out Bullet bulletComponent))
        {
            UpdateHealth(-1);
            Destroy(bulletComponent.gameObject);
           
        }
    }

    private void UpdateHealth(int value)
    {
        currentHealth += value;
        UpdateHealthbar(currentHealth);
        if(currentHealth <= 0)
        {
            OnDeath();
        }
    }

    protected virtual void OnDeath()
    {
        Destroy(this.gameObject);
    }

    // A virtual function is basically an optional function that can have a specific
    // implementation in its child class
    //protected virtual void UpdateHealthbar(int healthValue)
    //{
    //}


    protected abstract void UpdateHealthbar(int value);
}
