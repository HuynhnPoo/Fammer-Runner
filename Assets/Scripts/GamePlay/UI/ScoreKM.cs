using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKM : MonoBehaviour
{
    public float score;
    public float Score { get { return score; } }

    public int stepScore = 1; // Tốc độ tăng điểm mỗi giây
    private int limitDistance = 50;
  

    void Update()
    {
        DistanceTraveled();
        ChangeStepAndSpeed();
    }

    void DistanceTraveled()
    {

        if(!GameManager.Instance.IsGameOver)
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
            stepScore += 3;
            GameManager.Instance.CurrentSpeed += 5;
        }
    }

}
