using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RobotMovement))]
public class InputPlayer : MonoBehaviour
{
    public int playerNumber;

    public string axisH;
    public string axisV;

    private RobotMovement rM;
    private RobotModules rMod;

    private void Awake()
    {
        rM = GetComponent<RobotMovement>();
        rMod = GetComponent<RobotModules>();
    }

    private void Update()
    {
        rM.input = new Vector2(Input.GetAxis(axisH), Input.GetAxis(axisV));

        //TEMPORAIRE
        if (Input.GetKeyDown(KeyCode.E) && rMod.arme1)
        {
            rMod.arme1.GetComponent<Arme>().Act();
        }
        if (Input.GetKeyDown(KeyCode.A) && rMod.arme2)
        {
            rMod.arme2.GetComponent<Arme>().Act();
        }
    }
}
