using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    void Update()
    {
        // خلّي العنصر ده يبص على الكاميرا الرئيسية
        if (Camera.main != null)
        {
            transform.LookAt(Camera.main.transform);
          //  transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180f, 0);

        }
    }
}
