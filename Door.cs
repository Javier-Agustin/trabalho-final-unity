using UnityEngine;

public class Door : MonoBehaviour
{
    public string requiredKey; //aqui vai criar um campo na interface da unity e tu só coloca o id da chave que desbloqueia a porta

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys playerKeys = other.GetComponent<PlayerKeys>();
            if (playerKeys != null && playerKeys.HasKey(requiredKey))
            {
                gameObject.SetActive(false); 
                Debug.Log("Porta aberta com chave: " + requiredKey);
            }
        }
    }
}
