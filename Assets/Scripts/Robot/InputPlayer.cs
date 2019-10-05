using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    public int playerNumber;

    public string axisH;
    public string axisV;

    private RobotMovement rM;

    private void Awake()
    {
        rM = GetComponent<RobotMovement>();
    }

    private void Update()
    {
        rM.input = new Vector2(Input.GetAxis(axisH), Input.GetAxis(axisV));
    }
}
