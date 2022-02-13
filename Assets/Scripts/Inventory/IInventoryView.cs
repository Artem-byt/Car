﻿using System.Collections.Generic;

public interface IInventoryView
{
    void Display(IReadOnlyList<IItem> items);

    void InitInventory(MainMenuView view);
}
