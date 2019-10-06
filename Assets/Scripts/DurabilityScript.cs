using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurabilityScript : MonoBehaviour
{
    public float durabilité;
    private float durabilitéMax;

    private Module mod;

    private void Awake()
    {
        mod = GetComponent<Module>();
        durabilitéMax = durabilité;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!mod.equiped)
            return;
        if(collision.tag == "Bullet" && collision.GetComponent<Bullet>().owner != gameObject)
        {
            durabilité -= collision.GetComponent<Bullet>().damage;
            if(durabilité <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
