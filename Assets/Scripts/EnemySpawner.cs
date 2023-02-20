using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    [SerializeField] private Vector2 range;

    private float time;
    [SerializeField] private float maxTime;

    [SerializeField] private bool spawn;

    // Start is called before the first frame update
    void Awake()
    {
        time = maxTime;
        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0 && spawn)
        {
            Instantiate(enemy, new Vector3(transform.position.x + Random.Range(-range.x, range.x), transform.position.y + Random.Range(-range.y, range.y), transform.position.z), Quaternion.identity);
            time = maxTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawn = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawn = true;
        }
    }
}
