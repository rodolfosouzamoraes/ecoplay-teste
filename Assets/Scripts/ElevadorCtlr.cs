using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevadorCtlr : MonoBehaviour
{
    public Animator animatorElevador;
    bool isElevadorMovimentando = false;
    bool isElevadorEmBaixo = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(isElevadorMovimentando == false)
            {
                if(isElevadorEmBaixo == true)
                {
                    animatorElevador.SetTrigger("SubirElevador");
                }
                else
                {
                    animatorElevador.SetTrigger("DescerElevador");
                }
                isElevadorMovimentando = true;
            }
        }
    }

    public void ElevadorSubiu()
    {
        isElevadorMovimentando = false;
        isElevadorEmBaixo = false;
    }

    public void ElevadorDesceu()
    {
        isElevadorMovimentando = false;
        isElevadorEmBaixo = true;
    }
}
