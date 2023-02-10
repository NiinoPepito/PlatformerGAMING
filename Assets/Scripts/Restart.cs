using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Students;

public class Restart : MonoBehaviour
{
    
    [SerializeField] private GameObject exitIndicator;
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
    private StartFinishGame _start;
        
    
    public void Awake()
    {
        _start = GetComponent<StartFinishGame>();
    }
        
    
    public void OnButtonPress(){
        exitIndicator.SetActive(false);
        Player.Instance.State.ControlState = ControlState.Movable;
        Player.Instance.gameObject.GetComponent<Rigidbody2D>().simulated = true;
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
        player.position = start.position;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            exitIndicator.SetActive(false);
            Player.Instance.State.ControlState = ControlState.Movable;
            Player.Instance.gameObject.GetComponent<Rigidbody2D>().simulated = true;
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
            _start.StartOn();
        }
    }
}
