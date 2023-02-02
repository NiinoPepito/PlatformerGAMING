using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Deaded = Animator.StringToHash("DeadAnim");
    


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

        if (Input.GetKeyDown(KeyCode.T)){
            _animator.Play(Deaded, 0, 0.0f);
            
        }

    }
}
