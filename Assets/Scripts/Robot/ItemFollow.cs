using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject Target;
    
    public Vector3 offset_aux = new Vector3(0, 0, 0);
    private Vector3 Direction;
    private Vector3 Dist_min = new Vector3(1, 1, 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Target = collision.gameObject;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            Direction = Target.transform.position - transform.position;
            if ( Vector3.Distance(Target.transform.position, this.transform.position) > 1.50f || Vector3.Distance(Target.transform.position, this.transform.position) > 1.51f)
            {

                transform.Translate(Direction * 1);
                transform.position = Target.transform.position + offset_aux;

            }
        }
        else
        {
            
        }


    }

}
