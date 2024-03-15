using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Mobiiliesimerkki {
    public class FallTrigger : MonoBehaviour {
        public GameObject m_Enemy;

        /// <summary>
        /// Find the trap to be triggered.
        /// </summary>
        private void Awake() {
            m_Enemy = GameObject.Find("Trap");
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if (m_Enemy != null) {
                m_Enemy.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }
    }
}
