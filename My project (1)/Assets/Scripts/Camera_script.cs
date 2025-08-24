using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_script : MonoBehaviour
{
    public Transform[] Cam_pos;
    public Transform player;

    Transform T_min = null;
    float min_dist = Mathf.Infinity;
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
    }

    Transform CloseToPlayer(Transform[] positions)
    {
        foreach (Transform t in positions)
        {
            //Vector3 directionToTarget = t.position - player.transform.position;

            float dist = Vector3.Distance(t.position, player.position);

            if (dist < min_dist)
            {
                min_dist = dist;
                T_min = t;
            }
        }
        return T_min;
    }
}
