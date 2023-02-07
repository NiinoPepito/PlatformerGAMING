using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Students;

[RequireComponent(typeof(Animator))]
public class Jump : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float vSpeed;
    private bool _isJumping;

    private void Update()
    {
        PlayerState state = Player.Instance.State;

        if (!_isJumping)
        {
            _isJumping = Input.GetKeyDown(KeyCode.UpArrow) && state.ControlState == ControlState.Movable;
        }
        
    }
    private void FixedUpdate() {
        if (_isJumping)
        {
            Jumping();
            _isJumping = false;
        }
    }

    private void Jumping() {
        bool isGround = Player.Instance.State.IsGrounded;
        Debug.Log("Try Jump");
        
        if (isGround) {
            Debug.Log("Jump");
            _animator.Play("JumpAnim", -1, 0.0f);
            _rigidbody2D.AddForce(new Vector2(0, vSpeed), ForceMode2D.Impulse);
        } 
        
    }
}