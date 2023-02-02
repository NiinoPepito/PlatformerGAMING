using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishGame : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Deaded = Animator.StringToHash("DeadAnim");

    [SerializeField] private Transform player;
    [SerializeField] private Transform start;

    public void Awake()
    {
        _animator = GetComponent<Animator>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        player.position = start.position;
    
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.position.y < -15 ){
            _animator.Play(Deaded, 0, 0.0f);
            Start();

        }

    }
}
