using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public float launchSpeed = 10f;
    private bool launched = false;
    public Transform paddle;

    void Update()
    {
        if (!launched)
        {
            //stick ball to paddle before launch
            transform.position = paddle.position + new Vector3(0, 0.5f, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                launched = true;
                GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * launchSpeed;
            }
        }
    }
}
