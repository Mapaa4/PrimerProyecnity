using UnityEngine;

public class Playermovement : MonoBehaviour
{

    [SerializeField] private float _force = 5f;
    [SerializeField] private float _speed = 1000f;
    [SerializeField] private Rigidbody2D _rigidbody2D;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
      if (Input.GetKey(KeyCode.Space))
     {
        _rigidbody2D.AddForce(Vector2.up * _force);

     }
        _rigidbody2D.linearVelocity = Vector2.right * _speed * Time.deltaTime;


    }
}
