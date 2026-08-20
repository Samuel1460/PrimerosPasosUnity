using System.Runtime.CompilerServices;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 12f;
    [SerializeField] private float _movementSpeed = 8f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GroundCheck _groundCheck;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(_groundCheck.isGround)
        {

            if(Input.GetKey(KeyCode.Space))
            {

                _rigidbody2D.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);  // Topo de fuerza de impulso
                Debug.Log("Oprimi la tecla");

            }

        }
        _rigidbody2D.velocity = new Vector2(1 * _movementSpeed, _rigidbody2D.velocity.y);//multiplicar solo por X
    }













}
