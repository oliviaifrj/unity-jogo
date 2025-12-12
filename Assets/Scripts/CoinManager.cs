using UnityEngine;
using TMPro; 
public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    private int coins = 0;

    [SerializeField] 
    private TextMeshProUGUI coinText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateCoinText();
    }

    public void IncreaseCoins(int amount = 1)
    {
        coins += amount;
        UpdateCoinText();
        Debug.Log("Moedas Coletadas: " + coins); 
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: " + coins.ToString();
        }
    }
}