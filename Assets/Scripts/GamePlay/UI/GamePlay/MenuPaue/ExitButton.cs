using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitButton : ButtonClick
{
    public Animator ani;

    public override void OnClick()
    {
        StartCoroutine(ChangeScene());

    }

    // hàm chuyen ve main scene va thuc hien trasision
    IEnumerator ChangeScene()
    {

        ani.SetTrigger("EndTT");
        Time.timeScale = 1;
        GameManager.Instance.GameOver();
        yield return new WaitForSeconds(1);
        ani.SetTrigger("StartTT");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);// chuyen ve main scene

    }

}
