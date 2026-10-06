using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaFim : MonoBehaviour
{
    [SerializeField] private string nomeDaCenaFim = "fim";

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se quem atravessou foi o Jogador
        if (other.CompareTag("Player"))
        {
            // Liberta o cursor antes de mudar para a cena final
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            SceneManager.LoadScene(nomeDaCenaFim);
        }
    }
}