using UnityEngine;

public class ArmoredBrick : MonoBehaviour
{
    public Sprite crackedSprite;
    private int hits = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            hits++;

            if (hits == 1)
            {
                //switch to cracked sprite
                GetComponent<SpriteRenderer>().sprite = crackedSprite;
            }
            else if (hits >= 2)
            {
                Destroy(gameObject);
            }
        }
    }
}
