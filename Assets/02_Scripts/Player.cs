using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInfo playerInfo;
    private Rigidbody2D _rb2D;
    private Vector2 _moveInput;
    private float _playerSpeed;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _playerSpeed = playerInfo.basePlayerSpeed;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMove(InputValue value)
    {
        _moveInput = value.Get<Vector2>();
    }

    private void Update()
    {
        if (_moveInput.x != 0)
        {
            _spriteRenderer.flipX = _moveInput.x < 0;
        }
    }
    
    private void FixedUpdate()
    {
        _rb2D.linearVelocity = new Vector2(_moveInput.x * _playerSpeed, _moveInput.y * _playerSpeed);
    }
}
