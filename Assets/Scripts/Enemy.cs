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
        if (PlayerMovement.player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerMovement.player.transform.position, (moveSpeed + GameManager.difficulty) * Time.deltaTime);
        }
    }
}