using UnityEngine;

public class Key : MonoBehaviour
{
    public float rotateSpeed = 0.1f;
    public string keyID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys playerKeys = other.GetComponent<PlayerKeys>();
            if (playerKeys != null)
            {
                playerKeys.AddKey(keyID);
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {

    }
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 150f, 0) * Time.deltaTime, Space.World);
    }
}