using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ユーザ操作によって状態が変わるもの
public enum eventList{
    Door,
    KeyBox,
    LockBox,
    Printer,
    Desk,
    Book,
    Drawer,
    PC,
    PCSide,
    SlidingDoor,
    Shelf,
    BookShelf,
    Screen,
    Projector,
    Water,
    Trash,
    LIST_LEN
}

public enum status{
    initial,
    halfWay1,
    halfWay2,
    halfWay3,
    halfWay4,
    halfWay5,
    halfWay6,
    halfWay7,
    halfWay8,
    halfWay9,
    halfWay10,
    halfWay11,
    halfWay12,
    halfWay13,
    halfWay14,
    halfWay15,
    halfWay16,
    final
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
    Drawer,
    BookShelf,
    Shelf,
    PC,
    PCSide,
    SlidingDoor,
    ProjectorScreen,
    WaterTrash,
    Calendar,
    Trash,
    Water,
    LIST_LEN
}
