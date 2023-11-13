using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public standManger stand;
    public ShelfManager shelf;

    public Material[] standMaterials;
    public Material[] shelfMaterials;
    public int currentStandMaterial = 0;
    public int currentShelfMaterial = 0;

    void Start()
    {
        stand = FindAnyObjectByType<standManger>();
        shelf = FindAnyObjectByType<ShelfManager>();
    }

    public void ChangeStandMaterial(int direction)
    {
        currentStandMaterial += direction;

        if (currentStandMaterial < 0)
        {
            currentStandMaterial = standMaterials.Length - 1;
        }
        else if (currentStandMaterial > standMaterials.Length - 1)
        {
            currentStandMaterial = 0;
        }

        stand.ChangeMaterial(standMaterials[currentStandMaterial]);
    }

    public void ChangeShelfMaterial(int direction)
    {
        currentShelfMaterial += direction;

        if (currentShelfMaterial < 0)
        {
            currentShelfMaterial = shelfMaterials.Length - 1;
        }
        else if (currentShelfMaterial > shelfMaterials.Length - 1)
        {
            currentShelfMaterial = 0;
        }

        shelf.ChangeMaterial(shelfMaterials[currentShelfMaterial]);
    }
}
