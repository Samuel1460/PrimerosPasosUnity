using System.Runtime.CompilerServices;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float altura = 1.82f;
    public int edad = 30;
    public string nombre = "Roberto";
    public bool puedeVotar = true;

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform Transform;

   


    private void Start()
    {
        Debug.Log(" Hola : " + nombre + " tu edad es : " + edad + " tu altura es: " + altura);
        rigidbody2D.simulated = false; 
        spriteRenderer.color = Color.red;
        transform.position = new Vector3(10f, 0f, 0f );

        
    }

    private void Update()
    {
        
    }










}
