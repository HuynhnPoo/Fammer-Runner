using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IPowerUp
{
   
    private int scoreCoin = 1;

    private float time;

    private void Start()
    {
        time = GameManager.Instance.TimeCountDown;// khơi tạo thời gian
        
    }


    // va chạm với player sẽ cập nhật điểm
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(TagInGame.playerTag))
        {
           GameManager.Instance.AddCoinScore(scoreCoin);
            Destroy(gameObject);
        }
    }

    // khi đươc hiện sẽ thay doi coin scoreCoin =2 sau 5s sẽ =1
    public IEnumerator DoubleCoin()
    {
        scoreCoin = 2;

        yield return new WaitForSeconds(time);

        scoreCoin = 1;
    }

    // thuc hien couroutine
    public void ActivePowerUp()
    {
        StartCoroutine(DoubleCoin());
        Debug.Log(gameObject.name);
    }
}
