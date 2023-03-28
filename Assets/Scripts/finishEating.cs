using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class finishEating : MonoBehaviour
{
    [SerializeField] private GameObject WateringCan;
    public TextMeshProUGUI CucumberText;
    public static int CucumberInt;


    private void Start()
    {
        CucumberInt = 0;
    }

    private void OnMouseDown()
    {
        CucumberInt++;
        GurkaIntAdd(CucumberInt.ToString());
        gameObject.SetActive(false);
        Debug.Log("YUMMY!");
        WateringCan.SetActive(true);
    }

    public void GurkaIntAdd(string num)
    {
        num = CucumberInt.ToString();
        CucumberText.text = num;
    }
}
