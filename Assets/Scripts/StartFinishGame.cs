using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishGame : MonoBehaviour
{
    private static readonly int Deaded = Animator.StringToHash("DeadAnim");

    [SerializeField] private Animator _animator;
    [SerializeField] private Transform player;
    [SerializeField] private Transform start;


    // Start is called before the first frame update
    private void Start()
    {
        StartOn();

    }

    public void StartOn()
    {
        player.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.position.y < -15){
            _animator.Play(Deaded, 0, 0.0f);
            StartOn();
        }

    }
}
