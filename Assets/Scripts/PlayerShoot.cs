using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float offset = 90;
    [SerializeField] private float shootRate = 0.1f;
    private float timeSinceLastShot = 0;

    private void Awake()
    {
        timeSinceLastShot = shootRate;
    }

    private void Update()
    {
        Vector2 rawDirection = mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.localEulerAngles = new Vector3(0, 0, (Mathf.Atan2(rawDirection.y, rawDirection.x) * Mathf.Rad2Deg) + offset);

        timeSinceLastShot += Time.deltaTime;

        if (Input.GetMouseButton(0) && timeSinceLastShot >= shootRate)
        {
            timeSinceLastShot = 0;
            Instantiate(bullet, spawnPoint.position, transform.localRotation);
        }
    }
}