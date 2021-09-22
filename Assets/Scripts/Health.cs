using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Healthbar healthbar;
    float maxHealth = 100f;
    public float currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoseHealth(float damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            healthbar.LoseHealth(damage);
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("ZombieDeadScene");
        }
    }

    public void GainHealth(float health)
    {
        if (currentHealth + health <= maxHealth)
        {
            currentHealth += health;
            healthbar.GainHealth(health);
        }
    }
}
