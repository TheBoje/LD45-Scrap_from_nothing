using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RobotMovement : MonoBehaviour
{
    //Vitesse initial du robot, 
    public float speed;

    //Contien les deux axes du joueur, est modifier par le script InputPlayer
    [HideInInspector]public Vector2 input;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = input * speed;

        float angle = Mathf.Atan2(input.normalized.y, input.normalized.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
