using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Substitua "NomeDaCenaMenu" pelo nome exato da sua cena de menu
    public void VoltarParaMenu()
    {
        SceneManager.LoadScene("NomeDaCenaMenu");
    }
}