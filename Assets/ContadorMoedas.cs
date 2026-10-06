using UnityEngine;
using TMPro; // Usar se estiveres usando TextMeshPro
using UnityEngine.UI; // Usar se estiveres usando Text UI legado

public class ContadorMoedas : MonoBehaviour
{
    public static ContadorMoedas Instancia;

    [Header("Configurações")]
    [SerializeField] private TextMeshProUGUI textoMoedasTMP; // Para TextMeshPro
    [SerializeField] private Text textoMoedasLegado;       // Para Text normal
    [SerializeField] private int moedasNecessarias = 5;

    private int moedasColetadas = 0;

    private void Awake()
    {
        if (Instancia == null)
            Instancia = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        AtualizarTextoUI();
    }

    public void AdicionarMoeda()
    {
        moedasColetadas++;
        AtualizarTextoUI();

        if (moedasColetadas >= moedasNecessarias)
        {
            Debug.Log("Você coletou 5 moedas!");
            // Aqui podes disparar algum evento extra se quiseres
        }
    }

    private void AtualizarTextoUI()
    {
        string mensagem = $"Moedas: {moedasColetadas} / {moedasNecessarias}";

        if (textoMoedasTMP != null)
            textoMoedasTMP.text = mensagem;

        if (textoMoedasLegado != null)
            textoMoedasLegado.text = mensagem;
    }

    public bool TemMoedasSuficientes()
    {
        return moedasColetadas >= moedasNecessarias;
    }
}