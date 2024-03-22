using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Mobiiliesimerkki {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance { get; private set; }

        private int m_Score = 0;
        private string m_ScoreKey = "Score";

        [SerializeField] private GameObject m_PausedText = null;


        private void Awake() {
            if (Instance == null) {
                Instance = this;
            } else {
                Destroy(gameObject);
            }
        }

        private void OnEnable() {
            m_Score = PlayerPrefs.GetInt(m_ScoreKey, 0);
        }

        private void OnDisable() {
            PlayerPrefs.SetInt(m_ScoreKey, m_Score);
        }

        public void PauseGame() {
            if (Time.timeScale == 0) {
                Time.timeScale = 1;
                m_PausedText.SetActive(false);
            } else {
                Time.timeScale = 0;
                m_PausedText.SetActive(true);
            }
        }

        public void AddScore(int value) {
            m_Score += value;
        }

        public void ResetScore() {
            m_Score = 0;
        }

        public int GetScore() {
            return m_Score;
        }
    }
}
