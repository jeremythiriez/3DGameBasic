using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour
{

    private static FloatingText _popupText;
    private static GameObject _canvas;
    
    public static void Initialize()
    {
        _canvas = GameObject.Find("Canvas");
        if (!_popupText){
            _popupText = Resources.Load<FloatingText>("Prefabs/PopupTextParent");
        }
    }
    
    public static void CreateFloatingText(string text, Transform location)
    {
        FloatingText instance = Instantiate(_popupText);
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(location.position);
        //Vector3 screenPosition = new Vector3(location.position.x, location.position.y + 1, location.position.z);
        
        instance.transform.SetParent(_canvas.transform, false);
        instance.transform.position = screenPosition;
        instance.transform.rotation *= Quaternion.Euler(0, 90, 0); 
        instance.SetText(text);
    }
}
