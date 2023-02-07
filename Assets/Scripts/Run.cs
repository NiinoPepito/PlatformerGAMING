using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Students;

public class Run : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    private bool _isMooving;
    private int _direction;



    private static readonly int Running = Animator.StringToHash("Running");
    


    public void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerState state = Player.Instance.State;

        if (state.ControlState == ControlState.Movable)
        {
            Move();
        }
        else
        {
            _animator.SetBool(Running, false);
        }

        
        if((!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) || state.ControlState == ControlState.None){
            _rigidbody2D.velocity = new Vector2(0, _rigidbody2D.velocity.y);

        }
    }

    private void Move(){

        _animator.SetBool(Running, Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow));
        _isMooving = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow);
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            _sprite.flipX = false;
            _direction = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            _sprite.flipX = true;
            _direction = -1;
        }
        
    }

    private void FixedUpdate() {
        Vector2 vel = _rigidbody2D.velocity;
        if (_isMooving)
        {
            _rigidbody2D.AddForce(new Vector2(speed*_direction, 0), ForceMode2D.Force);
        }
        _rigidbody2D.velocity = new Vector2(Mathf.Clamp(vel.x, -maxSpeed, maxSpeed), vel.y);
    }
}
