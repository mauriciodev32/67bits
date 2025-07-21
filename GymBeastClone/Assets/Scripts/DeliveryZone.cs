using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class DeliveryZone : MonoBehaviour
{
    public int valorPorInimigo = 10;

    void OnTriggerEnter(Collider other)
    {
        EnemyCollector collector = other.GetComponent<EnemyCollector>();
        PlayerDinheiro dinDin = other.GetComponent<PlayerDinheiro>();

        if (collector != null && dinDin != null && collector.stackedEnemies.Count > 0)
        {
            int amount = collector.stackedEnemies.Count;
            int totalDinDin = amount * valorPorInimigo;

            dinDin.AddDinheiro(totalDinDin);
            Debug.Log("Recebeu $ " + totalDinDin + "por entregar " + amount + " inimigos!");
            Debug.Log("Entregue " + amount + " inimigos!");

            foreach (Transform enemy in collector.stackedEnemies)
            {
                Destroy(enemy.gameObject); 
            }

            collector.stackedEnemies.Clear();
        }
    }
}
