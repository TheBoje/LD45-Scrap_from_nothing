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
    [SerializeField]
    private Text beginText;


    private float currCountdownValue;

    [SerializeField]
    private GameObject player_1;
    [SerializeField]
    private GameObject player_2;


    // Start is called before the first frame update
    void Start()
    {
        begining_text();
        StartCoroutine(StartCountdown(30));
        print_life();
    }

    // Affiche les points de vie de chaque players
    public void print_life()
    {
        lifeP1.text = player_1.GetComponent<RobotHP>().health.ToString();
        lifeP2.text = player_2.GetComponent<RobotHP>().health.ToString();
    }

    // Texte de début
    public void begining_text()
    {
        beginText.text = "READY ?";
        StartCoroutine(Sleep(10));
        beginText.text = "GO";
        StartCoroutine(Sleep(10));
        beginText.text = "";
    }

    // sleep le temps désigné
    public IEnumerator Sleep(float sec)
    {
        yield return new WaitForSeconds(sec);
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
