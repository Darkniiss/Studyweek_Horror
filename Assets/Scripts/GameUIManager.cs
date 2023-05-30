using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI collectibleText;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject gameWonScreen;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {
        collectibleText.text = "Items collected: " + gameManager.collectibleCounter;

        if(gameManager.gameOver)
        {
            gameOverScreen.SetActive(true);
        }
        else if(gameManager.gameWon)
        {
            gameWonScreen.SetActive(true);
        }
    }
}
