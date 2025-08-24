using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_script : MonoBehaviour
{
    public GameObject[] Cam_pos;
    public GameObject player;

    public Vector2 distance;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Cam_pos.Length; i++)
        {
            distance = Vector2.Distance(player.transform.position, Cam_pos[i].transform.position);
        }
    }
}
