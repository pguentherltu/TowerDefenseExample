using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    public void OnClick()
    {
        Buildable b = GetComponentInParent<Buildable>();
        b.HideMenu();
    }
}
