using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Jump : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float speedJump;
    [SerializeField] private float maxSpeedJump;



    private static readonly int Jumped = Animator.StringToHash("JumpAnim");
    


    public void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            _animator.Play(Jumped, 0, 0.0f);
            _rigidbody2D.AddForce(new Vector2(0, speedJump), ForceMode2D.Impulse);
            
        }

        Vector2 velocity = _rigidbody2D.velocity;


    }

    private void FixedUpdate() {
        Vector2 vel = _rigidbody2D.velocity;
        _rigidbody2D.velocity = new Vector2(vel.x, Mathf.Clamp(vel.y, -maxSpeedJump, maxSpeedJump));

    }
}
