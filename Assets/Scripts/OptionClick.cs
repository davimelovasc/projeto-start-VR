using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OptionClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject option = eventData.pointerCurrentRaycast.gameObject;
        GameObject optionsGO = option.transform.parent.gameObject;
        GameObject currentSphere = optionsGO.transform.parent.gameObject;

        bool correct = Utils.checkAnswer(currentSphere.name.ToLower(), option.name.ToLower());
        Debug.Log(correct);
        //check answer passing option.name.toLower() , currentSphere.name.toLower()
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
