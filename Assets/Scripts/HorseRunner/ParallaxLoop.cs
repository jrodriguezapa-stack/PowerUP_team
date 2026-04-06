using UnityEngine;

public class ParallaxLoop : MonoBehaviour
{
    public float speed = 1f;
    public float resetPositionX = -10f;
    public float startPositionX = 10f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= resetPositionX)
        {
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}
