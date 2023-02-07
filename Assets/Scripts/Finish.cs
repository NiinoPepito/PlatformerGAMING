using System;
using Students;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour {
    [SerializeField] private GameObject exitIndicator;
    [SerializeField] private GameObject exit;
    private StartFinishGame _start;
        
    
    public void Awake()
    {
        _start = GetComponent<StartFinishGame>();

    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            exitIndicator.SetActive(true);
            Player.Instance.State.ControlState = ControlState.None;
            Player.Instance.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            Player.Instance.gameObject.transform.position = exit.transform.position;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            exitIndicator.SetActive(false);
            Player.Instance.State.ControlState = ControlState.Movable;
            Player.Instance.gameObject.GetComponent<Rigidbody2D>().simulated = true;
            _start.StartOn();
        }
    }
}