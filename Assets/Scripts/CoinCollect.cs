using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin touched by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Collecting coin.");

            if (CoinManager.Instance != null)
            {
                CoinManager.Instance.CollectCoin();
            }
            else
            {
                Debug.LogError("CoinManager Instance is NULL!");
            }

            Destroy(gameObject);
        }
    }
}