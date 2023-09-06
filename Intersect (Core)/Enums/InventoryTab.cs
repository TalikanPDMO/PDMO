﻿namespace Intersect.Enums
{
    /// <summary>
    /// Defines the inventory tabs available within the engine, and is used to determine which one is currently in view.
    /// </summary>
    public enum InventoryTab
    {
        All,

        Projectiles,

        Consumables,

        Equipments,

        Others,

        // Always keep this at the bottom, or you're going to have a very bad time!
        Count
    }
}
