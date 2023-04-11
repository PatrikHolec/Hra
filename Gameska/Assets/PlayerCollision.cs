using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public HealthBarScript healthBar;
    public GameOverScript GameOverScript;
    public PlayerMovement Movement;

    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        GameOverScript.Vypnout();  //  vypina gameover screen
        Movement.MovementEnable();  //zapina movement script
    }

    void Update()
    {
        if (currentHealth < 1)  //death
        {
            GameOverScript.Zapnout();  //zapne gameover screen
            Movement.MovementDisable(); //vypne movement script
        }
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage(13);
        }

    }

    
}
