using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
public class RobotMovement : MonoBehaviour
{
    //Vitesse initial du robot, 
    public float speed;
    public float slerpTime;
    public RobotStats robotStats;


    //Contien les deux axes du joueur, est modifier par le script InputPlayer
    [HideInInspector]public Vector2 input;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        robotStats = gameObject.GetComponent<RobotStats>();
        rb.velocity = input * (speed * robotStats.vitesse);     // Applique le multiplicateur de vitesse au robot

        if(input != Vector2.zero)
        {
            float angle = Mathf.Atan2(input.normalized.y, input.normalized.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            // transform.rotation = Quaternion.Slerp(angle, Vector3.forward, (slerpTime * robotStats.rotationVitesse)); 
        }

    }
}
