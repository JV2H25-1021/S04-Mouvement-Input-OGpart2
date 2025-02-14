using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControleRotationTranslationActionsDefaut : MonoBehaviour
{
    float angle;

    private void OnMove(InputValue valeur)
    {
        Debug.Log("Move a changé.");
        angle = valeur.Get<Vector2>().x;
    }

    private void Update()
    {
        transform.Rotate(0, angle * 60f * Time.deltaTime, 0); 
        //transform.Translate(0,0,1f*Time.deltaTime);
    }
}
