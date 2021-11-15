using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int currentHealth;
    public int maxHealth;

    private bool flashActive;

    [SerializeField]
    private float flashLength = 0f;
    private float flashCounter = 0f;

    private SpriteRenderer playerSprite;

    void Start()
    {

        playerSprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (flashActive)

            
        {

            if (flashCounter >= flashLength * .99f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .82f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > flashLength * 0.66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * 0.49f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > flashLength * 0.33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * 0.16f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > 0)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive = false;
            }

            flashCounter -= Time.deltaTime;
        }
        
    }

    public void Bleed(int damageToGive)
    {
        currentHealth -= damageToGive;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);

            // Add game manager here
        }

    }

    public void HurtPlayer(int damageToGive)
    {
        currentHealth -= damageToGive;
        flashActive = true;

        flashCounter = flashLength;

        if (currentHealth <= 0)
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);

            // Add game manager here
        }

    }

    public void HealPlayer(int damageToGive)
    {
        currentHealth += damageToGive;
   

        if (currentHealth <= maxHealth)
        {
            currentHealth = maxHealth;

            // Add game manager here
        }

    }



}
