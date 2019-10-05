using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
public class RobotMovement : MonoBehaviour
{
    //Vitesse initial du robot, 
    public float speed;
    public float speedMulti = 1;
    public float slerpTime;
    public float slerpMulti = 1;

    private bool Followed = false;   // savoir si le pplayer est suivie

    //Contien les deux axes du joueur, est modifier par le script InputPlayer
    [HideInInspector]public Vector2 input;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = input * (speed * speedMulti);     // Applique le multiplicateur de vitesse au robot

        if(input != Vector2.zero)
        {
            float angle = Mathf.Atan2(input.normalized.y, input.normalized.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), slerpTime * slerpMulti);
        }

    }
    
    public bool followed
    {
        get { return Followed; }
        set { Followed = value; }
    }


}
