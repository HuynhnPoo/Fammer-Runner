using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMagnet : MonoBehaviour, IPowerUp
{
    float time;

    private void Start()
    {
        time = GameManager.Instance.TimeCountDown;
    }

    //thuc hien bat bat nam cham
    public IEnumerator ActiveMagnetCoroutine()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        yield return new WaitForSeconds(time);

        gameObject.transform.GetChild(0).gameObject.SetActive(false);

    }


    //ham dung interface bat powerup nam cham 
    public void ActivePowerUp()
    {
        StartCoroutine(ActiveMagnetCoroutine());

    }
}
