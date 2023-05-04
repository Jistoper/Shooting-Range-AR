using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    [HideInInspector] public bool objectPlaced = false;
    public bool useCursor = true;

    public GameObject cursorChildObject;
    [HideInInspector] private GameObject placedObject;
    public GameObject objectToPlace;

    public ARRaycastManager raycastManager;
    [HideInInspector] static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        cursorChildObject.SetActive(useCursor);
    }

    void Update()
    {
        if (useCursor)
        {
            UpdateCursor();
        }
    }

    public void placingObject()
    {
        placedObject = Instantiate(objectToPlace, transform.position, transform.rotation);
        useCursor = false;
        objectPlaced = true;
    }

    public void destroyingObject()
    {
        if (objectPlaced)
        {
            Destroy(placedObject);
            objectPlaced = false;
            useCursor = true;
        }
    }

    void UpdateCursor()
    {
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
        raycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }
}
