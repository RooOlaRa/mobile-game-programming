using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private float m_SpawnInterval = 5.0f;
        [SerializeField] private GameObject m_CoinPrefab;
        [SerializeField] private float m_SpawnRadius = 5.0f;
        private float m_SpawnTimer = 0.0f;
        private int m_MaxCoins = 5;
        private int m_CoinCount = 0;

        private void Update()
        {
            if (m_CoinCount >= m_MaxCoins)
            {
                Destroy(gameObject);
            }
            
            m_SpawnTimer += Time.deltaTime;
            if (m_SpawnTimer >= m_SpawnInterval)
            {
                m_SpawnTimer = 0.0f;
                SpawnCoin();
            }
        }

        private void SpawnCoin()
        {
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * m_SpawnRadius;
            spawnPosition.z = -1.0f;
            Instantiate(m_CoinPrefab, spawnPosition, Quaternion.identity);
            m_CoinCount++;
        }
    }
}
