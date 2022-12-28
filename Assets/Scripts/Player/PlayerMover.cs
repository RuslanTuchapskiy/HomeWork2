using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [Range(1,3)]
    [SerializeField] private float _mouseSensitive;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");

        transform.eulerAngles -= new Vector3(0f, -horizontalInput * _mouseSensitive, 0f); 

    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        LocalMover(transform.forward, verticalInput);
    }

    private void LocalMover(Vector3 direction, float input)
    {
        _rigidbody.velocity = direction * input * (_speed * Time.fixedDeltaTime);
    }
}
