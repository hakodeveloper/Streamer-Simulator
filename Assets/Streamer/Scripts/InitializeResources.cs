using UnityEngine;
using System.Collections;

public class InitializeResources {
    private bool initialized=false;
    //Rooms
    public static Object TEST_ROOM;
    public static Object ROOM_1;
    //Desks
    public static Object DESK_1;
    //Doors
    public static Object DOOR_1;
    //Cases
    public static Object CASE_1;
    //Monitors
    public static Object MONITOR_1;
    //Mouses
    public static Object MOUSE_1;

	public InitializeResources() {
        initialized = true;
        TEST_ROOM = Resources.Load("TestRoom");
        ROOM_1 = Resources.Load("Room 1");

        DESK_1 = Resources.Load("Desk 1");

        DOOR_1 = Resources.Load("Door 1");

        CASE_1 = Resources.Load("Case 1");

        MONITOR_1 = Resources.Load("Monitor 1");

        MOUSE_1 = Resources.Load("Mouse 1");
    }
}
