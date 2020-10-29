using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    [SerializeField] float _speed = 3f;
    // Start is called before the first frame update
    //static int _enemyCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (Time.deltaTime * _speed, 0, 0);
    }

    // void OnTriggerEnter2D(Collider2D collider) {
    //     Destroy(gameObject);

    //     if (collider.gameObject.name == "Player")
    //         GameState.Instance.InitiateGameOver();

    //     Destroy(collider.gameObject);
    //     GameState.Instance.IncreaseScore(10);
    // }
}
