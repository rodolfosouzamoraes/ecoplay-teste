using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BandeiraCtlr : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PnlFimDeJogoCtlr pnlFimDeJogoCtlr = FindObjectOfType<PnlFimDeJogoCtlr>();
            pnlFimDeJogoCtlr.ExibirPainel();
        }
    }
}
