using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform player;
    public float smoothFactor = 0.1f;
    public Vector3 offset;

    private void LateUpdate () {
        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Slerp (transform.position, desiredPosition, smoothFactor);
        transform.position = smoothedPosition;
    }

}