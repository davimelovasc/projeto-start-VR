using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Info : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

     public GameObject canvasInformation;
     public Text information;
     public Text informationModify;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
        information.text = informationModify.text;
        information.fontSize = informationModify.fontSize;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {


        canvasInformation.GetComponent<Canvas>().enabled = true;

    }

    public void OnPointerExit(PointerEventData eventData)
    {

        canvasInformation.GetComponent<Canvas>().enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}
