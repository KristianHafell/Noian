using UnityEngine;
using System.Collections.Generic;
using System;

public class NPC_movement : MonoBehaviour
{
    public Rigidbody npcRigidbody;
    public int speed = 5;
    private Vector3[] directions = {Vector3.right, Vector3.left, Vector3.forward, Vector3.back};
    private System.Random random = new System.Random();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Generate random direction
        int randomNumber = random.Next(0,4);
        Vector3 randomDirection = directions[randomNumber];
        Debug.Log(randomNumber);
        Debug.Log(randomDirection);
    }
}
