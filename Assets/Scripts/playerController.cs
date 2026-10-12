using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class playerController : MonoBehaviour
{
    public float speed = 15f;
    public GameObject player;

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 1f || Input.GetKeyDown(KeyCode.D))
        {
            print("right");
            player.transform.position += new Vector3(speed * Time.deltaTime, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1f || Input.GetKeyDown(KeyCode.A))
        {
            print("Left");
            player.transform.position += new Vector3(-speed * Time.deltaTime, 0);
        }
        if (Input.GetAxisRaw("Vertical") == 1f || Input.GetKeyDown(KeyCode.W))
        {
            print("Up");
            player.transform.position += new Vector3(0, speed * Time.deltaTime);
        }
        else if (Input.GetAxisRaw("Vertical") == -1f || Input.GetKeyDown(KeyCode.S))
        {
            print("Down");
            player.transform.position += new Vector3(0, -speed * Time.deltaTime);
        }
    } 
}
