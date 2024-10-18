using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKM : MonoBehaviour
{
    public float score;
    public float stepScore = 1f; // Tốc độ tăng điểm mỗi giây

    void Update()
    {
        DistanceTraveled();


    }

    void DistanceTraveled()
    {
        score += stepScore * Time.deltaTime;// Tăng điểm số theo thời gian


        float roundedScore = Mathf.Round(score * 100f) / 100f; // Làm tròn điểm số đến 2 chữ số thập phân để hiển thị
       // Debug.Log("Điểm số: " + roundedScore);
    }
}
