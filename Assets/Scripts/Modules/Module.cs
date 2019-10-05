using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour {
    public string name;         // Nom du module 
    public bool equiped;        // Booléen, true = est équipé, false = est pas équipé
    public virtual void Act () { }
    public Color rarete;

}