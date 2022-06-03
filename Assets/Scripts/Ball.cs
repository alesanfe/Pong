using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 200;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1 : 1;
        float y = Random.value < 0.5f ? Random.Range(-1, -0.5f) : Random.Range(0.5f, 1);
        _rigidbody.AddForce(new Vector2(x, y) * speed);
    }
}
