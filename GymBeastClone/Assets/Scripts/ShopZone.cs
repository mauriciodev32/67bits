using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopZone : MonoBehaviour
{
    public int itemCost = 30;

    void OnTriggerEnter(Collider other)
    {
        PlayerDinheiro wallet = other.GetComponent<PlayerDinheiro>();

        if (wallet != null)
        {
            if (wallet.dinheiro >= itemCost)
            {
                wallet.dinheiro -= itemCost;
                Debug.Log("Comprou item por $" + itemCost);
                // Aqui você pode aplicar um upgrade, tipo aumentar velocidade
            }
            else
            {
                Debug.Log("Dinheiro insuficiente para comprar item.");
            }
        }
    }
}
