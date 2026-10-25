using System;
using System.Data.Common;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class playerController : MonoBehaviour
{
    public float speed = 15f;
    public GameObject player;

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
        Vector3 direction = move.normalized;

        if (move != Vector3.zero)
        {
            transform.up = direction;
        }
    } 
}
