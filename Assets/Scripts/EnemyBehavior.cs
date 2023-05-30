using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Transform target;
    private GameManager gameManager;
    [SerializeField] private float moveSpeed;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (!gameManager.gameOver && !gameManager.gameWon)
        {
            transform.Translate((target.position - transform.position).normalized * Time.deltaTime * moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !gameManager.gameWon)
        {
            gameManager.gameOver = true;
        }
    }
}
