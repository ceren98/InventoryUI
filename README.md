# Inventory System (Drag-and-Drop UI)




![InventoryUI (1)](https://github.com/user-attachments/assets/665a3b7b-17e7-44ae-b537-9e2c7e104153)



This Unity project implements a simple and functional **drag-and-drop inventory system**. It allows users to move items between inventory slots and dynamically updates the UI to reflect those changes. This system is ideal for games that require basic inventory management and visual item handling.

## Features

- **Drag and Drop**: Users can drag items and drop them into different inventory slots.
- **Slot Management**: Each slot can hold one item. If a slot is empty, it will accept a new item.
- **Dynamic UI Updates**: The interface updates in real time when items are added, removed, or moved.
- **Item Name Display**: The name of each item is displayed in a text field corresponding to its slot (e.g., top, bottom, left, right).

## Components

### 1. DragHandler.cs

Handles the logic for dragging and dropping items.

- `OnBeginDrag`: Stores the initial position and parent of the dragged item. Makes it ignore raycasts to allow correct slot detection.
- `OnDrag`: Updates the item's position to follow the mouse.
- `OnEndDrag`: Restores raycast blocking and resets position if dropped outside valid slots.

### 2. Slot.cs

Represents an individual inventory slot.

- Accepts dropped items if the slot is empty.
- Communicates with the `Inventory` manager to trigger UI updates when an item is placed.

### 3. Inventory.cs

The main inventory manager responsible for checking slot contents and updating UI texts.

- Iterates through predefined slots (e.g., `SlotBottom`, `SlotUp`, `SlotLeft`, `SlotRight`).
- Displays the name of the item in the appropriate UI text field when present.

### 4. IHasChanged Interface

Custom Unity interface used to notify the inventory system when a change has occurred in any slot. This keeps the UI consistent with the underlying item layout.

## Setup

1. Import the scripts into your Unity project.
2. Create a UI Canvas and add slot GameObjects named `SlotBottom`, `SlotUp`, `SlotLeft`, and `SlotRight`.
3. Assign the `Slot` script to each slot GameObject.
4. Create draggable item GameObjects with the `DragHandler` script and place them in a slot.
5. Assign the corresponding UI text fields to the `Inventory` script so it can display item names.

## 🔹 Quick Start

If you don't want to set everything up manually, you can quickly test the system:

- Open the Unity project.
- Go to the `Assets/Scenes` folder.
- Open the scene named `SampleScene`.

This scene contains a fully set-up example of the inventory system, ready to use and test.

## How to Use

- Drag an item using the mouse and drop it into an empty slot.
- The item's name will appear in the text field associated with the slot.
- If a dragged item is not dropped in a valid slot, it returns to its original position.

