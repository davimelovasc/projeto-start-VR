using System;
using UnityEngine;
using System.Collections;

public class Utils
{
    public static bool checkAnswer(string sphere, string answer)
    {
        switch (sphere)
        {
            case Constants.PHOTO01_SPHERE:
                if (answer.Equals(Constants.PHOTO01_ANSWER))
                {
                    // resposta correta
                    return true;
                } else
                {
                    //resposta errada
                }
            break;
        }

        return false;
    }
   
}
