using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementType { multiDir,rotaBased,mouseBased};

[RequireComponent(typeof(Rigidbody2D))]
public class RobotMovement : MonoBehaviour
{
    public const float speed = 4;
    public float acceleration = 0;

    private MovementType moveT = MovementType.multiDir;

    private Vector2 input;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //input = new Vector2(input.Get)
        if(moveT == MovementType.multiDir)
        {
            
        }
        else if(moveT == MovementType.rotaBased)
        {

        }
        else if(moveT == MovementType.mouseBased)
        {

        }
    }
}
