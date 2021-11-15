using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAttack : MonoBehaviour
{

    public Transform firePoint;
    public GameObject batPrefab;

    public float speed = 20f;

    Vector2 lookDirection;
    float lookAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - firePoint.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);
        if (Input.GetButtonDown("Fire1"))
        {
            shootBat();
        }
    }

    void shootBat()
    {

        GameObject batClone = Instantiate(batPrefab, firePoint.position, firePoint.rotation);
        batClone.transform.position = firePoint.position;
        batClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        batClone.GetComponent<Rigidbody2D>().velocity = firePoint.right * speed;
      
    }
}
