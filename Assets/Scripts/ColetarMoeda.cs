using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarMoeda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            MoedasMng moedasMng = FindObjectOfType<MoedasMng>();
            moedasMng.IncrementarContagemMoedas();
            gameObject.SetActive(false);
        }
    }

    public void ExibirMoeda()
    {
        gameObject.SetActive(true);
    }
}
