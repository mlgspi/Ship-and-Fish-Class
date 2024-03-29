using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;

public class FishCollector : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    List<GameObject> prefabs;
    List<GameObject> fishList;

    public List<GameObject> FishList { get { return fishList; } }

    // Start is called before the first frame update
    void Start()
    {
        fishList = new List<GameObject>();
        prefabs = new List<GameObject>() { prefab1, prefab2, prefab3 };
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetMouseButtonDown(1))
        {
            GameObject fish = Instantiate<GameObject>(prefabs[(Random.Range(0, 50) + Random.Range(50, 100)) % 3]);
            fish.transform.position = worldPosition;
            //Debug.Log(fish.transform.position);
            fishList.Add(fish);
        }
    }
}
