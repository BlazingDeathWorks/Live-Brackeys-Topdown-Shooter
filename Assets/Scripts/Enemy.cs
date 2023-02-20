using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    void Awake()
    {
        
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PlayerMovement.player.transform.position, moveSpeed * Time.deltaTime);
    }
}