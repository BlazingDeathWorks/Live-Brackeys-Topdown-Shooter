using Mono.CompilerServices.SymbolWriter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private float offset = 90f;

    void Awake()
    {
        
    }

    void Update()
    {
        if (PlayerMovement.player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerMovement.player.transform.position, (moveSpeed + GameManager.difficulty) * Time.deltaTime);

            Vector3 rawDirection = transform.position - PlayerMovement.player.transform.position;
            transform.localEulerAngles = new Vector3(0, 0, (Mathf.Atan2(rawDirection.y, rawDirection.x * Mathf.Rad2Deg) - offset));
        }
    }
}