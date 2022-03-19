using UnityEngine;

public class Emeny : MonoBehaviour
{
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;

    private float speed;

    private void Start()
    {
        speed = Random.Range(_minSpeed, _maxSpeed);
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
