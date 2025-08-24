using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_script : MonoBehaviour
{
    public GameObject[] Cam_pos;
    public GameObject player;

    public Vector2 distance;
    public Vector2 shortest_dis;
    public float cam_off = -10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        shortest_dis = new Vector2(player.transform.position.x - Cam_pos[0].transform.position.x, player.transform.position.y - Cam_pos[0].transform.position.y);

        for (int i = 0; i < Cam_pos.Length; i++)
        {
            distance = new Vector2(player.transform.position.x - Cam_pos[0].transform.position.x, player.transform.position.y - Cam_pos[0].transform.position.y);

            if (shortest_dis.magnitude > distance.magnitude)
            {
                shortest_dis = distance;
                transform.position = new Vector3(Cam_pos[i].transform.position.x, Cam_pos[i].transform.position.y, cam_off);
            }
        }
    }
}
