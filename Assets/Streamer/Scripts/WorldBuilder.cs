using UnityEngine;
using System.Collections;

public class WorldBuilder : MonoBehaviour {
    public GameObject room;
    public GameObject desk;
    public GameObject door;
    public GameObject cpuCase;
    public GameObject mouse;
    public GameObject monitor;

    void Start() {
        InitializeResources resources = new InitializeResources();
        // TODO If first game desde la base de datos
        FirstRoom();
    }

    void FirstRoom() {
        room = Instantiate(InitializeResources.ROOM_1, PositionsDictionary.ROOM_1_POSITION, Quaternion.identity) as GameObject;
        room.transform.localScale = PositionsDictionary.ROOM_1_SCALE;
        desk = Instantiate(InitializeResources.DESK_1, PositionsDictionary.ROOM_1_DESK_1_POSITION, Quaternion.identity) as GameObject;
        desk.transform.localScale = PositionsDictionary.ROOM_1_DESK_1_SCALE;
        door = Instantiate(InitializeResources.DOOR_1, PositionsDictionary.ROOM_1_DOOR_1_POSITION, Quaternion.identity) as GameObject;
        door.transform.localScale = PositionsDictionary.ROOM_1_DOOR_1_SCALE;
        cpuCase = Instantiate(InitializeResources.CASE_1, PositionsDictionary.ROOM_1_CASE_1_POSITION, Quaternion.identity) as GameObject;
        cpuCase.transform.localScale = PositionsDictionary.ROOM_1_CASE_1_SCALE;

    }

    // Update is called once per frame
    void Update () {
	
	}
}
