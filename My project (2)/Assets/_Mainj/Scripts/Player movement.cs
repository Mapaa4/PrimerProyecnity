using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Variables

    [SerializeField] private int _edad = 17;
    private float _velocidad = 15.5f;
    private string nombre = "Mapaa";
    private bool isJumping = false;

    public float fuerza = 500f;

    [SerializeField] private Rigidbody2D _rigidbody2D;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       _rigidbody2D.AddForce(Vector2.right * fuerza);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
