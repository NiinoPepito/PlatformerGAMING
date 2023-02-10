using System;
using Students;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour {
    [SerializeField] private GameObject exitIndicator;
    [SerializeField] private GameObject exit;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            exitIndicator.SetActive(true);
            Player.Instance.State.ControlState = ControlState.None;
            Player.Instance.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            Player.Instance.gameObject.transform.position = exit.transform.position;
        }
    }
}