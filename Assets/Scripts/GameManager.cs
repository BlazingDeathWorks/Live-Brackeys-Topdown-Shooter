using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float time;
    [SerializeField] private float maxTime = 5f;
    public static float difficulty;

    void Awake()
    {
        time = maxTime;
        difficulty = 0f;
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0f)
        {
            time = maxTime;
            difficulty += 0.1f;
        }
    }
}
