using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get => instance; }

    private bool isGameOver;
    public bool IsGameOver { set => isGameOver = value; get => isGameOver; }

    int currentCoin = 0;

    private void Awake()
    {
        CheckInstance();
    }

    // kiem tra instance co rong khong
    void CheckInstance()
    {
        if (Instance != null && Instance != this) { Destroy(this); }
        else { instance = this; }
    }

    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        isGameOver = false;
    }

    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("hien thi game over"+ isGameOver);
    }

   public  void AddCoinScore(int coin)
    {
        currentCoin += coin;

        Debug.Log($"Coin score: {currentCoin}");
    }
}
