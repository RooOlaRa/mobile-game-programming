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
        private InputReader m_inputReader = null;
        private Mover m_mover = null;
        private Rigidbody2D m_rb;
        private float m_speed = 5.0f;
        private Vector2 m_movement = Vector2.zero;
        private bool m_jump = false;
        private void Awake() {
            m_inputReader = GetComponent<InputReader>();
            m_mover = GetComponent<Mover>();
            m_rb = GetComponent<Rigidbody2D>();
            m_rb.gravityScale = 1;
        }
        private void Update() {   
            m_movement = m_inputReader.Movement;
            m_jump = m_inputReader.Jump;
            if (m_jump) {
                Debug.Log("Jump");
            }
        }
        private void FixedUpdate() {
            m_rb.velocity = m_movement * m_speed;
        }
    }
}
