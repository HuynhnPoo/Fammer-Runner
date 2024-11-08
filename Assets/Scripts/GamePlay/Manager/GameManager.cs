using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get => instance; }

    private bool isGameOver;
    public bool IsGameOver { set => isGameOver = value; get => isGameOver; }// khoi tao thuoc tính  IsGameOver

    private static bool isPaused = false;

    public bool IsPaused { set => isPaused = value; get => isPaused; }// khoi tao thuoc tính  IsPaused

    private float timeCountDown = 5;
    
    public float TimeCountDown { get => timeCountDown; }// khoi tao thuoc tính  TimeCountDown

    private  int currentCoin = 0;

    public int CurrentCoin { get => currentCoin; }// khoi tao thuoc tính  CurrentCoin


    private int currentSpeed = 10;
    public int CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
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

    // thuc hie  start game
    public void startGame()
    {
        isGameOver = false;
    }


    // thuc hien game over
    public void GameOver()
    {
        isGameOver = true;
    }

    // ham update them diem coi khi va cham
   public  void AddCoinScore(int coin)
    {
        currentCoin += coin;
    }

}
