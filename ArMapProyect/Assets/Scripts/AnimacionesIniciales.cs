using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesIniciales : MonoBehaviour
{
    public GameObject letreroAzul1, letreroAzul2, letreroAzul3, letreroAzul4;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        ComponentesTransparentes();
    }

    // Update is called once per frame
    void Update()
    {
        if (contador < 60)
        {
            contador += 1;
        }
        else
        {
            fadeInTransition();
        }
    }

    public void ComponentesTransparentes()
    {
        letreroAzul1.GetComponent<Renderer>().material.color = new Color(
            letreroAzul1.GetComponent<Renderer>().material.color.r,
            letreroAzul1.GetComponent<Renderer>().material.color.g,
            letreroAzul1.GetComponent<Renderer>().material.color.b,
            0.0f);
        letreroAzul2.GetComponent<Renderer>().material.color = new Color(
            letreroAzul2.GetComponent<Renderer>().material.color.r,
            letreroAzul2.GetComponent<Renderer>().material.color.g,
            letreroAzul2.GetComponent<Renderer>().material.color.b,
            0.0f);
        letreroAzul3.GetComponent<Renderer>().material.color = new Color(
            letreroAzul3.GetComponent<Renderer>().material.color.r,
            letreroAzul3.GetComponent<Renderer>().material.color.g,
            letreroAzul3.GetComponent<Renderer>().material.color.b,
            0.0f);
        letreroAzul4.GetComponent<Renderer>().material.color = new Color(
            letreroAzul4.GetComponent<Renderer>().material.color.r,
            letreroAzul4.GetComponent<Renderer>().material.color.g,
            letreroAzul4.GetComponent<Renderer>().material.color.b,
            0.0f);
    }

    public void fadeInTransition()
    {
        if (letreroAzul1.GetComponent<Renderer>().material.color.a < 1f)
        {
            letreroAzul1.GetComponent<Renderer>().material.color = new Color(letreroAzul1.GetComponent<Renderer>().material.color.r, letreroAzul1.GetComponent<Renderer>().material.color.g, letreroAzul1.GetComponent<Renderer>().material.color.b, letreroAzul1.GetComponent<Renderer>().material.color.a + 0.03f);
            letreroAzul2.GetComponent<Renderer>().material.color = new Color(letreroAzul2.GetComponent<Renderer>().material.color.r, letreroAzul2.GetComponent<Renderer>().material.color.g, letreroAzul2.GetComponent<Renderer>().material.color.b, letreroAzul2.GetComponent<Renderer>().material.color.a + 0.03f);
            letreroAzul3.GetComponent<Renderer>().material.color = new Color(letreroAzul3.GetComponent<Renderer>().material.color.r, letreroAzul3.GetComponent<Renderer>().material.color.g, letreroAzul3.GetComponent<Renderer>().material.color.b, letreroAzul3.GetComponent<Renderer>().material.color.a + 0.03f);
            letreroAzul4.GetComponent<Renderer>().material.color = new Color(letreroAzul4.GetComponent<Renderer>().material.color.r, letreroAzul4.GetComponent<Renderer>().material.color.g, letreroAzul4.GetComponent<Renderer>().material.color.b, letreroAzul4.GetComponent<Renderer>().material.color.a + 0.03f);

            if (letreroAzul1.GetComponent<Renderer>().material.color.a >= 0.3f)
            {
                letreroAzul1.transform.Rotate(Vector3.down, Space.World);
                letreroAzul2.transform.Rotate(Vector3.down, Space.World);
                letreroAzul3.transform.Rotate(Vector3.down, Space.World);
                letreroAzul4.transform.Rotate(Vector3.down, Space.World);
            }
        }
    }
}
