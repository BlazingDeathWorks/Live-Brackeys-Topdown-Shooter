using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    [SerializeField] private int health = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            if (--health > 0) return;
            Destroy(gameObject);
            //Hook up the replayability
        }
    }
}
