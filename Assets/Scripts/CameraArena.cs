using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArena : MonoBehaviour
{
    [SerializeField]private List<GameObject> players;

    private Vector3 averagePos;
    private float averageDist;

    [SerializeField] private Vector3 offset;
    [SerializeField] private float minDist;
    [SerializeField] private float maxDist;


    private void LateUpdate()
    {
        averagePos = Vector3.zero;
        foreach (GameObject g in players)
        {
            averagePos += g.transform.position;
            averageDist += Vector3.Distance(averagePos, g.transform.position);
        }
        averagePos /= players.Count;
        averageDist /= players.Count;

        transform.position = averagePos + offset;

        averageDist = ClampValue(averageDist, minDist, maxDist);

        GetComponent<Camera>().orthographicSize = averageDist;
    }

    float ClampValue(float value, float min, float max)
    {
        if (value < min)
            return min;
        if (value > max)
            return max;
        return value;
    }
}
