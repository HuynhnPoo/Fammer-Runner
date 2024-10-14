using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PowerUp;

public class ClashObstacles : MonoBehaviour
{
    //bool hasPowerUp=false;

    public PowerUpType currentPowerUp = PowerUpType.None;

    private Coroutine powerUpCoroutine;
    private void Update()
    {
      
    }

    // va voi obstacles thi gameover
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagInGame.obstaclesTag))
        {
            GameManager.Instance.GameOver();
        }

    }

    // thuc hien powerup khi cham voi powertag
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagInGame.powerUpTag))
        { 
            //hasPowerUp = true;
            currentPowerUp = other.gameObject.GetComponent<PowerUp>().powerUpType;

           
            if (powerUpCoroutine != null)
            {
                StopCoroutine(powerUpCoroutine);
            }
            powerUpCoroutine = StartCoroutine(PowerUpCountDown());
        }


    }


    //chuyen powerUtype be none
    IEnumerator PowerUpCountDown()
    {
        yield return new WaitForSeconds(2);
       // hasPowerUp = false;
        currentPowerUp = PowerUpType.None;
    }




}
