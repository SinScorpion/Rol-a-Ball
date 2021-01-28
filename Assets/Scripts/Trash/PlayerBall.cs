using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekBrains
{
    public sealed class PlayerBall : Player
    {
        private void FixedUpdate()
        {
            Move();
        }
        public PlayerBall(float speed): base(speed)
        {

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
