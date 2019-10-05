using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject player_1;
    [SerializeField]
    private GameObject player_2;
    public Vector3 offset_aux = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if(this.tag == "item_pick_p1")
        {
            transform.position = player_1.transform.position + offset_aux;
            Debug.Log(player_1.transform.position);
        }
        else if(this.tag == "item_pick_p2")
        {
            transform.position = player_2.transform.position + offset_aux;
        }
        ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "player_1" :
                this.tag = "item_pick_p1";
                    break;
            case "player_2":
                this.tag = "item_pick_p2";
                break;
        }
    }
}
