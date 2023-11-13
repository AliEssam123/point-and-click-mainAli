using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfManager : MonoBehaviour
{
    public int currentShelf = 0;
    public GameObject[] shelves; // Array of shelf prefabs
    public GameObject holder; // The object that holds the shelves
 

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shelves[0], holder.transform.position, holder.transform.rotation, holder.transform);
    }

    public void ChangeShelf(int direction)
    {
        if (currentShelf + direction < 0)
        {
            currentShelf = shelves.Length - 1;
        }
        else if (currentShelf + direction > shelves.Length - 1)
        {
            currentShelf = 0;
        }
        else
        {
            currentShelf += direction;
        }

        // Destroy the current shelf and spawn the new one
        Destroy(holder.transform.GetChild(0).gameObject);
        Instantiate(shelves[currentShelf], holder.transform.position, holder.transform.rotation, holder.transform);
    }

    public void ChangeMaterial(Material material)
    {
        shelves[currentShelf].transform.GetChild(0).GetComponent<MeshRenderer>().material = material;
        Destroy(holder.transform.GetChild(0).gameObject);
        Instantiate(shelves[currentShelf], holder.transform.position, holder.transform.rotation, holder.transform);
    }
}
