using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBlood : MonoBehaviour
{
    // Start is called before the first frame update

    private HealthManager healthMan;

    public int bleedRate;


    void Start()
    {
        healthMan = FindObjectOfType<HealthManager>();

        InvokeRepeating("Bleed", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Bleed()
    {
        healthMan.Bleed(bleedRate);
    }
}
