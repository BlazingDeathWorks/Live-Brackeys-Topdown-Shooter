using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float offset = 180;
    [SerializeField] private float speed = 10;
    private Transform direction;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject empty = new GameObject("Bullet");
        direction = empty.transform;
        direction.localEulerAngles = transform.localEulerAngles + new Vector3(0, 0, offset);
    }

    private void FixedUpdate()
    {
        rb.velocity = direction.up * speed;
    }
}
