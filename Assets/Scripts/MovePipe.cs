using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f; // Speed of the pipe movement

    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime; // Move the pipe to the left
    }
}
