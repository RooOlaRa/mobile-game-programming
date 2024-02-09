using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class MoveEnemy : MonoBehaviour
    {
        [SerializeField]
        private float _speed;
        [SerializeField]
        private float _maxY;

        [SerializeField]
        private float _minY;

        private bool _movingDown = true;

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
                transform.Translate(Vector2.down * _speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.up * _speed * Time.deltaTime);
            }
        }
    }
}
