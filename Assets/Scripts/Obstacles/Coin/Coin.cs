using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IPowerUp
{
   
    int scoreCoin = 1;

   
    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(TagInGame.playerTag))
        {
           GameManager.Instance.AddCoinScore(scoreCoin);
            Destroy(gameObject);
        }
    }


    public IEnumerator DoubleCoin()
    {
        scoreCoin = 2;

        yield return new WaitForSeconds(5);

        scoreCoin = 1;
    }

    public void ActivePowerUp()
    {
        StartCoroutine(DoubleCoin());
    }
}
