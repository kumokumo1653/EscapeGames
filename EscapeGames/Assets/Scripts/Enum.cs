using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ユーザ操作によって状態が変わるもの
public enum eventList{
    Door,
    KeyBox,
    LockBox,
    Printer,
    PC,
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
