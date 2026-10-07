using UnityEngine;
using TMPro;

public class ContadorMoedas : MonoBehaviour
{
    public static ContadorMoedas Instancia;

    [Header("Configurações")]
    [SerializeField] private TextMeshProUGUI textoMoedasTMP;
    [SerializeField] private int moedasNecessarias = 5;

    private int moedasColetadas = 0;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
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
            Debug.Log("Parabéns! Você coletou 5 moedas!");
        }
    }

    private void AtualizarTextoUI()
    {
        if (textoMoedasTMP != null)
        {
            textoMoedasTMP.text = $"Moedas: {moedasColetadas} / {moedasNecessarias}";
        }
    }

    public bool TemMoedasSuficientes()
    {
        return moedasColetadas >= moedasNecessarias;
    }
}