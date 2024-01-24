using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 1.0f;
        
        public void Move(Vector2 direction)
        {
            // transform is a shortcut to this GameObjects transform Component
            // and get current position of GameObject
            // positions are always in three dimensions, even if
            // the game is 2D
            Vector3 position = transform.position;
            position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
            transform.position = position;
        }
    }
}
