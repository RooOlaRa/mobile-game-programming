using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class PowerUp : MonoBehaviour
    {
        [SerializeField] GameObject m_Player = null;
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag("Player")) {
                m_Player.GetComponent<PlayerControl>().PowerUp();
                Destroy(gameObject);
            }
        }
    }
}
