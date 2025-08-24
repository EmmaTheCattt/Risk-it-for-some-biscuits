using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    bool Right = false;
    bool Left = false;
    bool Jump = false;

    Vector2 movement;

    public float x_mov;
    public float y_mov;

    public float speed = 1f;
    public float J_force = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputCheck();

        ApplyInput();
    }

    private void ApplyInput()
    {
        if (Right == true)
        {
            x_mov = 1f;
        }

        if (Left == true)
        {
            x_mov = -1f;
        }

        if (Jump == true)
        {

        }

        if (Left == true && Right == true)
        {
            x_mov = 0f;
        }

        if (Left != true && Right != true)
        {
            x_mov = 0f;
        }
    }

    private void InputCheck()
    {
        Right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        Left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        Jump = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
    }

    private void FixedUpdate()
    {
        movement = new Vector2(x_mov, y_mov);
        transform.position += new Vector3(movement.x, movement.y, 0) * speed * Time.fixedDeltaTime;
    }
}
