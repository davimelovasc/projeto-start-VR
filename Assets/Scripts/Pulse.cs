using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pulse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject pulseInfo;
    public GameObject pulseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        //pulseInfo = GameObject.Find("HotSpots/photo01_sphere/pulse");
        //pulseCanvas = GameObject.Find("HotSpots/photo01_sphere/pulse/pulse_canvas");
        pulseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        pulseCanvas.SetActive(true);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pulseCanvas.SetActive(false);

    }
}
