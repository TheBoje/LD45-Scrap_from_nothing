using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
public class CameraArena : MonoBehaviour
{
    public List<Transform> targets;

    public Vector3 offset;

    private Vector3 velocity;
    private Camera camera;
    public float maxViewportDistance = 0.85f;
    public float minViewportDistance = 0.65f;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

       
    void LateUpdate()
    {
        if (targets.Count == 0)
        {
            return;
        }

        Vector3 midPos = GetCenterPoint();
        transform.position = new Vector3(midPos.x, midPos.y, -10);
        camera.orthographicSize = CalcCameraPos();
         
    }

    float CalcCameraPos()
    {
        Vector2 player1Viewport = Camera.main.WorldToViewportPoint(targets[0].position);
        Vector2 player2Viewport = Camera.main.WorldToViewportPoint(targets[1].position);
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
        if (targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }
}
