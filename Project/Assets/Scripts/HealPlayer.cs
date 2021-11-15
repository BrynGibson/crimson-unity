using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour

{
    private float waitToLoad = 2f;
    private bool reloading;

    private HealthManager healthMan;
    public float waitToHurt = 1f;
    public bool isTouching;

    [SerializeField]
    private int damageToGive = 10;

    public GameObject deathEffect;


    void Start()
    {
        healthMan = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        /*        if (reloading)
                {
                    waitToLoad -= Time.deltaTime;
                }

                if(waitToLoad <= 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }*/

        if (isTouching)
        {
            waitToHurt -= Time.deltaTime;

            if (waitToHurt <= 0)
            {
                healthMan.HealPlayer(damageToGive);
                waitToHurt = 1f;
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthManager>().HealPlayer(damageToGive);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            isTouching = true;
        }


    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            isTouching = false;
           
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}

