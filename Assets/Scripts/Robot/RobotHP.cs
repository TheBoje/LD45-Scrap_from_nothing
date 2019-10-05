using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Health;
    private float Healthbase=100.0f;
    public float Armor_Add;
    private Module mod;

    private void Awake()
    {
        mod = GetComponent<Module>();


        Health = Healthbase ; // defition de la vie par la vie de base plus varleur armur qui s'ajoute 
    }

    public void Healt_edit()
    {
        Health = Health + Armor_Add ; // defition de la vie par la vie de base plus varleur armur qui s'ajoute
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!mod.equiped)
            return;
        if (collision.tag == "Bullet")
        {
            Health -= collision.GetComponent<Bullet>().damage;
            if (Health <= 0.0f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
