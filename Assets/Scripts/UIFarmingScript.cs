using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFarmingScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        timer = this.getChild("Compteur");
         StartCoroutine(StartCountdown());
   
    }

        private float currCountdownValue;
        public IEnumerator StartCountdown(float countdownValue = 90)
        {
            currCountdownValue = countdownValue;
            while (currCountdownValue > 0)
            {
                Debug.Log("Countdown: " + currCountdownValue);
                yield return new WaitForSeconds(1.0f);
                currCountdownValue--;
            }
        }

    // Update is called once per frame
    void Update()
    {

    }
}
