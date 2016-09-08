using UnityEngine;
using System.Collections;

public class Scarecrow1 : MonoBehaviour
{
    public int clickLayer = 8;
    public int blockLayer = 9;

    void Start()
    {
    }


    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            Vector3 touchPosition = touch.position;

            Ray ray = Camera.main.ScreenPointToRay(touchPosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, 100f))
            {
            }

            Vector3 mousenow = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z + 0.02f);
            GameObject.Find("Button 1").SendMessage("rejudge", mousenow, SendMessageOptions.DontRequireReceiver);
        }
    }
}


    //
   