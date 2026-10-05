using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    [SerializeField]    // ✅ Correct spelling
    private float _jumpForce = 10f; // You can tweak this in the Inspector

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ✅ Correct property name
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _jumpForce);
        }
    }
}
