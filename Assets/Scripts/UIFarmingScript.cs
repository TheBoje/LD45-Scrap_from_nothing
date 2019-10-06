using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFarmingScript : MonoBehaviour
{

    [SerializeField] private Text timer;
    [SerializeField] private Text lifeP1;
    [SerializeField] private Text lifeP2;
    [SerializeField] private Text shieldP1;
    [SerializeField] private Text shieldP2;
    [SerializeField] private Text beginText;


    private float currCountdownValue;

    [SerializeField] private GameObject player_1;
    [SerializeField] private GameObject player_2;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown(105));

        player_1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        player_2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
    }

    // Affiche les points de vie de chaque players
    public void print_life()
    {
        lifeP1.text = player_1.GetComponent<RobotHP>().health.ToString();
        lifeP2.text = player_2.GetComponent<RobotHP>().health.ToString();
    }

    public void print_shield() 
    {
        // C'est vraiment cette valeur que je dois prendre ? J'ai peur  
        shieldP1.text = player_1.GetComponent<RobotHP>().resistance.ToString();
        shieldP2.text = player_2.GetComponent<RobotHP>().resistance.ToString();

    }


    // Gère le compteur    
    public IEnumerator StartCountdown(float countdownValue = 90)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            //Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;

            timer.text = currCountdownValue.ToString();

            if(currCountdownValue == 104)
            {
                beginText.text = "READY ?";
            }
            else if(currCountdownValue == 100)
            {
                beginText.text = "GO !";
            }
            else if(currCountdownValue < 100)
            {
                player_1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                player_2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                beginText.text = "";
            }
        }
                 
    }

    // Update is called once per frame
    void Update()
    {
        print_life();
        print_shield();
    }
}
