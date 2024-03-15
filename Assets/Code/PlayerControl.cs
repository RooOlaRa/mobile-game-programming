using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Controls player charactet. Dependancies: InputReader and Mover.
    /// </summary>
    [RequireComponent(typeof(InputReader))]
    public class PlayerControl : MonoBehaviour
    {   
        private InputReader m_inputReader = null;
        private Rigidbody2D m_rb;
        [SerializeField] private float m_speed = 1.0f;
        [SerializeField] private float m_jumpThrust = 1.0f;
        private int m_jumpCount = 0;
        private Vector2 m_movement = Vector2.zero;
        private bool m_jump = false;
        private bool m_jumping = false;
        private void Awake() {
            m_inputReader = GetComponent<InputReader>();
            m_rb = GetComponent<Rigidbody2D>();
            m_rb.gravityScale = 1;
        }
        private void Update() {   
            m_movement = m_inputReader.Movement;
            m_jump = m_inputReader.Jump;
            if (m_jump) {
                m_jumping = true;
            }
        }
        private void FixedUpdate() {
            m_rb.AddForce(m_movement * m_speed);
            if (m_jumping && m_jumpCount < 2) {
                m_jumpCount++;
                m_rb.AddForce(transform.up * m_jumpThrust, ForceMode2D.Impulse);
                m_jumping = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject) {
                m_jumpCount = 0;
            }
        }
    }
}
