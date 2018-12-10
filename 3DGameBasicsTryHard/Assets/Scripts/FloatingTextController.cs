using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour
{

    private static FloatingText _popupText;
    private static FloatingText _popupTextCrit;
    
    public static void Initialize()
    {
        if (!_popupText){
            _popupText = Resources.Load<FloatingText>("Prefabs/PopupTextParent");
        }

        if (!_popupTextCrit)
        {
            _popupTextCrit = Resources.Load<FloatingText>("Prefabs/PopupTextParentCrit");
        }
    }
    
    public static void CreateFloatingText(string text, Collider location, bool crit)
    {
        FloatingText instance;
        if (crit)
        {
            instance = Instantiate(_popupTextCrit);
        }
        else
        {
            instance = Instantiate(_popupText);   
        }

        Vector3 screenPosition;

        if (location.CompareTag("MonsterBody"))
        {
            screenPosition = new Vector3(location.transform.position.x, location.transform.position.y + 2.3f, location.transform.position.z);
        }
        else
        {
            screenPosition = new Vector3(location.transform.position.x, location.transform.position.y + 0.5f, location.transform.position.z);
        }

        instance.transform.position = screenPosition;
        instance.transform.rotation = Quaternion.LookRotation(instance.transform.position - Camera.main.transform.position);
        instance.SetText(text);
    }
}
