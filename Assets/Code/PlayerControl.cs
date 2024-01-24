using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Controls player charactet. Dependancies: InputReader and Mover.
    /// </summary>
    [RequireComponent(typeof(InputReader), typeof(Mover))]
    public class PlayerControl : MonoBehaviour
    {   
        private InputReader _inputReader = null;
        private Mover _mover = null;
        // Start is called before the first frame update
        private void Awake()
        {
            // Initialise InputReader and Mover in Awake.
            _inputReader = GetComponent<InputReader>();
            _mover = GetComponent<Mover>();
        }

        // Update is called once per frame
        private void Update()
        {
            // Get user input
            Vector2 movement = _inputReader.Movement;
            _mover.Move(movement);
        }
    }
}
