using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollow : MonoBehaviour
{
    
    public GameObject Target;          // Ciblage du Player que l'item doit suivre 
    public bool Followed = false;       // Savoir si le player est suivie
    
    
    private Vector3 Direction;          // Direction que suis l'item

    private void OnTriggerEnter2D(Collider2D collision)     // Test sur la natur de l'bojet et si il est un player alors Target le prend comme objet
    {
        if (collision.tag == "Player" && !collision.GetComponent<RobotMovement>().followed)
        {
                if(Target)
                { 
                    Target.GetComponent<RobotMovement>().followed = false;
                }
                Target = collision.gameObject;
                collision.GetComponent<RobotMovement>().followed = true;
        }
        
    }

    [SerializeField]private float distMax;           // Distance entre le Player et L'item
    [SerializeField]private float Speed;             // Vitesse à la quelle l'item suis le joueur



    private void FixedUpdate()
    {
        if (Target != null)                                                                         // Attente que un cible soit prise par un objet ( l'bojet resteras en place)
        {
            Direction = Target.transform.position - transform.position;
            Debug.DrawRay(transform.position, Direction);
            // Calcul de la direction 
            if ( Vector3.Distance(Target.transform.position, transform.position) > distMax)
            {
                //transform.Translate(Direction * Time.deltaTime * Speed );                           // Deplacement de l'objet en fonction de la direction du temp et de la vitesse
                transform.position = Vector3.Slerp(transform.position, Target.transform.position, Time.deltaTime * Speed);
            }
        }


    }

}
