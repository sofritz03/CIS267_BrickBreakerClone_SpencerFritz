using UnityEngine;

public class MysteryBrick : MonoBehaviour
{
    public GameObject[] powerups; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            SpawnRandomPowerup();
            Destroy(gameObject);
        }
    }

    void SpawnRandomPowerup()
    {
        if (powerups.Length == 0) return;

        int index = Random.Range(0, powerups.Length);
        Instantiate(powerups[index], transform.position, Quaternion.identity);
    }
}