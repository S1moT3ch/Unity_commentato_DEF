using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputTastiera : MonoBehaviour
{    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()  //se si preme un determinato tasto, viene aggiornato il valore sul monitor
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            NumbersOnMonitor.istance.UpdateCodice("q");
            NumbersOnMonitor2.istance.UpdateCodice("q");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            NumbersOnMonitor.istance.UpdateCodice("w");
            NumbersOnMonitor2.istance.UpdateCodice("w");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            NumbersOnMonitor.istance.UpdateCodice("e");
            NumbersOnMonitor2.istance.UpdateCodice("e");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            NumbersOnMonitor.istance.UpdateCodice("r");
            NumbersOnMonitor2.istance.UpdateCodice("r");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            NumbersOnMonitor.istance.UpdateCodice("t");
            NumbersOnMonitor2.istance.UpdateCodice("t");
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            NumbersOnMonitor.istance.UpdateCodice("y");
            NumbersOnMonitor2.istance.UpdateCodice("y");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            NumbersOnMonitor.istance.UpdateCodice("u");
            NumbersOnMonitor2.istance.UpdateCodice("u");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            NumbersOnMonitor.istance.UpdateCodice("i");
            NumbersOnMonitor2.istance.UpdateCodice("i");
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            NumbersOnMonitor.istance.UpdateCodice("o");
            NumbersOnMonitor2.istance.UpdateCodice("o");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            NumbersOnMonitor.istance.UpdateCodice("p");
            NumbersOnMonitor2.istance.UpdateCodice("p");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            NumbersOnMonitor.istance.UpdateCodice("a");
            NumbersOnMonitor2.istance.UpdateCodice("a");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            NumbersOnMonitor.istance.UpdateCodice("s");
            NumbersOnMonitor2.istance.UpdateCodice("s");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            NumbersOnMonitor.istance.UpdateCodice("d");
            NumbersOnMonitor2.istance.UpdateCodice("d");
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            NumbersOnMonitor.istance.UpdateCodice("f");
            NumbersOnMonitor2.istance.UpdateCodice("f");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            NumbersOnMonitor.istance.UpdateCodice("g");
            NumbersOnMonitor2.istance.UpdateCodice("g");
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            NumbersOnMonitor.istance.UpdateCodice("h");
            NumbersOnMonitor2.istance.UpdateCodice("h");
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            NumbersOnMonitor.istance.UpdateCodice("j");
            NumbersOnMonitor2.istance.UpdateCodice("j");
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            NumbersOnMonitor.istance.UpdateCodice("k");
            NumbersOnMonitor2.istance.UpdateCodice("k");
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            NumbersOnMonitor.istance.UpdateCodice("l");
            NumbersOnMonitor2.istance.UpdateCodice("l");
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            NumbersOnMonitor.istance.UpdateCodice("z");
            NumbersOnMonitor2.istance.UpdateCodice("z");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            NumbersOnMonitor.istance.UpdateCodice("x");
            NumbersOnMonitor2.istance.UpdateCodice("x");
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            NumbersOnMonitor.istance.UpdateCodice("c");
            NumbersOnMonitor2.istance.UpdateCodice("c");
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            NumbersOnMonitor.istance.UpdateCodice("v");
            NumbersOnMonitor2.istance.UpdateCodice("v");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            NumbersOnMonitor.istance.UpdateCodice("b");
            NumbersOnMonitor2.istance.UpdateCodice("b");
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            NumbersOnMonitor.istance.UpdateCodice("n");
            NumbersOnMonitor2.istance.UpdateCodice("n");
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            NumbersOnMonitor.istance.UpdateCodice("m");
            NumbersOnMonitor2.istance.UpdateCodice("m");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            NumbersOnMonitor.istance.UpdateCodice("0");
            NumbersOnMonitor2.istance.UpdateCodice("0");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            NumbersOnMonitor.istance.UpdateCodice("1");
            NumbersOnMonitor2.istance.UpdateCodice("1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            NumbersOnMonitor.istance.UpdateCodice("2");
            NumbersOnMonitor2.istance.UpdateCodice("2");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            NumbersOnMonitor.istance.UpdateCodice("3");
            NumbersOnMonitor2.istance.UpdateCodice("3");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            NumbersOnMonitor.istance.UpdateCodice("4");
            NumbersOnMonitor2.istance.UpdateCodice("4");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            NumbersOnMonitor.istance.UpdateCodice("5");
            NumbersOnMonitor2.istance.UpdateCodice("5");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            NumbersOnMonitor.istance.UpdateCodice("6");
            NumbersOnMonitor2.istance.UpdateCodice("6");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            NumbersOnMonitor.istance.UpdateCodice("7");
            NumbersOnMonitor2.istance.UpdateCodice("7");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            NumbersOnMonitor.istance.UpdateCodice("8");
            NumbersOnMonitor2.istance.UpdateCodice("8");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            NumbersOnMonitor.istance.UpdateCodice("9");
            NumbersOnMonitor2.istance.UpdateCodice("9");
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            NumbersOnMonitor.istance.CancellaCarattere();
            NumbersOnMonitor2.istance.CancellaCarattere();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            NumbersOnMonitor.istance.UpdateCodice(" ");
            NumbersOnMonitor2.istance.UpdateCodice(" ");
        }
    }

}
