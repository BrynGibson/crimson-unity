using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator myAnim;
    public Transform target;

    public Transform homePos;

    [SerializeField]
    private float speed= 0f;

    [SerializeField]
    private float maxRange =0f;

    [SerializeField]
    private float minRange=0f;

    void Start()
    {
        myAnim = GetComponent<Animator>();

        // target = FindObjectOfType<PlayerController>().transform;
        // Debug.Log(target.position);

    }

    // Update is called once per frame
    void LateUpdate()
    {
       // Debug.Log(Vector3.Distance(target.position, transform.position));

        if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange)
        {
           
            FollowPlayer();
        }
        else if (Vector3.Distance(target.position, transform.position) >= maxRange)
        {
            GoHome();
        }
        
    }

    public void FollowPlayer()
    {
        myAnim.SetBool("isMoving", true);

        myAnim.SetFloat("MoveX", (target.position.x - transform.position.x));
        myAnim.SetFloat("MoveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
      

    }

    public void GoHome()
    {

        myAnim.SetFloat("MoveX", (homePos.position.x - transform.position.x));
        myAnim.SetFloat("MoveY", (homePos.position.y - transform.position.y));
        Vector3 pos = Vector3.MoveTowards(transform.position, homePos.transform.position, (speed*15) * Time.deltaTime);
        pos.z = 0;
        transform.position = pos;

        if (Vector3.Distance(transform.position, homePos.position) == 0)
        {
            myAnim.SetBool("isMoving", false);
        }
        else
        {
            myAnim.SetBool("isMoving", true);
        }
    }
}
