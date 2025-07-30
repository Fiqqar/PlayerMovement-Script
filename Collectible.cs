
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Fungsi ini dipanggil Unity saat ada objek lain masuk ke trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Beritahu GameManager untuk menambah skor
            GameManager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}

