using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Mobiiliesimerkki
{
    public class ScoreText : MonoBehaviour
    {   
        private TextMeshProUGUI m_Text;

        private void Awake()
        {
            m_Text = GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            m_Text.text = "Score: " + GameManager.Instance.GetScore();
        }
    }
}
