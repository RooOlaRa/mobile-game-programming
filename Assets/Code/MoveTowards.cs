using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki {
    public class MoveTowards : MonoBehaviour {
        private Rigidbody2D m_Rb;
        private GameObject m_Target;
        private Vector2 m_TargetPosition;
        [SerializeField] private float m_speed = 1.0f;
        
        private void Awake() {
            m_Rb = GetComponent<Rigidbody2D>();
            m_Rb.gravityScale = 0;
            m_Target = GameObject.Find("Target");
        }

        private void Update() {
            m_TargetPosition = m_Target.transform.position;
        }
        private void FixedUpdate() {
            m_Rb.MovePosition(Vector2.MoveTowards(transform.position, m_TargetPosition, m_speed * Time.fixedDeltaTime));
        }


        private void OnTriggerEnter2D(Collider2D other) {
            Destroy(gameObject);
        }
    }
}
