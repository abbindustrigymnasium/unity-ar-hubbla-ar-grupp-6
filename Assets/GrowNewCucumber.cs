using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GrowNewCucumber : MonoBehaviour
{
    [SerializeField] private GameObject Gurka;
    private int timesGrown;
    private void Start()
    {
        timesGrown = 0;
    }

    private void OnMouseDown()
    {
        Gurka.SetActive(true);
        timesGrown++;

        Debug.Log(timesGrown);
    }
}
