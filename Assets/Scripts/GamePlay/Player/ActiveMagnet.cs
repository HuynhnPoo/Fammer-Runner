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


    public IEnumerator ActiveMagnetCoroutine()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        yield return new WaitForSeconds(time);

        gameObject.transform.GetChild(0).gameObject.SetActive(false);

    }

    public void ActivePowerUp()
    {
        StartCoroutine(ActiveMagnetCoroutine());

        //Debug.Log(gameObject.name);
    }
}
