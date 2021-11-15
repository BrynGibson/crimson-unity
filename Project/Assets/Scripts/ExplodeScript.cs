using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour

    
{
    [SerializeField]
    private float destroyTime= 0.1f;
    // Start is called before the first frame update

 
    private void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
