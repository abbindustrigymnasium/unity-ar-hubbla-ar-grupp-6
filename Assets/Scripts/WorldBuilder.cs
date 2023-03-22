using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class WorldBuilder : MonoBehaviour
{
    [SerializeField]
    ARPlaneManager planeManager;
    [SerializeField]
    ARRaycastManager raycastManager;
    [SerializeField]
    GameObject floorPrefab;
    [SerializeField]
    GameObject FlowerPot;
    [SerializeField]
    GameObject WateringCan;
    

    List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    void Update()
    {
        if (raycastManager.Raycast(new Vector2(Screen.height/2, Screen.width/2), raycastHits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinBounds))
        {
            ARPlane plane = planeManager.GetPlane(raycastHits[0].trackableId);
            if (plane.size.y > 1 && plane.size.x > 1)
            {
                CreateGameSpace(plane);
                enabled = false;
            }
        }
    }

    void CreateGameSpace(ARPlane plane)
    {
        Instantiate(floorPrefab, plane.center, Quaternion.identity);

        FlowerPot.transform.position = plane.center;
        FlowerPot.SetActive(true);
        Debug.Log(FlowerPot + " placed");

        WateringCan.transform.position = plane.center + Vector3.left;
        WateringCan.SetActive(true);
    }
}
