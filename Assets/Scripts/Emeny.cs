using UnityEngine;

public class Emeny : MonoBehaviour
{
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;

    private float _speed;

    private void Start()
    {
        _speed = Random.Range(_minSpeed, _maxSpeed);
    }

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
