using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform Player;
    public float Angle = 1F;
    public float ZoomSpeed = 0.25F;

    // Update is called once per frame
    void Update()
    {
        var ScrollWheelValue = Input.GetAxis("Mouse ScrollWheel");

        if (ScrollWheelValue != 0)
        {
            transform.position *= (1F + ScrollWheelValue * ZoomSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(Player.position, Vector3.up, Angle);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Player.position, Vector3.down, Angle);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(Player.position, Vector3.right, Angle);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(Player.position, Vector3.left, Angle);
        }

        transform.LookAt(Player.position);
    }
}
