using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArena : MonoBehaviour
{

    [SerializeField]
    private GameObject player_1;
    [SerializeField]
    private GameObject player_2;

    private int zPos = -10;
    private Vector3 pos = new Vector3(0, 0, -10);

    private const float firstSizeX = 5.0f;
    private const float firstDistX = 11.0f;
    private const float firstSizeY = 10.0f;
    private const float firstDistY = 11.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = average_pos_players();



        this.GetComponent<Camera>().orthographicSize = camera_size();
        //(firstSize * Vector3.Distance(player_1.transform.position, player_2.transform.position)) / firstDist
    }

    public Vector3 average_pos_players()
    {
        return (player_1.transform.position + player_2.transform.position) / 2 + pos;
    }

    public float camera_size()
    {
        float distX = Mathf.Abs(player_1.transform.position.x - player_2.transform.position.x);
        float distY = Mathf.Abs(player_1.transform.position.y - player_2.transform.position.y);

        if(distX > distY)
        {
            Debug.Log("distX > distY : " + distX);
            return ((firstSizeX * distX) / firstDistX);
        }
        else
        {
            Debug.Log("distX < distY : " + distY);
            return ((firstSizeY * distY) / firstDistY);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (player_1.transform.position + player_2.transform.position) / 2 + pos;
        this.GetComponent<Camera>().orthographicSize = camera_size();


    }
}
