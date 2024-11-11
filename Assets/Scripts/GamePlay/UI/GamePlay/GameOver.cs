using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    public ParticleSystem particleGameOver;
    public Transform particlePos;



    // Start is called before the first frame update

    private void Awake()
    {
        gameOver = FindGameObjectByNameHide.FindGameObjectByName(TagInGame.gameOverTag);

    }

    //neu game se bat giao dien  game over
    public void ActiveGameOver()
    {
        gameOver.SetActive(true);
        Instantiate(particleGameOver, particlePos.position, particlePos.rotation);
    }
}
