using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumYoneticisi : MonoBehaviour
{
   public void BolumAc(string BolumIsmi)
    {
        Application.LoadLevel(BolumIsmi);
    }
    public void Cikis()
    {
        Application.Quit();
    }
}
