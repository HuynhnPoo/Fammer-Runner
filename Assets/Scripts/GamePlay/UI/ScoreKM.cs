using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKM : MonoBehaviour
{
    private float score;
    public float Score { get { return score; } }

    private int stepScore = 1; // Tốc độ tăng điểm mỗi giây
    private int limitDistance = 50;

    [SerializeField] private SpawnBoss spawnBoss;

    [SerializeField] private DestroyBoss destroyBoss;

    private void Start()
    {
        if (spawnBoss == null)
        {
            spawnBoss = GameObject.FindObjectOfType<SpawnBoss>();
        }
    }

    void Update()
    {
        DistanceTraveled();
        ChangeStepAndSpeed();
    }


    //khang cach nhan vat da di
    void DistanceTraveled()
    {

        if (!GameManager.Instance.IsGameOver)
            score += stepScore * Time.deltaTime;// Tăng điểm số theo thời gian
        score = Mathf.Round(score * 100f) / 100f; // Làm tròn điểm số đến 2 chữ số thập phân để hiển thị

    }

    // ham thay stepscore
    public void ChangeStepAndSpeed()
    {
        //kiem tra khoang cach de tang step score speed va limit distance
        if (limitDistance < score)
        {
            limitDistance *= 2;
            stepScore += 2;
            GameManager.Instance.CurrentSpeed += 5;

            StartCoroutine(SpwanBoss());
        }
    }


    //tao ra boss
    IEnumerator SpwanBoss()
    {
        spawnBoss.Spawn();

        yield return new WaitForSeconds(5);
        if (destroyBoss == null)
        {
            destroyBoss = GameObject.FindObjectOfType<DestroyBoss>();
        }

        destroyBoss.DestroyBossSpawn();

    }

}
