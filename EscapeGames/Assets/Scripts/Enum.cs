using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ユーザ操作によって状態が変わるもの
public enum eventList{

    LIST_LEN
}
public enum itemList{
    Ink,
    DoorKey,
    Film1,
    Film2,
    Paper,
    ShelfKey,
    SlidingDoorKey,
    Book,
    Rod,
    Cord,
    USB,
    Scissors,
    None,
    LIST_LEN
}

//Scene名と同じ
public enum SceneList{
    Door,
    KeyBox,
    WhiteBoard,
    Printer,
    LockBox,
    Desk,
    BookShelf,
    Shelf,
    PC,
    SlidingDoor,
    ProjectorScreen,
    WaterTrash,
    Calendar,
    Trash,
    Water,
    LIST_LEN
}