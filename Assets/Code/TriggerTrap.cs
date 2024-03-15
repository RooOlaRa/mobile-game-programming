using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki {
    public class TriggerTrap : MonoBehaviour {
        private Rigidbody2D m_Rb;
        private void Awake() {
            m_Rb = GetComponent<Rigidbody2D>();
            m_Rb.gravityScale = 0;
        }
    }
}
