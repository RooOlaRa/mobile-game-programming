using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class HelloWorld : MonoBehaviour
    {   
        int frame = 1;
        int a = 0;
        int b = 1;
        int c;
        // Start is called before the first frame update
        void Start()
        {
        Debug.Log("Hello, World!");
        }

        // Update is called once per frame
        void Update()
        {
            c = a + b;
            if (c < 1000) {
                if (frame == 1) {
                    Debug.Log(a);
                    a = b;
                    frame++;
                } else if (frame == 2){
                    Debug.Log(a);
                    frame++;
                } else if (frame == 3){
                    Debug.Log(a);
                    frame++;
                } else {
                    Debug.Log(c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}
