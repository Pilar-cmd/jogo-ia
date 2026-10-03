using UnityEngine;
using UnityEngine.SceneManagement;

public class DerrotaMenu : MonoBehaviour
{
    // Substitua "Menu" pelo nome exato da sua cena de menu principal
    [SerializeField] private string nomeDaCenaMenu = "Menu";

    public void VoltarAoMenu()
    {
        SceneManager.LoadScene(nomeDaCenaMenu);
    }
}
