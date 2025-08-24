using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_script : MonoBehaviour
{
    public Transform[] Cam_pos;
    public GameObject player;

    public Transform T_min;
    float min_dist = Mathf.Infinity;
    public float cam_off = -10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = CloseToPlayer(Cam_pos).position;
    }

    Transform CloseToPlayer(Transform[] positions)
    {
        foreach (Transform t in positions)
        {
            float dist = Vector3.Distance(t.position, player.transform.position);

            if (dist < min_dist)
            {
                T_min = t;
                min_dist = dist;
            }
        }
        return T_min;
    }
}
