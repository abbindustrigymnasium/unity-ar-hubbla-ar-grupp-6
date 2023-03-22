using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GrowNewCucumber : MonoBehaviour
{
    [SerializeField] private GameObject Gurka;
    private int timesGrown;
    public TextMeshProUGUI NoWater;

    private void Start()
    {
        timesGrown = 0;
        NoWater.text = "";
    }

    private void OnMouseDown()
    {
        if (timesGrown < 3)
        {
            Gurka.SetActive(true);
            timesGrown++;
        }
        else
        {
            NoWater.text = "Slut På Vatten!";
            StartCoroutine(Countdown());
        }
        Debug.Log(timesGrown);
    }

    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1.5f); 
        NoWater.text = "";
    }
}
