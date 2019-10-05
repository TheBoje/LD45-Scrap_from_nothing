using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propulseur : Module {
    public float speedMultiplicator; // Vitesse du robot, (1 = défaut), applique un multiplicateur de vitesse
    public float speedRotaMultiplicator; // Vitesse de rotation du robot, facteur du Slerp (1 = défaut)
}