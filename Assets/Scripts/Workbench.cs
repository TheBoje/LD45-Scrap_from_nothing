using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : MonoBehaviour
{

    public GameObject player;

    public List<GameObject> modules;

    [SerializeField] private float radiusDetect;

    private void Update()
    {
        Detect();
        EquipModule();
    }

    private void Detect()
    {
        Collider2D[] result = Physics2D.OverlapCircleAll(transform.position, radiusDetect);
        bool playerPresent = false;
        for (int i = 0; i < result.Length - 1; i++)
        {
            if (result[i].tag == "Player")
            {
                player = result[i].gameObject;
                playerPresent = true;
            }
            if (result[i].tag == "Module" && !result[i].GetComponent<Module>().equiped && !modules.Contains(result[i].gameObject))
            {
                modules.Add(result[i].gameObject);
            }

        }
        if (!playerPresent)
        {
            player = null;
            modules = new List<GameObject>();
        }
    }

    private void EquipModule()
    {
        if(modules.Count == 0 || player == null)
        {
            return;
        }
        Debug.Log("Equip?");
        //Arme
        if(modules[modules.Count - 1].GetComponent<Arme>())
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                player.GetComponent<RobotModules>().arme1 = modules[modules.Count - 1];
                modules.RemoveAt(modules.Count - 1);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                player.GetComponent<RobotModules>().arme2 = modules[modules.Count - 1];
                modules.RemoveAt(modules.Count - 1);
            }
        }
        //Propulseur
        if (Input.GetKeyDown(KeyCode.Z) && modules[modules.Count - 1].GetComponent<Propulseur>())
        {
            player.GetComponent<RobotModules>().propulseur = modules[modules.Count - 1];
            modules.RemoveAt(modules.Count - 1);
        }
        //Protection
        if (Input.GetKeyDown(KeyCode.S) && modules[modules.Count - 1].GetComponent<Protection>())
        {
            player.GetComponent<RobotModules>().protection = modules[modules.Count - 1];
            modules.RemoveAt(modules.Count - 1);
        }
    }

}
