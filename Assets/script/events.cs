using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class events : MonoBehaviour
{
    public void OnRestart()
    {
        GameSystems.Systems.OnRestart();
    }
    public void OnknifeKill()
    {
        GameSystems.Systems.OnknifeKill();
    }
}
