using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject spawnpoint;

    private void Start()
    {
        player.SetActive(true);
        player.transform.position = spawnpoint.transform.position;
        player.transform.rotation = spawnpoint.transform.rotation;
        print("S");
    }
}
