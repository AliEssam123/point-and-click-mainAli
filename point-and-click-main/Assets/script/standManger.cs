using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standManger : MonoBehaviour
{

    public int currentStand = 0;
    public GameObject[] stand;
    public GameObject holderTv�;
   


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(stand[0], holderTv�.transform.position, holderTv�.transform.rotation, holderTv�.transform);

    }

    public void Changed(int direction)
    {
        if (currentStand + direction < 0)
        {
            currentStand = stand.Length - 1;
        }
        else if (currentStand + direction > stand.Length - 1)
        {
            currentStand = 0;
        }
        else
        {
            currentStand = currentStand + direction;
        }
        Destroy(holderTv�.transform.GetChild(0).gameObject);
        Instantiate(stand[currentStand], holderTv�.transform.position, holderTv�.transform.rotation, holderTv�.transform);
    }

    public void ChangeMaterial(Material material)
    {
        stand[currentStand].transform.GetChild(0).GetComponent<MeshRenderer>().material = material;
        Destroy(holderTv�.transform.GetChild(0).gameObject);
        Instantiate(stand[currentStand], holderTv�.transform.position, holderTv�.transform.rotation, holderTv�.transform);
    }
}