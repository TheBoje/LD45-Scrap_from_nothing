using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotModules : MonoBehaviour
{
    [HideInInspector] public GameObject arme1;
    [HideInInspector] public GameObject arme2;
    [HideInInspector] public GameObject protection;
    [HideInInspector] public GameObject propulseur;

    public Transform backModulePivot;
    public Transform rightModulePivot;
    public Transform leftModulePivot;
    public Transform frontModulePivot;

    private void Update()
    {
        if (arme1)
        {
            arme1.transform.position = rightModulePivot.position;
            arme2.transform.rotation = rightModulePivot.rotation;

        }
        if (arme2)
        {

            arme2.transform.position = leftModulePivot.position;
            arme2.transform.rotation = leftModulePivot.rotation;
        }
        if (propulseur)
        {
            propulseur.transform.position = backModulePivot.position;
            propulseur.transform.rotation = backModulePivot.rotation;

        }

    }
    

}
