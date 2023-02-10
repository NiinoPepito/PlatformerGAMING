using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MooveJumpDidac : MonoBehaviour
{
    [SerializeField] private GameObject startJumpDidacIndicator;
    [SerializeField] private GameObject startDidacIndicator;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            startJumpDidacIndicator.SetActive(true);
            startDidacIndicator.SetActive(false);
        }
    }
}