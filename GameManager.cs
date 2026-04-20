using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Padrão Singleton: permite que este script seja facilmente acessado de qualquer outro script
    public static GameManager instance;

    [Header("Configurações de Respawn")]
    [Tooltip("Onde a bola deve nascer/renascer.")]
    public Transform pontoDeRespawn;

    [Tooltip("O prefab da bola que será criado.")]
    public GameObject prefabDaBola;

    private void Awake()
    {
        // Configuração do Singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Cria a primeira bola no início do jogo
        if (prefabDaBola != null && pontoDeRespawn != null)
        {
            Instantiate(prefabDaBola, pontoDeRespawn.position, pontoDeRespawn.rotation);
        }
    }

    public void RespawnBola()
    {
        // Função que será chamada quando a bola "morrer"
        Instantiate(prefabDaBola, pontoDeRespawn.position, pontoDeRespawn.rotation);
    }
}