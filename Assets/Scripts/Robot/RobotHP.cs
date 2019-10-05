using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHP : MonoBehaviour
{
    public float health;
    public float initHeal;
    public float resistance;

    private void Awake()
    {
        mod = GetComponent<Module>();

        initHeal = GetComponent<RobotStats>().vie;
        health = initHeal ; // defition de la vie par la vie de base plus varleur armur qui s'ajoute 
    }

    public void Healt_edit(float amount)
    {
        health = health + amount ; // defition de la vie par la vie de base plus varleur armur qui s'ajoute
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            health -= collision.GetComponent<Bullet>().damage * 1/resistance;
            if (health <= 0.0f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
