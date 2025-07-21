using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStack : MonoBehaviour
{

    public List<Transform> stackedEnemies = new List<Transform>();
    public float stackHeight = 1f;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Colidiu com >>> " + other.name);
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("entrou iff ");
            Transform enemy = other.transform;


            if (enemy.GetComponent<Rigidbody>())
                Destroy(enemy.GetComponent<Rigidbody>());
            if (enemy.GetComponent<Collider>())
                Destroy(enemy.GetComponent<Collider>());
            if (enemy.GetComponent<BoxCollider>())
                Destroy(enemy.GetComponent<BoxCollider>());

 
            Vector3 stackPos = transform.position + Vector3.up * (stackedEnemies.Count + 1) * stackHeight;
            enemy.position = stackPos;

      
            enemy.SetParent(this.transform);
            stackedEnemies.Add(enemy);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
