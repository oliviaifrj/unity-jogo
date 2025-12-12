using UnityEngine;

public class CodigoMoeda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (CoinManager.Instance != null)
            {
                CoinManager.Instance.IncreaseCoins(1);
            }
            
            Destroy(gameObject);
        }
    }
}