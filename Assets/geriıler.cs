using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geriıler : MonoBehaviour
{
    public GameObject canvasileri;
    public GameObject canvasgeri;
    public GameObject canvasikiileri;
    public void iler()
    {
        canvasileri.SetActive(true);
        canvasgeri.SetActive(false);
    }
    public void geri()
    {
        canvasgeri.SetActive(true);
        canvasileri.SetActive(false);
    }
    public void ikiileri()
    {
        canvasgeri.SetActive(false);
        canvasileri.SetActive(false);
        canvasikiileri.SetActive(true);
    }
    public void ikigeri()
    {
        canvasgeri.SetActive(false);
        canvasileri.SetActive(true);
        canvasikiileri.SetActive(false);

    }
}
