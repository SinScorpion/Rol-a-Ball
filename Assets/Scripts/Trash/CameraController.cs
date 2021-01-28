using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekBrains
{
    public class CameraController : MonoBehaviour
    {
        public Player Player;
        private Vector3 _offset;

        // Start is called before the first frame update
        void Start()
        {
            _offset = transform.position - Player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = Player.transform.position + _offset;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
