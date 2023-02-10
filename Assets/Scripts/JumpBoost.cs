using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Students;

public class JumpBoost : MonoBehaviour
{
    [SerializeField] private GameObject startJumpIndicator;
    [SerializeField] private GameObject jumpBoost;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            startJumpIndicator.SetActive(true);
            jumpBoost.SetActive(false);
            Jump.vSpeed = 60;
            Jump.n = 3;
        }
    }
}
