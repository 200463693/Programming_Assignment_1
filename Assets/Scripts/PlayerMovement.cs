using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.8f;
    Rigidbody2D rb;

    private int score = 0;
    private int health = 5;

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0.0f, speed);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0.0f, -speed);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0.0f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0.0f);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if (health <= 0) {
            //game over screen plays
            LoadGameOverScene();
            
        }
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Coin"))
        {
            score += 100;
            // Update the UI TextMeshPro Text with the new score
            CoinScore.Instance.UpdateScoreText(score);
            // Destroy the collected coin
            Destroy(collider.gameObject);

        }
        if (collider.CompareTag("Fire"))
        {
            health -= 1;

            HealthDisplay.Instance.UpdatehealthText(health);

        }
    }
}
