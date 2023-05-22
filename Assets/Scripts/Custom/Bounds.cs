using UnityEngine;

public class Bounds : MonoBehaviour
{
    Collider m_Collider;
    Vector3 m_Center;
    Vector3 m_Size, m_Min, m_Max, m_Extents;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            
            //Fetch the Collider from the GameObject
            m_Collider = GetComponent<Collider>();
            //Fetch the center of the Collider volume
            m_Center = m_Collider.bounds.center;
            //Fetch the size of the Collider volume
            m_Size = m_Collider.bounds.size;
            //Fetch the minimum and maximum bounds of the Collider volume
            m_Min = m_Collider.bounds.min;
            m_Max = m_Collider.bounds.max;
            //Output this data into the console
            m_Extents = m_Collider.bounds.extents;
            OutputData();
        }
    }

    void OutputData()
    {
        //Output to the console the center and size of the Collider volume
        Debug.Log("Collider Center : " + m_Center);
        Debug.Log("Collider Size : " + m_Size);
        Debug.Log("Collider bound Minimum : " + m_Min);
        Debug.Log("Collider bound Maximum : " + m_Max);
        Debug.Log("Collider bound Extents : " + m_Extents);
    }
}