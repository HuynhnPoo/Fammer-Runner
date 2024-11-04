using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
   [SerializeField] private GameObject gameOver;

    // Start is called before the first frame update

    private void Awake()
    {
        gameOver = FindGameObjectByNameHide.FindGameObjectByName(TagInGame.gameOverTag); 
        
    }
    // Update is called once per frame
    void Update()
    {
        ActiveGameOver();
    }

    //neu game se bat giao dien  game over
    void ActiveGameOver()
    {
        if (GameManager.Instance.IsGameOver)
        {
            gameOver.SetActive(true);
        }
    }
}
