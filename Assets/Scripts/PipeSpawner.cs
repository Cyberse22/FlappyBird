using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f; // Maximum time between spawns
    [SerializeField] private float _heighRanger = 0.45f; // Minimum time between spawns
    [SerializeField] private GameObject _pipe; // Prefab of the pipe to spawn

    private float _timer; // Timer to track time between spawns

    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }
    // Update is called once per frame
    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime; // Increment the timer by the time since the last frame
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-_heighRanger, _heighRanger));
        GameObject pipe = Instantiate(_pipe, spawnPosition, Quaternion.identity);

        Destroy(pipe, 10f); // Destroy the pipe after 10 seconds
    }


}
