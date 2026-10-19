using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float speed = 10f;
    public float limit = 5f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(move, 0, 0);

        //clamp position so paddle stays on screen
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limit, limit);
        transform.position = pos;
    }
}