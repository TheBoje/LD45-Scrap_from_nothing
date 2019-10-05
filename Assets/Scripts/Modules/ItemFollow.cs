using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject Target; // ciblage du Player que l'item doit suivre 
    public bool Followed = false;// savoir si le pplayer est suivie
    
    private Vector3 Direction;// direction que suis L'item

    private void OnTriggerEnter2D(Collider2D collision) // test sur la natur de l'bojet et si il est un player alors Target le prend comme objet
    {
        if (Target == null && !collision.GetComponent<RobotMovement>().followed)
        {
            if (collision.tag == "Player")
            {
                Target = collision.gameObject;
                collision.GetComponent<RobotMovement>().followed = true;
            }
        }
        
    }

    [SerializeField]private float distMax = 1.25f; // distance entre le Player et L'item
    [SerializeField] private float Speed = 2.5f; // vitesse a la quelle l'titem suis le joueur



    void Update()
    {
        if (Target != null)// attente que un cible soit prise par un objet ( l'bojet resteras en place)
        {
            Direction = Target.transform.position - transform.position; //calcul de la direction 
            if ( Vector3.Distance(Target.transform.position, transform.position) > distMax) //test  de la distance entre l'objet et l'item
            {

                transform.Translate(Direction * Time.deltaTime * Speed ); //deplacement de l'objet en fonction de la direction du temp et de la vitesse

            }
        }


    }

}
