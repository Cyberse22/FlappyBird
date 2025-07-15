using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f; // Velocity
    [SerializeField] private float _rotationSpeed = 10f; // Rotation speed

    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rb.linearVelocity = Vector2.up * _velocity;
        }
        //if (Input.GetMouseButtonDown(0)) // Check if the left mouse button is pressed
        //{
        //    _rb.linearVelocity = Vector2.up * _velocity; // Set the velocity to move upwards
        //}
    }

    private void FixedUpdate()
    {
        //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Vector2 direction = (mousePosition - _rb.position).normalized;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; // Adjust angle for sprite orientation
        //_rb.rotation = Mathf.LerpAngle(_rb.rotation, angle, _rotationSpeed * Time.fixedDeltaTime);
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
