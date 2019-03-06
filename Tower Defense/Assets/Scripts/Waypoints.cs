using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;

    void Awake()
    {
        points = new Transform[transform.childCount];

        for (int index = 0; index < points.Length; index++)
        {
            points[index] = transform.GetChild(index);
        }
    }
}
