using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSystem : MonoBehaviour
{
    [SerializeField] private int health = 3;

    [SerializeField] private Button button;

    [SerializeField] private Text text;

    private void Awake()
    {
        button.gameObject.SetActive(false);
        Time.timeScale = 1f;
        text.text = "HP: " + health.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            health--;
            text.text = "HP: " + health.ToString();
            if (health > 0)
            {
                return;
            }
            Destroy(gameObject);
            button.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
