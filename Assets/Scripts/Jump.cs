using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Students;

[RequireComponent(typeof(Animator))]
public class Jump : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GameObject startJumpIndicator;
    [SerializeField] private GameObject endJumpIndicator;
    [SerializeField] private GameObject jumpBoost1;
    [SerializeField] private GameObject jumpBoost2;
    [SerializeField] private GameObject startGravity;
    [SerializeField] private GameObject startJumpDidacIndicator;
    public static float vSpeed = 27;
    private bool _isJumping;
    public static int n;

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

    public void Jumping() {
        bool isGround = Player.Instance.State.IsGrounded;
        
        if (isGround) {
            _animator.Play("JumpAnim", -1, 0.0f);
            _rigidbody2D.AddForce(new Vector2(0, vSpeed), ForceMode2D.Impulse);
            startJumpIndicator.SetActive(false);
            endJumpIndicator.SetActive(false);
            startGravity.SetActive(false);
            startJumpDidacIndicator.SetActive(false);
            
            if (n >= 0)
            {
                n = n - 1;
                if (n == 0)
                {
                    vSpeed = 27;
                    jumpBoost1.SetActive(true);
                    jumpBoost2.SetActive(true);
                    endJumpIndicator.SetActive(true);
                }
            }
        } 
        
    }
}