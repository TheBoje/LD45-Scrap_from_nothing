using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHP : MonoBehaviour
{
    public float health;
    public float initHeal;
    public float resistance;

    public bool canGetHitted = false;

    private void Awake()
    {
        health = initHeal ; // defition de la vie par la vie de base plus varleur armur qui s'ajoute 
    }

    public void Healt_edit(float amount)
    {
        if (!canGetHitted)
        {
            return;
        }
        if (GameObject.Find("DjEffect"))
        {

            GameObject.Find("DjEffect").GetComponent<DJEffect>().Impact(transform.position);
        }
        health = health + amount ; // defition de la vie par la vie de base plus varleur armur qui s'ajoute
    }
    private void Update()
    {      
        if (health <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
    /*
    private void OnColliderEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");
            health -= collision.gameObject.GetComponent<Bullet>().damage * 1/resistance;
            if (health <= 0.0f)
            {
                Destroy(this.gameObject);
            }
        }
    }*/
}
