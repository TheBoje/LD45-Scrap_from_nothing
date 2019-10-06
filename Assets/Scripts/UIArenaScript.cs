using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIArenaScript : MonoBehaviour
{
    [SerializeField] private Text lifeP1;
    [SerializeField] private Text lifeP2;
    [SerializeField] private Text shieldP1;
    [SerializeField] private Text shieldP2;
    [SerializeField] private Text beginText;

    [SerializeField] private float currCountdownValue;

    private GameObject player_1;
    private GameObject player_2;

    public GameObject gh;


    // Start is called before the first frame update
    void Start()
    {
        player_1 = GameObject.Find("Robot_1");
        player_2 = GameObject.Find("Robot_2");


        player_1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        player_2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        
        StartCoroutine(StartCountdown(7));

        beginText.canvasRenderer.SetAlpha(0f);

    }

    public void TextFadeIn()
    {
        beginText.CrossFadeAlpha(1, 0.2f, false);
    }

    public void TextFadeOut()
    {
        beginText.CrossFadeAlpha(0, 0.2f, false);
    }

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

    public IEnumerator StartCountdown(float countdownValue = 7)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;

            if (currCountdownValue == 6)
            {
                TextFadeIn();
                beginText.text = "Ready ?";
            }
            if (currCountdownValue == 4)
            {
                beginText.text = "3";
            }
            if (currCountdownValue == 3)
            {
                beginText.text = "2";
            }
            if (currCountdownValue == 2)
            {
                beginText.text = "1";
            }
            if (currCountdownValue == 1)
            {
                beginText.text = "Go !";

                player_1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                player_2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            }
            if (currCountdownValue == 0)
            {
                TextFadeOut();
            }
        }
    }

    void Update()
    {
        print_life();
        print_shield();
    }


}
