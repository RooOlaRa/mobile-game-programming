using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki

{
    public class InputReader : MonoBehaviour
    {   
        private Input _input = null;
        private Vector2 _movementInput = Vector2.zero;
        private bool _interactInput = false;

        public Vector2 Movement
        {
            get { return _movementInput; }
        }

        // Initialise new Input
        private void Awake()
        {
            _input = new Input();
        }

        // Activate input in OnEnable
        private void OnEnable()
        {
            _input.Game.Enable();
        }

        // Disable input in OnDisable
        private void OnDisable()
        {
            _input.Game.Disable();
        }

        // Read input on every frame
        private void Update()
        {
            _movementInput = _input.Game.Move.ReadValue<Vector2>();

            // TODO: Read interactInput value
        }
    }
}
