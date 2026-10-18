using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    public int coinsCollected = 0;

    public TMP_Text coinText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateCoinText();
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "COINS: " + coinsCollected;
        }
    }
}