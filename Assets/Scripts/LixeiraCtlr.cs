using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraCtlr : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CanvasGameMng canvasGameMng = FindObjectOfType<CanvasGameMng>();
            canvasGameMng.ExibirInteracao();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CanvasGameMng canvasGameMng = FindObjectOfType<CanvasGameMng>();
            canvasGameMng.OcultarInteracao();
        }
    }
}
