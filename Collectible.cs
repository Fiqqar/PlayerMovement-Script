using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float respawnTime = 5f;
    public Vector3 areaMin = new Vector3(-10, 0, -10);
    public Vector3 areaMax = new Vector3(10, 0, 10);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(1);
            gameObject.SetActive(false);
            Invoke(nameof(Respawn), respawnTime);
        }
    }

    void Respawn()
    {
        Vector3 newPos = new Vector3(
            Random.Range(areaMin.x, areaMax.x),
            transform.position.y,
            Random.Range(areaMin.z, areaMax.z)
        );

        transform.position = newPos;
        gameObject.SetActive(true);
    }
}
