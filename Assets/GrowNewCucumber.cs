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
        AudioManager.instance.Play("Watering");
        Gurka.SetActive(true);
        timesGrown++;

        Debug.Log(timesGrown);
    }
}
