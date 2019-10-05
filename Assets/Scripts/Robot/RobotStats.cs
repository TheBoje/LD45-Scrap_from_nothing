using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStats : MonoBehaviour
{
 


    // Start is called before the first frame update
    void Start()
    {
        // Ceci est un test pour comprendre correctement le fonctionnement des listes. Jugez pas.
        object[][] testArray = new object[][]
        {
            new object[] {"item1", -10f, +0.2f, +0.1f},
            new object[] {"item2", +20f, -0.1f, +0.1f}
        };

        Debug.Log(testArray[0][0]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
