using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucumberPos : MonoBehaviour
{

    [SerializeField] private GameObject Cucumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cucumber.transform.position = gameObject.transform.position + Vector3.up;
    }
}
