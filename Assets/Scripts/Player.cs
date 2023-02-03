using System;
using UnityEngine;

namespace Students {
    public class CollectState {
        private int _diamondCount;

        public int DiamondCount {
            get => _diamondCount;
            set {
                _diamondCount = value;
                OnDiamondCountUpdated?.Invoke(_diamondCount);
            }
        }

        public event Action<int> OnDiamondCountUpdated;
    }

    public class Player : MonoBehaviour
    {
        private PlayerState _state;
        private CollectState _collectState;

        private static readonly string WalkableSurfaceTag = "WalkableSurfaceTag";

        public static Player Instance { get; private set; }
        public PlayerState State => _state;
        public CollectState CollectState => _collectState;

        private void Awake()
        {
            Instance = this;
            _collectState = new CollectState();
            _state = new PlayerState()
            {
                IsGrounded = true,
                IsStagger = false,
                ControlState = ControlState.Movable
            };

#if UNITY_EDITOR
            _collectState.OnDiamondCountUpdated += i => Debug.Log($"Diamond Count updated {i}");
#endif
        }

        private void Update()
        {
            Debug.Log(State.IsGrounded);
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            if (!other.gameObject.CompareTag(WalkableSurfaceTag))
            {
                return;
            }
            Debug.Log("Enter");
            State.IsGrounded = true;
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (!other.gameObject.CompareTag(WalkableSurfaceTag))
            {
                return;
            }
            Debug.Log("Exit");
            State.IsGrounded = false;

        }
    }

}