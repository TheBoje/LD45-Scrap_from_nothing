using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHolder : MonoBehaviour
{

    private GameObject player_1;
    private GameObject player_2;

    private GameObject[] modsP1;
    private GameObject[] modsP2;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("TEST");
    }

    private void Start()
    {
        player_1 = GameObject.Find("Robot_1");
        player_2 = GameObject.Find("Robot_2");
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
        player_1.GetComponent<RobotHP>().canGetHitted = true;
        player_2.GetComponent<RobotHP>().canGetHitted = true;
        SceneManager.LoadScene("scene2");
        player_1.transform.position = new Vector3(-1.22f, 58.13f, 0);
        player_2.transform.position = new Vector3(8.97f, 58.06f, 0);

    }


    public void combat_level()
    {
        
    }
}
