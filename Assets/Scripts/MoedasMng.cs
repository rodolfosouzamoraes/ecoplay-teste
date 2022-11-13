using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoedasMng : MonoBehaviour
{
    public AudioSource audioMoeda;
    public Text txtContegemMoedas;
    public int totalMoedas = 0;

    public void IncrementarContagemMoedas()
    {
        audioMoeda.Play();
        totalMoedas++;
        txtContegemMoedas.text = totalMoedas.ToString();
    }
}
