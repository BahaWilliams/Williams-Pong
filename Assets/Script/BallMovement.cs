using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballSpeed;

    Vector2 ballDirection;
    Rigidbody2D ballPhysics;

    private void Awake()
    {
        ballPhysics = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        float randomY = Random.Range(-4f, 4f);
        ballDirection = new Vector2(ballSpeed, randomY);
        ballPhysics.velocity = ballDirection;
    }
}