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

    [Header("Valeur Pour les propulseur")]
    [SerializeField] private Vector2Int speedBounds;
    [SerializeField] private Vector2 slerpBounds;

    [Header("Couleur de rareté")]
    [SerializeField] Color quarter;
    [SerializeField] Color half;
    [SerializeField] Color halfAndQuarter;
    [SerializeField] Color full;

    private Arme GenerateArme()
    {
        Arme arme = new Arme();
        //random
        arme.damage = (int)Random.Range(damageBounds[0], damageBounds[1]);
        arme.vitesseProjectile = Random.Range(vitessBounds[0], vitessBounds[1]);
        arme.cadance = Random.Range(cadanceBounds[0], cadanceBounds[1]);

        //definition de la rarete
        float averageValue = (arme.damage + arme.portee + arme.vitesseProjectile + arme.cadance) / 4;

        averageValue = averageValue * 100 / (damageBounds[1] + porteeBounds[1] + vitessBounds[1] + cadanceBounds[1]);

        if(averageValue <= 25)
        {
            arme.rarete = quarter;
        }
        else if(averageValue <= 50)
        {
            arme.rarete = half;
        }else if(averageValue <= 75)
        {
            arme.rarete = halfAndQuarter;
        }
        else
        {
            arme.rarete = full;
        }

        return arme;
    }

    private Propulseur GeneratePropulseur()
    {
        Propulseur prop = new Propulseur();

        prop.speedMultiplicator = Random.Range(speedBounds[0], speedBounds[1]);
        prop.speedRotaMultiplicator = Random.Range(slerpBounds[0], slerpBounds[1]);

        float averageValue = (prop.speedMultiplicator + prop.speedRotaMultiplicator) / 2;
        averageValue = averageValue * 100 / ((speedBounds[1] + slerpBounds[1]) / 2);

        if (averageValue <= 25)
        {
            prop.rarete = quarter;
        }
        else if (averageValue <= 50)
        {
            prop.rarete = half;
        }
        else if (averageValue <= 75)
        {
            prop.rarete = halfAndQuarter;
        }
        else
        {
            prop.rarete = full;
        }
        return prop;
    }
}
