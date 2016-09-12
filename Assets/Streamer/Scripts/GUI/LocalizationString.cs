using UnityEngine;
using System.Collections;

public class LocalizationString {
    public static string PressStart;
    public static string PressStart_mobile;

    public LocalizationString() {
        if (Application.systemLanguage.ToString().Equals("Spanish")) {
            PressStart = "Click para Empezar";
            PressStart_mobile = "Toca la Pantalla para Empezar";
        } else {
            PressStart = "Click to Start";
            PressStart_mobile = "Tap the Screen to Start";
        }
    }
}
