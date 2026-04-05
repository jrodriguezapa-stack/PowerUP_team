using UnityEngine;
/*
    todos los obstáculos usan la misma velocidad global
    DifficultyManager cambia esa velocidad
    el obstáculo se destruye cuando sale de pantalla 
 */
public class ObstacleMove : MonoBehaviour
{
    public static float globalSpeed = 6f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(-globalSpeed, 0f, 0f);
    }

    void Update()
    {
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
