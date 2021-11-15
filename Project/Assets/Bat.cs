using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public int damage = 20;
    public GameObject deathEffect;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag != "Player")
        {
            EnemyHealthManager enemy = hitInfo.GetComponent<EnemyHealthManager>();

            Debug.Log("Hello World");


            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
