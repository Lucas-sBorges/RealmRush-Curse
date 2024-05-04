using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{   
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int(); 
    
    void Awake() 
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdadeObjectName();
        }
    }

    private void DisplayCoordinates()
    {   
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.x);
        label.text = $"{coordinates.x} , {coordinates.y}" ;
    }

    private void UpdadeObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }

    
}