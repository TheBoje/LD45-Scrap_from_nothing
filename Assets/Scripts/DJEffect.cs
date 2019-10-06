using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJEffect : MonoBehaviour
{
    public GameObject impact;

    public void Impact(Vector3 pos)
    {
        GameObject g = GameObject.Instantiate(impact, pos, Quaternion.identity);
        Wait(1f);
        Destroy(g);
    }

    IEnumerator Wait(float t)
    {
        yield return new WaitForSeconds(t);
    }
}
