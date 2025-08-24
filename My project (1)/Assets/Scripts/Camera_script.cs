using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_script : MonoBehaviour
{
    public Transform[] Cam_pos;
    public Transform player;

    Transform T_min = null;
    public float min_dist = Mathf.Infinity;
    public float cam_off = -10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CloseToPlayer(Cam_pos));
        transform.position = new Vector3(CloseToPlayer(Cam_pos).position.x, CloseToPlayer(Cam_pos).position.y, cam_off);
    }

    Transform CloseToPlayer(Transform[] positions)
    {
        float min_dist = Mathf.Infinity;

        foreach (Transform t in positions)
        {
            //Vector3 directionToTarget = t.position - player.transform.position;

            float dist = Vector3.Distance(t.position, player.position);
            Debug.Log(player.position);
            Debug.Log(min_dist);

            if (dist < min_dist)
            {
                T_min = t;
                min_dist = dist;
            }
        }
        return T_min;
    }
}
