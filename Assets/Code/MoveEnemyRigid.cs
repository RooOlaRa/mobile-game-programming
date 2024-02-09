using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class MoveEnemyRigid : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 3.0f;
        [SerializeField]
        private float _maxY = 0.0f;

        [SerializeField]
        private float _minY = -3.8f;

        private bool _movingDown = true;
        private Rigidbody2D _rb;
        private void Awake() {
            _rb = GetComponent<Rigidbody2D>();
            _rb.gravityScale = 15;
            _rb.mass = 10;
        }
        private void Update()
        {   
            if (transform.position.y <= _minY)
            {
                _movingDown = false;
            }
            else if (transform.position.y >= _maxY)
            {
                _movingDown = true;
            }
            if (_movingDown)
            {
                _rb.velocity = Vector2.down * _speed;
            }
            else
            {
                _rb.velocity = Vector2.up * _speed;
            }
        }
    }
}
