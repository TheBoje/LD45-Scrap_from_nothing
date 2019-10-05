using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Définition du type énuméré relatif au type de l'arme
public enum TypeArme { feu, laser, explosion, balistique }  //Les armes de corps à corps seront dans une autre classe

public class Arme : Module {
    //Donnés d'équipement de l'arme
    public TypeArme type;              // Type de l'arme (feu, laser, explosion ou balistique)
    public int damage;                 // Dégats de l'arme (10 -> réduit de 10 hp, quand résistance = 1)
    public float portee;               // Facteur de portée de l'arme (défaut = 1)
    public float vitesseProjectile;    // Facteur de vitesse des projectiles de l'arme (défaut = 1)
    public float cadance;              // Facteur de cadence de tir de l'arme (défaut = 1)

    //Autres variables nécéssaires
    [SerializeField] private GameObject bullet;
    private float currentTime;         // Pour cadancer l'arme
    [SerializeField] private Transform canon;

    // Initialisation pour mettre en place la cadence de l'arme.
    private void Start () {
        currentTime = Time.time;
        }

    //Fonction appelé par InputPlayer quand on appuis sur le bouton d'action 1,2 ou 3
    public override void Act () {
        base.Act ();
        if (currentTime + cadance < Time.time) // Tant que le cooldown de la cadence n'est pas terminé, on ne peut pas tirer
        {
            GameObject bul = GameObject.Instantiate (bullet, canon.position, transform.rotation);   // Création de la balle dans une instance
            bul.GetComponent<Bullet> ().portee = portee;                                            // Application de la portée à la balle
            bul.GetComponent<Bullet> ().speed = vitesseProjectile;                                  // Application de la vitesse du projectile à la balle
            bul.GetComponent<Bullet> ().damage = damage;                                            // Application des dégats à la balle
            currentTime = Time.time;                                                                // Réinitialisation du cooldown de la cadence
        }
    }
}