using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class PlayerDinheiro : MonoBehaviour
{
    public int dinheiro = 0;
    public void AddDinheiro(int dinDin) 
    { 
        dinheiro += dinDin;
        Debug.Log("Meu Dinheiro atual: $" + dinheiro);
    }
}
