using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthbar; 

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
