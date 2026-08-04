using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Variables

    public float altura = 1.65f;
    public int edad = 1742;
    public string nombre = "Pau";
    public bool puedeVotar = true;


    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform tranform;
    //crear una variable tp trsnfm



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Debug.Log("Hola: " + nombre + " tu edad es: " + edad + " tu altura es: " + altura);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.red; 
        transform.position = new Vector3(10f, 0f, 0f);
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Update");
    }
}
