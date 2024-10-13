using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PowerUp;

public class ClashObstacles : MonoBehaviour
{
    bool hasPowerUp=false;

    public PowerUpType currentPowerUp = PowerUpType.None;

    private Coroutine powerUpCoroutine;
    // va voi obstacles thi gameover
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagInGame.obstaclesTag))
        {
            GameManager.Instance.GameOver();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagInGame.powerUpTag))
        { 
            hasPowerUp = true;
            currentPowerUp = other.gameObject.GetComponent<PowerUp>().powerUpType;

            Debug.Log("hien thi powerUP"+ currentPowerUp);

            if (powerUpCoroutine != null)
            {
                StopCoroutine(powerUpCoroutine);
            }
            powerUpCoroutine = StartCoroutine(PowerUpCountDown());
        }


    }

    IEnumerator PowerUpCountDown()
    {
        yield return new WaitForSeconds(2);
        hasPowerUp = false;
        currentPowerUp = PowerUpType.None;

        Debug.Log("hien thi powerUP" + currentPowerUp);

    }




}
