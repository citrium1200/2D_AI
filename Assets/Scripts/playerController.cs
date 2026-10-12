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
        if (Input.GetAxisRaw("Horizontal") == 1f)
        {
            print("right");
            player.transform.position += new Vector3(speed * Time.deltaTime, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1f)
        {
            print("Left");
            player.transform.position += new Vector3(-speed * Time.deltaTime, 0);
        }
        if (Input.GetAxisRaw("Vertical") == 1f)
        {
            print("Up");
            player.transform.position += new Vector3(0, speed * Time.deltaTime);
        }
        else if (Input.GetAxisRaw("Vertical") == -1f)
        {
            print("Down");
            player.transform.position += new Vector3(0, -speed * Time.deltaTime);
        }
    } 
}
