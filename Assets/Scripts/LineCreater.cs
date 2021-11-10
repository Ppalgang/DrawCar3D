using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreater : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;
    public GameObject player;
    private Vector3 createdVector;
    public GameObject wheel;
    public GameObject currentWheel;

    void Update()
    {
        if (Input.mousePosition.x > 510 && Input.mousePosition.x < 1410 && Input.mousePosition.y > 30 && Input.mousePosition.y < 500)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartLine();
            }
            if (Input.GetMouseButton(0))
            {
                CreateLine();
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }

    }
    
    private void StartLine()
    {
        int childs = player.transform.childCount;
        for (int i = 0; i < childs; i++)
        {
            if (i == 0)
            {

            }
            else
            {
                Destroy(player.transform.GetChild(i).gameObject);
            }
        }

    }
    private void CreateLine()
    {
        createdVector = player.transform.position;
        createdVector.x += Input.mousePosition.x/160 -5;
        createdVector.y += Input.mousePosition.y / 190;
        currentLine = Instantiate(linePrefab, createdVector, Quaternion.identity);
        currentLine.transform.parent = player.transform;
    }

    private void FinishLine()
    {
        int child = player.transform.childCount;
        currentWheel = Instantiate(wheel, player.transform.GetChild(1).position, Quaternion.Euler(0,90,0));
        currentWheel.transform.parent = player.transform.GetChild(1);
        currentWheel = Instantiate(wheel, player.transform.GetChild(child-1).position, Quaternion.Euler(0, 90, 0));
        currentWheel.transform.parent = player.transform.GetChild(child-1);
    }

}
