using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Création du type énuméré relatif au type de protection du bouclier
public enum TypeProtection { protect, reflect, laser };

public class Protection : Module
{

    public TypeProtection type;
    //public float angleDeProtection; Je ne vois pas comment l'implémenter pour l'instant
    public float defence;

}
