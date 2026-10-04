using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour
{
    [SerializeField] private List<Vector3> direction = new List<Vector3> { Vector3.right, Vector3.left, Vector3.up, Vector3.down };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach (Transform child in transform)
        {
            child.Translate(direction[Random.Range(0, direction.Count)] * Time.deltaTime);
        }
    }
}
