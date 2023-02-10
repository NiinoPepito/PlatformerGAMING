using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBox : MonoBehaviour
{
    [SerializeField] private GameObject startInvisibleIndicator;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            startInvisibleIndicator.SetActive(true);
        }
    }
}