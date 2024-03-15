using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance { get; private set; }

        private int m_Score = 0;


        private void Awake() {
            if (Instance == null) {
                Instance = this;
            } else {
                Destroy(gameObject);
            }
        }

        public void AddScore(int value) {
            m_Score += value;
        }

        public int GetScore() {
            return m_Score;
        }
    }
}
