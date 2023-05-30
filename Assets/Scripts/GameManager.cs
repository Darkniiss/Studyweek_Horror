using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> collectibles;
    public int collectibleCounter;
    public bool gameOver;
    public bool gameWon;

    void Start()
    {
        
    }

    void Update()
    {
        if(collectibleCounter == collectibles.Count)
        {
            gameWon = true;
        }

    }
}
