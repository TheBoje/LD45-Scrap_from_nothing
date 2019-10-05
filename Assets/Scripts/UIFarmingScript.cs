using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFarmingScript : MonoBehaviour
{

    [SerializeField]
    private Text timer;
    [SerializeField]
    private Text lifeP1;
    [SerializeField]
    private Text lifeP2;


    private float currCountdownValue;

    [SerializeField]
    private GameObject player_1;
    [SerializeField]
    private GameObject player_2;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
        print_life();
    }

    // Affiche les points de vie de chaque players
    public void print_life()
    {
        lifeP1.text = player_1.GetComponent<RobotStats>().vie.ToString();
        lifeP2.text = player_2.GetComponent<RobotStats>().vie.ToString();
    }

    // Gère le compteur    
    public IEnumerator StartCountdown(float countdownValue = 90)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;

        timer.text = currCountdownValue.ToString();
        }
                 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
