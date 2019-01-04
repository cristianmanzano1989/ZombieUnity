using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation  {

    private static int numMonedas = 0;

    public static int NumMonedas
    {
        get
        {
            return numMonedas;
        }

        set
        {
            numMonedas = value;
        }
    }
}
