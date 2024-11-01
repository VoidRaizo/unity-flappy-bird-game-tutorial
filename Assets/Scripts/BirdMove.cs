using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class BirdMove : MonoBehaviour
{
    public float BirdSpeed;
    Rigidbody2D rb;
    public TextMeshProUGUI ScoreText;
    public float Score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rb.velocity = Vector2.up * BirdSpeed;
        }

        ScoreText.text = Score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreArea")
        {
            Score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea") 
        {
            SceneManager.LoadScene(0);
        }
    }
}
