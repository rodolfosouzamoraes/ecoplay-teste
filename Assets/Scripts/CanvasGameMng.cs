using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGameMng : MonoBehaviour
{
    public GameObject txtAperteE;
    public bool isInteracaoExibida = false;
    private StarterAssetsInputs _input;
    private void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }
    public void ExibirInteracao()
    {
        isInteracaoExibida = true;
        txtAperteE.SetActive(true);
    }
    public void OcultarInteracao()
    {
        isInteracaoExibida = false;
        txtAperteE.SetActive(false);
    }

    private void Update()
    {

    }
}
