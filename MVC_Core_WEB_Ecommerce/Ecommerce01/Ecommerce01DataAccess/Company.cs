//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce01DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.Categories = new HashSet<Category>();
            this.CompanyCustomers = new HashSet<CompanyCustomer>();
            this.CompanySuppliers = new HashSet<CompanySupplier>();
            this.Products = new HashSet<Product>();
            this.Taxes = new HashSet<Tax>();
            this.Users = new HashSet<User>();
            this.Warehouses = new HashSet<Warehouse>();
        }
    
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AddressO { get; set; }
        public string AddressL { get; set; }
        public string Logo { get; set; }
        public int DepartamentId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string Locality { get; set; }
        public string PartitaIva { get; set; }
        public string CodiceFiscale { get; set; }
        public string PhoneMobil { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string http { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }
        public virtual City City { get; set; }
        public virtual Departament Departament { get; set; }
        public virtual Province Province { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCustomer> CompanyCustomers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySupplier> CompanySuppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tax> Taxes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}