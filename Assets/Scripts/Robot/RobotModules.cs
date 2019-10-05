using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotModules : MonoBehaviour
{
    public GameObject backModule;
    public GameObject rightModule;
    public GameObject leftModule;

    public Transform backModulePivot;
    public Transform rightModulePivot;
    public Transform leftModulePivot;

    private void Update()
    {
        if (backModule)
        {
            backModule.transform.position = backModulePivot.position;
            backModule.transform.rotation = backModulePivot.rotation;

        }
        if (rightModule)
        {

            rightModule.transform.position = rightModulePivot.position;
            rightModule.transform.rotation = rightModulePivot.rotation;
        }
        if (leftModule)
        {
            leftModule.transform.position = leftModulePivot.position;
            leftModule.transform.rotation = leftModulePivot.rotation;

        }

    }

}
