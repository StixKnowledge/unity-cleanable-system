# Unity Cleanable Object System

A simple Unity C# script that detects when all child dirt objects are removed from a cleanable object. Ideal for cleaning mini-games, dishwashing mechanics, and task-based gameplay systems.

## Features
- Automatically checks child objects
- Detects when the object is fully cleaned
- Easy to customize
- Lightweight and beginner-friendly

---

## Script

```csharp
// Attach this to your Cleanable GameObject 
using UnityEngine;

public class Cleanable : MonoBehaviour
{
    void Update()
    {
        // Check if all child dirt objects are gone
        if (transform.childCount == 0)
        {
            TriggerFinish();
        }
    }

    void TriggerFinish()
    {
        Debug.Log("Plate is clean!");
        // Your level finish logic here
    }
}
```

---

## How to Use

1. Create a GameObject in Unity.
2. Add child objects that represent dirt, stains, or trash.
3. Attach the `Cleanable.cs` script to the parent GameObject.
4. Remove or destroy the child dirt objects during gameplay.
5. Once all child objects are removed, the cleaning completion will trigger automatically.

---

## Example Use Cases
- Dishwashing mini-games
- Cleaning simulator mechanics
- Quest or task completion systems
- Object repair mechanics

---

## Requirements
- Unity Engine
- C#

---

## Author
Created by Stix&Kno
