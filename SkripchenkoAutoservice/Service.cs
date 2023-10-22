//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkripchenkoAutoservice
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;

    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ClientService = new HashSet<ClientService>();
            this.ServicePhoto = new HashSet<ServicePhoto>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Nullable<double> Discount { get; set; }
        public string MainImagePath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicePhoto> ServicePhoto { get; set; }

        public string OldCost
        {
            get
            {
                if (Discount > 0)
                {
                    return Cost.ToString();
                }
                else 
                {
                    return "";
                }
            }
        }
        public decimal NewCost
        {
            get
            {
                if (Discount > 0)
                {
                    return ((decimal)Cost - (decimal)Cost * (decimal)Discount / 100);
                }
                else
                {
                    return (decimal)Cost;
                }
            }
        }
        public SolidColorBrush FonStyle
        {
            get 
            {
                if (Discount > 0)
                {
                    return (SolidColorBrush)new BrushConverter().ConvertFromString("LightGreen");
                }
                else
                {
                    return (SolidColorBrush)new BrushConverter().ConvertFromString("White");
                }
            }
        }
    }
}
