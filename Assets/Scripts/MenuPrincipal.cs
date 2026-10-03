using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Função para o botão "Começar Sonho"
    public void ComecarSonho()
    {
        SceneManager.LoadScene("jogo");
    }

    // Função para o botão "Como Jogar"
    public void ComoJogar()
    {
        SceneManager.LoadScene("como_jogar");
    }
}