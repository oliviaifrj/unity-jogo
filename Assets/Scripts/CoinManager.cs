using UnityEngine;
using TMPro; // MUITO IMPORTANTE: Precisa disso para usar o TextMeshPro

public class CoinManager : MonoBehaviour
{
    // Singleton: Permite que outros scripts o encontrem facilmente usando CoinManager.Instance
    public static CoinManager Instance;

    // A variável que guarda o número de moedas
    private int coins = 0;

    // Referência do objeto de texto na UI (você conectará isso no Inspector)
    [SerializeField] 
    private TextMeshProUGUI coinText;

    private void Awake()
    {
        // Garante que haja apenas um CoinManager
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
        // Atualiza o texto logo que o jogo começa
        UpdateCoinText();
    }

    // Função que será chamada pelo script da moeda
    public void IncreaseCoins(int amount = 1)
    {
        coins += amount;
        UpdateCoinText();
        Debug.Log("Moedas Coletadas: " + coins); // Linha de verificação
    }

    // Atualiza o texto na tela
    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: " + coins.ToString();
        }
    }
}