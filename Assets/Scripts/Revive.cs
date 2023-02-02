using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revive : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Revived = Animator.StringToHash("Revived");



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
        _animator.SetBool(Revived, Input.GetKey(KeyCode.G));

    }
}
