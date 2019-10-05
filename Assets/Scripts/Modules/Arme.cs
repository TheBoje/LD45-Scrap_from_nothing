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
    [SerializeField] private float currentTime; //Pour cadancer l'arme
    const float initialLaunchForce = 200;

    private void Start()
    {
        currentTime = Time.time;
    }

    //Fonction appelé par InputPlayer quand on apuis sur le bouton d'action 1,2 ou 3
    public override void Act()
    {
        base.Act();
        if (currentTime + cadance >= Time.time)  //On ne peut pas encore attaquer
        {
            WaitForCadance();
        }

        GameObject bul = GameObject.Instantiate(bullet, transform.position, Quaternion.identity, transform);
        bul.GetComponent<Bullet>().portee = portee;
        bul.GetComponent<Rigidbody2D>().AddForce(transform.forward * initialLaunchForce * vitesseProjectile);
    }

    IEnumerator WaitForCadance()
    {
        yield return new WaitForSeconds((currentTime + cadance) - Time.time);
    }
}
