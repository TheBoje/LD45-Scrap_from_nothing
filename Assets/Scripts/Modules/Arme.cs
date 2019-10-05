using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeArme { feu,laser,explosion,balistique}; //Les armes de corp à corp seront dans une autre classe

public class Arme : Module
{
    //Donnés d'équipement de l'arme
    public TypeArme type;
    public int damage;
    public float portee;
    public float vitesseProjectile;
    public float cadance;

    //Autres variables nécéssaires
    [SerializeField]private GameObject bullet;  
    private float currentTime; //Pour cadancer l'arme
    [SerializeField] private Transform canon;

    private void Start()
    {
        currentTime = Time.time;
    }

    //Fonction appelé par InputPlayer quand on apuis sur le bouton d'action 1,2 ou 3
    public override void Act()
    {
        base.Act();
        if (currentTime + cadance < Time.time)  //On ne peut pas encore attaquer
        {

            GameObject bul = GameObject.Instantiate(bullet, canon.position, transform.rotation);
            bul.GetComponent<Bullet>().portee = portee;
            bul.GetComponent<Bullet>().speed = vitesseProjectile;
            bul.GetComponent<Bullet>().damage = damage;
            currentTime = Time.time;

        }

    }
    
}
