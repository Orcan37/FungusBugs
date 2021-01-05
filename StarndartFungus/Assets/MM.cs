using UnityEngine;

public class MM : MonoBehaviour
{ 
    void Start()
    {
        GameObject prefab = Resources.Load<GameObject>("TestResourcesFlowchart");
        GameObject go = Instantiate(prefab) as GameObject; 
        go.name = "TestResourcesFlowchart";
    }
 
}
