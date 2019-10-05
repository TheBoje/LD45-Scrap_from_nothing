using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject Target;
    
    private Vector3 Direction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Target = collision.gameObject;
        }
    }

    [SerializeField]private float distMax;

    void Update()
    {
        if (Target != null)
        {
            Direction = Target.transform.position - transform.position;
            if ( Vector3.Distance(Target.transform.position, transform.position) > distMax)
            {

                transform.Translate(Direction * Time.deltaTime);

            }
        }


    }

}
