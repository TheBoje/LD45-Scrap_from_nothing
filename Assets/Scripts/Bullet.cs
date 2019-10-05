using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float portee;
    public TypeArme type;

    private void Update()
    {
        portee--;
        if(portee <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform != transform.parent)
        {
            Destroy(this.gameObject);
        }
    }
}
