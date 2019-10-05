using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerModule : MonoBehaviour
{
    [SerializeField]private ProceduralModuleGeneration pMGen;

    [SerializeField] private float timestamp;
    private float currentTime;

    [SerializeField]private List<string> types;

    [SerializeField] private int nmbrMaxofMod;
    [SerializeField] private int spacingSpawn;

    private void Start()
    {
        currentTime = Time.time;
    }

    private void Update()
    {
        if(currentTime + timestamp > Time.time && nmbrMaxofMod > 0)
        {

            pMGen.CreateModuleObject(new Vector2(Random.Range(-spacingSpawn, spacingSpawn), Random.Range(-spacingSpawn, spacingSpawn)),types[(int)Random.Range(0,types.Count)]);
            nmbrMaxofMod--;

            currentTime = Time.time;
        }
    }
}
