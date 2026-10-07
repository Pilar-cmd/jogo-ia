using UnityEngine;

public class Moeda : MonoBehaviour
{
    [SerializeField] private float velocidadeRotacao = 100f;

    private void Update()
    {
        // Faz a moeda girar continuamente no próprio eixo
        transform.Rotate(Vector3.up, velocidadeRotacao * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se quem tocou na moeda foi o Jogador
        if (other.CompareTag("Player"))
        {
            if (ContadorMoedas.Instancia != null)
            {
                ContadorMoedas.Instancia.AdicionarMoeda();
                Destroy(gameObject); // Destrói a moeda coletada
            }
            else
            {
                Debug.LogError("O script ContadorMoedas não foi encontrado na cena!");
            }
        }
    }
}