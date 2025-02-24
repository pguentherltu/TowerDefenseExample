using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTowerButton : MonoBehaviour
{
    public GameObject TowerPrefab;

    public void OnClick()
    {
        Transform tile = GameObject.Find("BuildMenu(Clone)").transform.parent;
        Debug.Log($"Creating tower at {tile.position}, tile name {tile.name}");
        Instantiate(TowerPrefab, tile.position, tile.rotation, null);

        //destroy the menu
        Buildable b = GetComponentInParent<Buildable>();
        b.HideMenu();
    }
}
