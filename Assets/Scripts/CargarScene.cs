using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarScene : MonoBehaviour
{
    public void CargaScene(string nombreEscenaDeJuego)
    {
        SceneManager.LoadScene(nombreEscenaDeJuego);
    }
}
