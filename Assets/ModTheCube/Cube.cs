using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float rotationSpeed;
    private Vector3 rotationAxis;
    private Vector3 translationAxis;
    private Vector3 scalingAxis;
    private Color colorChange;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        rotationSpeed = Random.Range(10, 30);
        rotationAxis = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        translationAxis = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        scalingAxis = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        colorChange = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
    
    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
        transform.Translate(translationAxis * Time.deltaTime, Space.World);
        transform.localScale += scalingAxis * Time.deltaTime;
        Renderer.material.color += colorChange * Time.deltaTime;
    }

}
