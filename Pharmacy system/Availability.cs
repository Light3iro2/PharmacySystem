//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy_system
{
    using System;
    using System.Collections.Generic;
    
    public partial class Availability
    {
        public int Id { get; set; }
        public int Id_Medicines { get; set; }
        public int Id_Pharmacies { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    
        public virtual Medicines Medicines { get; set; }
        public virtual Pharmacies Pharmacies { get; set; }
    }
}
