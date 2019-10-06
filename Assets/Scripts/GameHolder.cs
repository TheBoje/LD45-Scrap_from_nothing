using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHolder : MonoBehaviour
{

    private GameObject player_1;
    private GameObject player_2;

    private GameObject[] modsP1;
    private GameObject[] modsP2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Sauvegarde les modules acquis pour les robots à la fin de la phase de farming
    public void save_mods(GameObject player, ref GameObject[] mods)
    {
        GameObject arme1 = player.GetComponent<RobotModules>().arme1;
        GameObject arme2 = player.GetComponent<RobotModules>().arme2;
        GameObject protection = player.GetComponent<RobotModules>().protection;
        GameObject propulseur = player.GetComponent<RobotModules>().propulseur;

        mods = new GameObject[4] { arme1, arme2, protection, propulseur };
    }

    public void farming_level()
    {
        save_mods(player_1, ref modsP1);
        save_mods(player_2, ref modsP2);
    }


    public void combat_level()
    {

    }
}
