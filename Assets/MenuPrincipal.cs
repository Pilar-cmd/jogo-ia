using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca necessária para carregar outras cenas

public class MenuPrincipal : MonoBehaviour
{
    // Função que será chamada ao clicar no botão "Começar Sonho"
    public void ComecarSonho()
    {
        SceneManager.LoadScene("jogo");
    }
}
