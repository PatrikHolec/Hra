using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public HealthBarScript healthBar;
    public GameOverScript GameOverScript;
    public PlayerMovement Movement;
    public GameObject pumpkin;
    public BackgroundTrigger trigger;
    public neco GameFinish;


    public Vector3 respawnPoint;
    bool CheckpointTrigger = false;
    
    
    

    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        GameFinish.GameFinishedVypnout();
        respawnPoint = transform.position;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        GameOverScript.Vypnout();  //  vypina gameover screen
        Movement.MovementEnable();  //zapina movement script

        //trigger.BackgroundON();
    }

    void Update()
    {
        if (currentHealth < 1)  //death
        {
            GameOverScript.Zapnout();  //zapne gameover screen
            Movement.MovementDisable(); //vypne movement script
        }
        if (currentHealth > 100)
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }
        
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    void Heal(int heal)
    {
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage(13);
        }
        if (collision.gameObject.CompareTag("ObstacleIK"))
        {
            TakeDamage(100);
        }
        if (collision.gameObject.CompareTag("HealPumpkin"))
        {
            Heal(25);
            pumpkin.SetActive(false);
        }

    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        GameOverScript.Vypnout();  //  vypina gameover screen
        Movement.MovementEnable();  //zapina movement script
        if (CheckpointTrigger == true)
        {
            currentHealth = 50;
            healthBar.SetHealth(currentHealth);
        }
        else
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            respawnPoint = transform.position;
            CheckpointTrigger = true;
        }

        if (collision.gameObject.CompareTag("GameFinish"))
        {
            GameFinish.GameFinishedZapnout();
            Movement.MovementDisable();

        }
    }


}
