using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucumberClick : MonoBehaviour

{
    [SerializeField] private GameObject WateringCan;
    public GameObject Nextcucumber;
    // Start is called before the first frame update

    private void Update()
    {
        WateringCan.SetActive(false);   
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        Debug.Log("Gurka Äten!");
        Nextcucumber.SetActive(true);
        Debug.Log("Gurka1 placed");
        Nextcucumber.transform.position = gameObject.transform.position;
    }
}
