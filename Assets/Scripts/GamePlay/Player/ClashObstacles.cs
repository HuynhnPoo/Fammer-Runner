using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static PowerUp;

public class ClashObstacles : MonoBehaviour
{
    public PowerUpType currentPowerUp = PowerUpType.None;

    private Coroutine powerUpCoroutine;

    private MusicControl music;

   // private BulletOfBoss bullet;

    private void OnEnable()
    {
        LoadMuisc();
    }

    void LoadMuisc()
    {
        if (music == null)
        {
            music = GameObject.FindGameObjectWithTag(TagInGame.MainCameraTag).GetComponent<MusicControl>();
        }
    }
    // va voi obstacles thi gameover
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagInGame.obstaclesTag))
        {
            music.PlayDeathAClip();

            //bullet.DisabledBoss();
            GameManager.Instance.GameOver();


        }

    }

    // thuc hien powerup khi cham voi powertag
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagInGame.powerUpTag))
        { 
            currentPowerUp = other.gameObject.GetComponent<PowerUp>().powerUpType;


           
            if (powerUpCoroutine != null)
            {
                StopCoroutine(powerUpCoroutine);
            }
            powerUpCoroutine = StartCoroutine(PowerUpCountDown());
          
          
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(TagInGame.powerUpTag))
        {
            Destroy(other.gameObject);
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
