using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : ButtonClick
{
    public override void OnClick()
    {
        if (GameManager.Instance.IsPaused)
        {
            GameManager.Instance.IsPaused = false;

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            Time.timeScale = 1;
        }
    }


}
