using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{

  public float speed = 5f;
  public float maxVelocity = 5f;
  private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          rb.velocity = Vector2.up * speed;
        }

        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxVelocity);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.CompareTag("Pipe"))
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Manager.instance.GameOver();
    }
}