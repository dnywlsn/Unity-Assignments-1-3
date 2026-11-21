using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            CoinCounter.instance.AddCoin();
            Destroy(gameObject);
        }
    }
}

