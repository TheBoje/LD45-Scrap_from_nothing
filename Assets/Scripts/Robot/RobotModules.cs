using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotModules : MonoBehaviour
{
    public GameObject arme1;
    public GameObject arme2;
    public GameObject protection;
    public GameObject propulseur;

    [Header("Pivot")]

    public Transform backModulePivot;
    public Transform rightModulePivot;
    public Transform leftModulePivot;
    public Transform frontModulePivot;

    private RobotMovement rM;

    private void Awake()
    {
        rM = GetComponent<RobotMovement>();
    }

    private void Update()
    {
        if (arme1)
        {
            arme1.transform.position = rightModulePivot.position;
            arme1.transform.rotation = rightModulePivot.rotation;

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
            rM.speedMulti = propulseur.GetComponent<Propulseur>().speedMultiplicator;
            rM.slerpMulti = propulseur.GetComponent<Propulseur>().speedRotaMultiplicator;

        }

    }
    

}
