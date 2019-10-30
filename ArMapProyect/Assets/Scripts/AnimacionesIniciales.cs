using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesIniciales : MonoBehaviour
{
    public GameObject letreroAzul1, letreroAzul2, letreroAzul3, letreroAzul4;
    public GameObject letreroRojo1, letreroRojo2, letreroRojo3;
    int contador = 0;
    float contadorY = -3.5f, velocidadRotacion = -10f, velocidadDesliz = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        componentesTransparentes();
        inicializacionIconosAzules();
        inicializacionIconosRojos();
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
            giroIconos();
            caidaIconosRojos();
        }
    }

    public void componentesTransparentes()
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

            //if (letreroAzul1.GetComponent<Renderer>().material.color.a >= 0.3f)
            //{
            //    letreroAzul1.transform.Rotate(Vector3.down, Space.World);
            //    letreroAzul2.transform.Rotate(Vector3.down, Space.World);
            //    letreroAzul3.transform.Rotate(Vector3.down, Space.World);
            //    letreroAzul4.transform.Rotate(Vector3.down, Space.World);
            //}
        }
    }

    public void inicializacionIconosAzules()
    {
        letreroAzul1.transform.Rotate(new Vector3(0, 90f, 0));
        letreroAzul2.transform.Rotate(new Vector3(0, 90f, 0));
        letreroAzul3.transform.Rotate(new Vector3(0, 90f, 0));
        letreroAzul4.transform.Rotate(new Vector3(0, 90f, 0));
    }

    public void giroIconos()
    {
        if (letreroAzul1.transform.localEulerAngles.y < 180)
        {
            letreroAzul1.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
            letreroAzul2.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
            letreroAzul3.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
            letreroAzul4.transform.Rotate(new Vector3(0, velocidadRotacion, 0) * Time.deltaTime);
        }
    }

    public void inicializacionIconosRojos()
    {
        letreroRojo1.transform.position = (new Vector3(letreroRojo1.transform.position.x, 3.5f, letreroRojo1.transform.position.y));
        letreroRojo2.transform.position = (new Vector3(letreroRojo2.transform.position.x, 3.5f, letreroRojo2.transform.position.y));
        letreroRojo3.transform.position = (new Vector3(letreroRojo3.transform.position.x, 3.5f, letreroRojo3.transform.position.y));
    }

    public void caidaIconosRojos()
    {
        if (/*letreroRojo1.transform.localPosition.y > 0.0214f*/contadorY < 0)
        {
            contadorY += velocidadDesliz;
            letreroRojo1.transform.position = (new Vector3(letreroRojo1.transform.position.x, -contadorY, letreroRojo1.transform.position.z));
        }
        if (/*letreroRojo2.transform.localPosition.y > -0.095f*/contadorY < 0)
        {
            contadorY += velocidadDesliz;
            letreroRojo2.transform.position = (new Vector3(letreroRojo2.transform.position.x, -contadorY, letreroRojo2.transform.position.z));
        }
        if (/*letreroRojo3.transform.localPosition.y > 0.0836f*/contadorY < 0)
        {
            contadorY += velocidadDesliz;
            letreroRojo3.transform.position = (new Vector3(letreroRojo3.transform.position.x, -contadorY, letreroRojo3.transform.position.z));
        }
    }
}
