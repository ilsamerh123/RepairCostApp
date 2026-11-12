using System;
namespace RepairCostApp.Entities.Enums
{
    [Flags]
    public enum WorkCategory
    {
        None = 0,
        Finishing = 1,  
        Electrical = 2, 
        Plumbing = 4,   
        Other = 8       
    }
}