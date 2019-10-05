using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralModuleGeneration : MonoBehaviour
{
    public GameObject prefabModule;
    [Header("Valeur Pour les armes")]
    [SerializeField] private Vector2Int damageBounds;
    [SerializeField] private Vector2 porteeBounds;
    [SerializeField] private Vector2 vitessBounds;
    [SerializeField] private Vector2 cadanceBounds;

    [Header("Couleur de rareté")]
    [SerializeField] Color quarter;
    [SerializeField] Color half;
    [SerializeField] Color halfAndQuarter;
    [SerializeField] Color full;

    private Arme GenerateArme()
    {
        Arme arme = new Arme();

        arme.damage = (int)Random.Range(damageBounds[0], damageBounds[1]);
        arme.portee = Random.Range(porteeBounds[0], porteeBounds[1]);
        arme.vitesseProjectile = Random.Range(vitessBounds[0], vitessBounds[1]);
        arme.cadance = Random.Range(cadanceBounds[0], cadanceBounds[1]);

        float averageValue = (arme.damage + arme.portee + arme.vitesseProjectile + arme.cadance) / 4;

        averageValue = averageValue * 100 / (damageBounds[1] + porteeBounds[1] + vitessBounds[1] + cadanceBounds[1]);

        if(averageValue <= 25)
        {
            arme.rarete = quarter;
        }
        else if(averageValue <= 50)
        {
            arme.rarete = half;
        }

        return arme;
    }
}
