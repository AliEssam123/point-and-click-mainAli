using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standManger : MonoBehaviour
{

    public int currentStand = 0;
    public GameObject[] stand;
    public GameObject holderTvå;
   


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(stand[0], holderTvå.transform.position, holderTvå.transform.rotation, holderTvå.transform);

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
        Destroy(holderTvå.transform.GetChild(0).gameObject);
        Instantiate(stand[currentStand], holderTvå.transform.position, holderTvå.transform.rotation, holderTvå.transform);
    }

    public void ChangeMaterial(Material material)
    {
        stand[currentStand].transform.GetChild(0).GetComponent<MeshRenderer>().material = material;
        Destroy(holderTvå.transform.GetChild(0).gameObject);
        Instantiate(stand[currentStand], holderTvå.transform.position, holderTvå.transform.rotation, holderTvå.transform);
    }
}