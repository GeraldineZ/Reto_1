using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDT_Script : MonoBehaviour
{
    #region Some extra code
    public GameObject pressPlayWindow;

    private void Start()
    {
        //DEACTIVATE THE WINDOW ON START

        pressPlayWindow.SetActive(false);

        /*TO SEE MORE INFO ABOUT THIS CHECK THESE VIDEOS
        
        ACTIVAR Y DESACTIVAR GAMEOBJECTS POR C�DIGO
        https://youtu.be/Zn7DGT752pM

        C�MO SABER SI UN GAMEOBJECT EST� ACTIVO O INACTIVO EN LA ESCENA
        https://youtu.be/17j_iXEG8GM

        */
    }
    public void MysteriousFunction(string s)
    {
        #region don't
        //Subscribe :)
        Application.OpenURL(s);
        #endregion
    }
    #endregion
}
