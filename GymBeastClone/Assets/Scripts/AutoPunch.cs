using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPunch : MonoBehaviour
{

    public float attackRange = 1.5f;


    void Start()
    {
            
    }


    void Update()
    {
        Collider[] enemies = Physics.OverlapSphere(transform.position, attackRange);
        foreach (Collider col in enemies) 
        {
            if (col.CompareTag("Enemy")) 
            {
                Debug.Log("Inimigo atingido: "+col.name);
                Destroy(col.gameObject);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        //Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
