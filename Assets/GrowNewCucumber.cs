using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GrowNewCucumber : MonoBehaviour
{
    [SerializeField] private GameObject Gurka;
    private int timesGrown;
    public TextMeshProUGUI tidtext;
    public AudioSource WaterSwirl;
    private void Start()
    {
        timesGrown = 0;
    }

    private void OnEnable()
    {
       tidtext.GetComponent<Timer>().enabled = true;

    }

    private void OnMouseDown()
    {
        Gurka.SetActive(true);
        timesGrown++;
        WaterSwirl.Play();
        Debug.Log(timesGrown);
    }
}
