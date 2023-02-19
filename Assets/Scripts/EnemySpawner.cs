using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    [SerializeField] private float range;
    [SerializeField] private float time;
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
            Instantiate(enemy, new Vector3(transform.position.x + Random.Range(-range, range), transform.position.y, transform.position.z), Quaternion.identity);
            time = maxTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        spawn = false;
    }

    void OnTriggerExit(Collider other)
    {
        spawn = true;
    }
}
