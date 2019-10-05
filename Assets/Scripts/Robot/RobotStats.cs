using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStats : MonoBehaviour {
    // Données du joueur
    public string nom;                  // Nom du robot / joueur
    public string marque;               // Nom de la marque du robot choisie

    // Charactéristiques du joueur
    public int vie;                     // Vie du robot, (0 = mort)
    public float vitesse;               // Vitesse du robot, (1 = défaut), applique un multiplicateur de vitesse
    public float resistance;            // Resistance du robot, (1 = défaut), applique un multiplicateur de résistance
    public float rotationVitesse;       // Vitesse de rotation du robot (vitesse angulaire, ou latence avant rotation)

    // Données relatives aux équipements
    public int nombreArme;              // Entre 0 et 2
    // Arme 1
    public string arme1Type;            // Type de l'arme (feu, laser, explosif, cac, autre, ...)
    public int arme1Degats;             // Dégats de l'arme par projectile
    public int arme1Portee;             // Distance parcourue par le projectile
    public int arme1VitesseProj;        // Vitesse du projectile (1 = défaut)
    public int arme1Cadence;            // Cadence de tir de l'arme (1 = défaut)
    // Arme 2
    public string arme2Type;            // Type de l'arme (feu, laser, explosif, cac, autre, ...)
    public int arme2Degats;             // Dégats de l'arme par projectile
    public int arme2Portee;             // Distance parcourue par le projectile
    public int arme2VitesseProj;        // Vitesse du projectile (1 = défaut)
    public int arme2Cadence;            // Cadence de tir de l'arme (1 = défaut)
    // Protection
    public bool possedeProtection;      // True = Possède une protection, False = Ne possède pas de protection
    public string protectionType;       // Mirroir, Absorbant, etc.
    public int protectionAngle;         // Angle de la protection, ex = 45°
    public int protectionEtat;          // 1 = Intact, 0 = Détruit 
    public int protectionDurabilité;    // Multiplicateur de durabilité de la protection (1 = défaut)

}