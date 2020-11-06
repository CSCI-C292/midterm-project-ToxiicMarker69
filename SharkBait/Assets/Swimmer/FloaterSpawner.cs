using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterSpawner : MonoBehaviour
{
    float _ySpawn; 
    float _xSpawn;
    [SerializeField] GameObject _enemyPrefab;
    
    void Start()
    {

        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, .5f,0)).y;
        _xSpawn = Camera.main.ViewportToWorldPoint(new Vector3(1.9f, 0,0)).x;

        InvokeRepeating("SpawnEnemy", 0, 14f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy() {
        Instantiate(_enemyPrefab, new Vector3(_xSpawn,_ySpawn, 0) , Quaternion.identity, this.transform);
    }
}
