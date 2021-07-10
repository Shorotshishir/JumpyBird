using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce;

    [SerializeField]
    private PlayerInput _playerInput;

    private Rigidbody2D _rb2d;

    public Action GameEnded;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    public void Jump(InputAction.CallbackContext obj)
    {
        _rb2d.velocity = Vector2.zero;
        _rb2d.AddForce(Vector3.up * _jumpForce);
    }

    private void FixedUpdate()
    {
        if (transform.position.y < -2.98 || transform.position.y > 6.59f)
        {
            GameEnded?.Invoke();
            //SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<SeaWeed>() != null)
        {
            GameEnded?.Invoke();
            //SceneManager.LoadScene(0);
        }
    }
}