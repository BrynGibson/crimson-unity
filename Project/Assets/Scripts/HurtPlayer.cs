using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private float waitToLoad = 2f;
    private bool reloading;

    private HealthManager healthMan;
    public float waitToHurt = 1f;
    public bool isTouching;

    [SerializeField]
    private int damageToGive = 10;



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
                healthMan.HurtPlayer(damageToGive);
                waitToHurt = 1f;
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthManager>().HurtPlayer(damageToGive);
        }
    }
    private void OnCollisionStay2D(Collision2D other)
        {
            if (other.collider.tag =="Player")
            {
                isTouching = true;
            }

        
        }

            private void OnCollisionExit2D(Collision2D other)
        {
            if (other.collider.tag == "Player")
            {
                isTouching = false;
            waitToHurt = 2f;
            }
        }



    }



