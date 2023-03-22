using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class finishEating : MonoBehaviour
{
    [SerializeField] private GameObject WateringCan;
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        Debug.Log("YUMMY!");
        WateringCan.SetActive(true);
    }
}
