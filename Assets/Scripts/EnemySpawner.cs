using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _emeny;

    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i] = transform.GetChild(i);
        }

        StartCoroutine(SpawnEnemies(_emeny, 2));
    }

    private IEnumerator SpawnEnemies(GameObject enemy, int period)
    {
        while (true)
        {
            for (int i = 0; i < _spawnPoints.Length; i++)
            {
                int randomYRotation = Random.Range(0, 360);
                Instantiate(enemy, _spawnPoints[i].position, Quaternion.Euler(new Vector3(0, randomYRotation, 0)));

                yield return new WaitForSeconds(period);
            }
        }
    }
}
