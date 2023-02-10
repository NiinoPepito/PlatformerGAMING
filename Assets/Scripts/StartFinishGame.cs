using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishGame : MonoBehaviour
{
    private static readonly int Deaded = Animator.StringToHash("DeadAnim");

    [SerializeField] private Animator _animator;
    [SerializeField] private Transform player;
    [SerializeField] private Transform start;
    [SerializeField] private GameObject startJumpIndicator;
    [SerializeField] private GameObject endJumpIndicator;
    [SerializeField] private GameObject jumpBoost1;
    [SerializeField] private GameObject jumpBoost2;
    [SerializeField] private GameObject startGravity;
    [SerializeField] private GameObject gravity;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GameObject startJumpDidacIndicator;
    [SerializeField] private GameObject startDidacIndicator;
    [SerializeField] private GameObject startInvisibleIndicator;


    // Start is called before the first frame update
    private void Start()
    {
        StartOn();

    }

    public void StartOn()
    {
        player.position = start.position;
        Jump.vSpeed = 27;
        Jump.n = 0;
        startJumpIndicator.SetActive(false);
        endJumpIndicator.SetActive(false);
        jumpBoost1.SetActive(true);
        jumpBoost2.SetActive(true);
        startGravity.SetActive(false);
        gravity.SetActive(true);
        startJumpDidacIndicator.SetActive(false);
        startDidacIndicator.SetActive(true);
        startInvisibleIndicator.SetActive(false);
        _rigidbody2D.gravityScale = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.position.y < -15){
            _animator.Play(Deaded, 0, 0.0f);
            StartOn();
        }

    }
}
