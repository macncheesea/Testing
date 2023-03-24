using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Database database;

    private void OnMouseDown() {
        database = FindObjectOfType<Database>();

        Debug.Log(database.ref1);
    }
}
