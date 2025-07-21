using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollector : MonoBehaviour
{
    public float collectRadius = 1.5f;
    public List<Transform> stackedEnemies = new List<Transform>();
    public float stackHeight = 1f;

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, collectRadius);

        foreach (Collider hit in hits)
        {
            if (hit.CompareTag("Enemy") && !stackedEnemies.Contains(hit.transform))
            {
                Transform enemy = hit.transform;


                if (enemy.GetComponent<Rigidbody>()) Destroy(enemy.GetComponent<Rigidbody>());
                if (enemy.GetComponent<Collider>()) Destroy(enemy.GetComponent<Collider>());

         
                Vector3 stackPos = transform.position + transform.up * (stackedEnemies.Count * stackHeight);
                enemy.position = stackPos;

        
                enemy.SetParent(this.transform);
                stackedEnemies.Add(enemy);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, collectRadius);
    }
}
