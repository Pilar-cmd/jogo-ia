using UnityEngine;
using UnityEngine.SceneManagement;

public class ComoJogarManager : MonoBehaviour
{
    // Troque "Menu" pelo nome EXATO da sua cena de menu principal
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}