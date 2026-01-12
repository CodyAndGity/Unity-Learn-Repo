using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 10;
    [SerializeField] GameObject hitEffect;
    [SerializeField] GameObject destroyEffect;

    public float CurrentHealth { get; set; }

    private bool isDestroyed = false;
    void Start()
    {
        CurrentHealth = maxHealth;
    }


    public void OnDamage(float damage)
    {
        if (isDestroyed) return;
        CurrentHealth -= damage;

        if (CurrentHealth <= 0) isDestroyed = true;

        if (!isDestroyed && hitEffect != null)
        {
            Instantiate(hitEffect, transform.position, Quaternion.identity);
        }

        if (isDestroyed)
        {
            if (destroyEffect != null)
            {
                Instantiate(destroyEffect, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
