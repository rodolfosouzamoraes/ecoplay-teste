using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using StarterAssets;
public class PnlFimDeJogoCtlr : MonoBehaviour
{
    public GameObject pnlFimDeJogo;
    public Text txtTotalMoedas;

    public void ExibirPainel()
    {
        StarterAssetsInputs starterAssets = FindObjectOfType<StarterAssetsInputs>();
        starterAssets.SetCursorState(false);

        ThirdPersonController thirdPersonController = FindObjectOfType<ThirdPersonController>();
        thirdPersonController.isMove = false;

        pnlFimDeJogo.SetActive(true);
        txtTotalMoedas.text = $"x{FindObjectOfType<MoedasMng>().totalMoedas}";
    }

    public void Sair()
    {
        SceneManager.LoadScene(0);
    }
    public void Continuar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
