namespace Coreficent.Controller
{
    using UnityEngine;

    public class ButterflyController : MonoBehaviour
    {

        [SerializeField] private float _speed = 1.0f;

        private Rigidbody _rigidbody;

        private Vector3 _possitionFinal = Vector3.zero;

        protected void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void FixedUpdate()
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
            _rigidbody.MovePosition(transform.position + _possitionFinal);
        }
    }
}
