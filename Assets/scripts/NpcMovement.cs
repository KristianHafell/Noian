using UnityEngine;
using System.Collections.Generic;
using System;

public class NPC_movement : MonoBehaviour
{
    public Rigidbody npcRigidbody;
    public BoxCollider houseBoxCollider;
    public BoxCollider doorBoxCollider;

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
        // Update distance between NPC and its house and door
        Vector3 npcPosition = npcRigidbody.position;
        Vector3 closestPointHouse = houseBoxCollider.ClosestPoint(npcPosition);
        Vector3 closestPointDoor = doorBoxCollider.ClosestPoint(npcPosition);

        float distanceHouse = Vector3.Distance(npcPosition, closestPointHouse);
        float distanceDoor = Vector3.Distance(npcPosition, closestPointDoor);

        // Generate random direction
        int randomNumber = random.Next(0,4);
        Vector3 randomDirection = directions[randomNumber];
    }
}
