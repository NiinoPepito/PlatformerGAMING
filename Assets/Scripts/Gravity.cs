using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private GameObject startGravity;
    [SerializeField] private GameObject gravity;
    [SerializeField] private GameObject startInvisibleIndicator;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            startGravity.SetActive(true);
            gravity.SetActive(false);
            startInvisibleIndicator.SetActive(false);
            _rigidbody2D.gravityScale = 2;
        }
    }
}
