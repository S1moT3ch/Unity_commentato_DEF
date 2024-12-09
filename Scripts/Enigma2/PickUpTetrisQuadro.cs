using UnityEngine;

public class PickUpTetrisQuadro : MonoBehaviour
{
    public GameObject qp1;
    public GameObject qp2;
    public GameObject qp3;
    public GameObject qp4;
    public GameObject qp5;
    public GameObject qp6;
    public GameObject qp7;
    public GameObject qp8;
    public GameObject qp9;
    public GameObject qp10;
    public GameObject qp11;
    public GameObject qp12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        qp1.SetActive(false);
        qp2.SetActive(false);
        qp3.SetActive(false);
        qp4.SetActive(false);
        qp5.SetActive(false);
        qp6.SetActive(false);
        qp7.SetActive(false);
        qp8.SetActive(false);
        qp9.SetActive(false);
        qp10.SetActive(false);
        qp11.SetActive(false);
        qp12.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (qP1.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 1) // se e solo se si clicca sul pezzo n del puzzle, viene mostrato il pezzo n sul quadro del tetris, inoltre si aggiorna la variabile clickOnQ per effettuare ad ogni update in controllo sul pezzo clickato
        {
            qp1.SetActive(true);
            qP1.istance.clickOnQ = false;
        }
        else if (qP1.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 1)
        {
            qP1.istance.clickOnQ = false;
        }
        else if (qP2.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 2)
        {
            qp2.SetActive(true);
            qP2.istance.clickOnQ = false;
        }
        else if (qP2.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 2)
        {
            qP2.istance.clickOnQ = false;
        }
        else if (qP3.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 3)
        {
            qp3.SetActive(true);
            qP3.istance.clickOnQ = false;
        }
        else if (qP2.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 3)
        {
            qP2.istance.clickOnQ = false;
        }
        else if (qP4.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 4)
        {
            qp4.SetActive(true);
            qP4.istance.clickOnQ = false;
        }
        else if (qP4.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 4)
        {
            qP4.istance.clickOnQ = false;
        }
        else if (qP5.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 5)
        {
            qp5.SetActive(true);
            qP5.istance.clickOnQ = false;
        }
        else if (qP5.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 5)
        {
            qP5.istance.clickOnQ = false;
        }
        else if (qP6.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 6)
        {
            qp6.SetActive(true);
            qP6.istance.clickOnQ = false;
        }
        else if (qP6.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 6)
        {
            qP6.istance.clickOnQ = false;
        }
        else if (qP7.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 7)
        {
            qp7.SetActive(true);
            qP7.istance.clickOnQ = false;
        }
        else if (qP7.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 7)
        {
            qP7.istance.clickOnQ = false;
        }
        else if (qP8.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 8)
        {
            qp8.SetActive(true);
            qP8.istance.clickOnQ = false;
        }
        else if (qP8.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 8)
        {
            qP8.istance.clickOnQ = false;
        }
        else if (qP9.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 9)
        {
            qp9.SetActive(true);
            qP9.istance.clickOnQ = false;
        }
        else if (qP9.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 9)
        {
            qP9.istance.clickOnQ = false;
        }
        else if (qP10.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 10)
        {
            qp10.SetActive(true);
            qP10.istance.clickOnQ = false;
        }
        else if (qP10.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 10)
        {
            qP10.istance.clickOnQ = false;
        }
        else if (qP11.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 11)
        {
            qp11.SetActive(true);
            qP11.istance.clickOnQ = false;
        }
        else if (qP11.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 11)
        {
            qP11.istance.clickOnQ = false;
        }
        else if (qP12.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 12)
        {
            qp12.SetActive(true);
            qP12.istance.clickOnQ = false;
        }
        else if (qP12.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 12)
        {
            qP12.istance.clickOnQ = false;
        }
    }
}
