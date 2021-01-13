namespace Coreficent.Controller
{
    using UnityEngine;

    // controls butterfly movements with user input
    public class ButterflyController : MonoBehaviour
    {

        [SerializeField] private float _speed = 1.0f;

        private Vector3 _possitionFinal = Vector3.zero;

        protected void Start()
        {

        }

        protected void Update()
        {
            _possitionFinal = Vector3.zero;
            if (Input.GetKey(KeyCode.Q))
            {
                _possitionFinal.z += _speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.E))
            {
                _possitionFinal.z += -_speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                _possitionFinal.y += _speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                _possitionFinal.y += -_speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                _possitionFinal.x += _speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                _possitionFinal.x += -_speed * Time.deltaTime;
            }
            transform.position += _possitionFinal;
        }
    }
}
