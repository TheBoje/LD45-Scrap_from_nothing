using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
public class CameraArena : MonoBehaviour
{
    public GameObject[] targets;

    public Vector3 offset;

    private Vector3 velocity;
    private Camera camera;
    public float maxViewportDistance = 0.85f;
    public float minViewportDistance = 0.65f;

    private void Start()
    {
        camera = GetComponent<Camera>();
        targets = GameObject.FindGameObjectsWithTag("Player");
    }

       
    void LateUpdate()
    {
        if (targets.Length == 0)
        {
            return;
        }

        Vector3 midPos = GetCenterPoint();
        transform.position = new Vector3(midPos.x, midPos.y, -10);
        camera.orthographicSize = CalcCameraPos();
         
    }

    float CalcCameraPos()
    {
        Vector2 player1Viewport = Camera.main.WorldToViewportPoint(targets[0].transform.position);
        Vector2 player2Viewport = Camera.main.WorldToViewportPoint(targets[1].transform.position);
        float viewportDistance = Vector2.Distance(player1Viewport, player2Viewport);
        float temp_result;

        if (viewportDistance <= maxViewportDistance && viewportDistance >= minViewportDistance)
        {
            temp_result = camera.orthographicSize;
        }
        else if (viewportDistance > maxViewportDistance)
        {
            temp_result = camera.orthographicSize + 0.04f;
        }
        else if (viewportDistance < minViewportDistance)
        {
            temp_result = camera.orthographicSize - 0.04f;
        }
        else
        {
            temp_result = camera.orthographicSize;
        }
        
        if (temp_result < 7)
        {
            temp_result = 7;
        }
        return temp_result;
    }


    Vector3 GetCenterPoint()
    {
        if (targets.Length == 1)
        {
            return targets[0].transform.position;
        }

        var bounds = new Bounds(targets[0].transform.position, Vector3.zero);
        for (int i = 0; i < targets.Length; i++)
        {
            bounds.Encapsulate(targets[i].transform.position);
        }

        return bounds.center;
    }
}
