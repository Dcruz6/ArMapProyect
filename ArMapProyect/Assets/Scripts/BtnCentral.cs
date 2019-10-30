using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCentral : MonoBehaviour
{
    bool transicion=false;
    public GameObject btn1, btn2, btn3, btn4, btn5, btn6, btn7, btnCentral;
    float x, x1, x2, x3, x4, y1, y2, y3, y, z;

    // Start is called before the first frame update
    void Start()
    {
        llenadoVariablesXYZ();
        btn1.transform.position = new Vector3(x, y, z);
        btn2.transform.position = new Vector3(x, y, z);
        btn3.transform.position = new Vector3(x, y, z);
        btn4.transform.position = new Vector3(x, y, z);

        btn5.transform.position = new Vector3(x, y, z);
        btn6.transform.position = new Vector3(x, y, z);
        btn7.transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            if(transicion){
                transicion=false;
            }else{
                transicion=true;
            }

            if (transicion)
            {
                despliegeMenu();
            }
            else
            {
                retraerMenu();
            }
        }

        
    }

    public void llenadoVariablesXYZ(){
        x = btnCentral.transform.position.x;
        y = btnCentral.transform.position.y;
        z = btnCentral.transform.position.z;

        x1 = btn1.transform.position.x;
        x2 = btn2.transform.position.x;
        x3 = btn3.transform.position.x;
        x4 = btn4.transform.position.x;

        y1 = btn5.transform.position.y;
        y2 = btn6.transform.position.y;
        y3 = btn7.transform.position.y;
    }

    public void despliegeMenu (){

        if(btn1.transform.position.x < x1){
            btn1.transform.position = new Vector3(btn1.transform.position.x + 10f,y,z);
        }
        if(btn2.transform.position.x < x2){
            btn2.transform.position = new Vector3(btn2.transform.position.x + 10f, y,z);
        }
        if(btn3.transform.position.x < x3){
            btn3.transform.position = new Vector3(btn3.transform.position.x + 10f, y,z);
        }
        if(btn4.transform.position.x < x4){
            btn4.transform.position = new Vector3(btn4.transform.position.x + 10f, y,z);
        }

        if (btn5.transform.position.y < y1)
        {
            btn5.transform.position = new Vector3(x, btn5.transform.position.y + 10f, z);
        }
        if (btn6.transform.position.y < y2)
        {
            btn6.transform.position = new Vector3(x, btn6.transform.position.y + 10f, z);
        }
        if (btn7.transform.position.y < y3)
        {
            btn7.transform.position = new Vector3(x, btn7.transform.position.y + 10f, z);
        }
    }

    public void retraerMenu()
    {

        if (btn1.transform.position.x > x1)
        {
            btn1.transform.position = new Vector3(btn1.transform.position.x - 10f, y, z);
        }
        if (btn2.transform.position.x > x2)
        {
            btn2.transform.position = new Vector3(btn2.transform.position.x - 10f, y, z);
        }
        if (btn3.transform.position.x > x3)
        {
            btn3.transform.position = new Vector3(btn3.transform.position.x - 10f, y, z);
        }
        if (btn4.transform.position.x > x4)
        {
            btn4.transform.position = new Vector3(btn4.transform.position.x - 10f, y, z);
        }

        if (btn5.transform.position.y > y1)
        {
            btn5.transform.position = new Vector3(x, btn5.transform.position.y - 10f, z);
        }
        if (btn6.transform.position.y > y2)
        {
            btn6.transform.position = new Vector3(x, btn6.transform.position.y - 10f, z);
        }
        if (btn7.transform.position.y > y3)
        {
            btn7.transform.position = new Vector3(x, btn7.transform.position.y - 10f, z);
        }
    }
}
