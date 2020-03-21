using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerDoor : MonoBehaviour
{
    public static GameObject[] FindDoorsWithID(int id)
    {
        List<GameObject> doors = new List<GameObject>();
        DoorID[] doorIds = GameObject.FindObjectsOfType<DoorID>();

        Debug.Log("Doors are " + doors);

        foreach (DoorID door in doorIds)
        {
            if (door.DoorNumber == id) doors.Add(door.gameObject);
        }

        return doors.ToArray();
    }
}
