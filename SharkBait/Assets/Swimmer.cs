using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimmer : MonoBehaviour
{
    [SerializeField] float _speed = 1.5f;
    // Start is called before the first frame update
    //static int _enemyCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (Time.deltaTime * _speed, 0, 0);
        if (gameObject.transform.position.x <= -20f){
            Destroy(gameObject);
        }
    }

    // void OnTriggerEnter2D(Collider2D collider) {
    //     GameState.Instance.IncreaseScore(10);
    //     Destroy(gameObject);
        
    // }
            
}
