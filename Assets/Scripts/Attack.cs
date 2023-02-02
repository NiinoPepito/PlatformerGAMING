using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Attack : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Attacked = Animator.StringToHash("AttackAnim");
    


    public void Awake()
    {
        _animator = GetComponent<Animator>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A)){
            _animator.Play(Attacked, 0, 0.0f);
            
        }

    }
}
