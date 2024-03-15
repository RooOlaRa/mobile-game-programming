using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki {
    public class CollectibleCoin : MonoBehaviour {
        [SerializeField] public readonly int m_Value = 1;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag("Player")) {
                GameManager.Instance.AddScore(m_Value);
                Destroy(gameObject);
            }
        }

    }
}
