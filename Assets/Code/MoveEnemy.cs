using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class MoveEnemy : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 3.0f;
        [SerializeField]
        private float _maxY = 0.0f;

        [SerializeField]
        private float _minY = -3.8f;

        private bool _movingDown = true;

        private void Update()
        {   
            if(transform.position.y <= _minY)
            {
                _movingDown = false;
            }
            else if(transform.position.y >= _maxY)
            {
                _movingDown = true;
            }
            if(_movingDown)
            {
                transform.Translate(Vector3.down * _speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.up * _speed * Time.deltaTime);
            }
        }
    }
}
