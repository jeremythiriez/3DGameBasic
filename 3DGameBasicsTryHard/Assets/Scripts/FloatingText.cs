using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public Animator _animator;
    private TextMesh damageText;

    void OnEnable()
    {
        AnimatorClipInfo[] clipInfos = _animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfos[0].clip.length);
        damageText = _animator.GetComponent<TextMesh>();
    }

    public void SetText(string text)
    {
        damageText.text = text;
    }
}
