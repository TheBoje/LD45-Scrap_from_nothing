using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poubelle : MonoBehaviour
{

    public GameObject player;

    public Transform output;

    [SerializeField] private float radiusDetect;

    private void Update()
    {
        Detect();
        DeEquipModule();
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

        }
        if (!playerPresent)
        {
            player = null;
        }
    }
    private void DeEquipModule()
    {
        if (player == null)
            return;
        Debug.Log("DeEquip?");
        //Arme
        if (player.GetComponent<RobotModules>().arme1 != null && Input.GetKeyDown(KeyCode.D))
        {
            GameObject g = player.GetComponent<RobotModules>().arme1;
            player.GetComponent<RobotMovement>().followed = false;
            player.GetComponent<RobotModules>().arme1 = null;
            g.transform.position = output.position;
            g.transform.parent = null;
            g.GetComponent<ItemFollow>().enabled = true;
            g.GetComponent<ItemFollow>().Target = null;

        }
        if (player.GetComponent<RobotModules>().arme2 && Input.GetKeyDown(KeyCode.Q))
        {
            GameObject g = player.GetComponent<RobotModules>().arme2;
            player.GetComponent<RobotMovement>().followed = false;
            player.GetComponent<RobotModules>().arme2 = null;
            g.transform.position = output.position;
            g.transform.parent = null;
            g.GetComponent<ItemFollow>().enabled = true;
            g.GetComponent<ItemFollow>().Target = null;
        }
        //Propulseur
        if (player.GetComponent<RobotModules>().propulseur && Input.GetKeyDown(KeyCode.Z))
        {
            GameObject g = player.GetComponent<RobotModules>().propulseur;
            player.GetComponent<RobotMovement>().followed = false;
            player.GetComponent<RobotModules>().propulseur = null;
            g.transform.position = output.position;
            g.transform.parent = null;
            g.GetComponent<ItemFollow>().enabled = true;
            g.GetComponent<ItemFollow>().Target = null;

        }
        //Protection
        if (player.GetComponent<RobotModules>().protection && Input.GetKeyDown(KeyCode.S))
        {
            GameObject g = player.GetComponent<RobotModules>().protection;
            player.GetComponent<RobotMovement>().followed = false;
            player.GetComponent<RobotModules>().protection = null;
            g.transform.position = output.position;
            g.transform.parent = null;
            g.GetComponent<ItemFollow>().enabled = true;
            g.GetComponent<ItemFollow>().Target = null;
        }
    }
}
