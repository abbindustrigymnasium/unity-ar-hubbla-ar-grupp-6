using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class signtext : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject Skylt;
    
    private void OnMouseDown() 
    {
        textMeshPro.text = "En 'Västeråsgurka' är en sorts inlagd gurka som har sitt ursprung i staden Västerås i Sverige. Den är känd för sin lite söta smak och krispighet, och tillverkas traditionellt genom att man inlägger gurkor i en lag av vatten, ättika, socker och kryddor såsom dill och senapsfrön. Västeråsgurkor är en populär del av det svenska matkulturarvet och kan ofta hittas i svenska livsmedelsbutiker och restauranger.";
        Skylt.SetActive(true);
    }
    
}
