using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_companies")]
    public class Company:BaseModel
    {
        public Company()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        public Guid? ClientId { get; set; }


        public string? CompanyLoginCode { get; set; } 
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Address { get; set; }
        public string? Region { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public string TaxOffice { get; set; }

        public ICollection<WooConnectionsData> WooConnectionData { get; set; } = new HashSet<WooConnectionsData>();
        public ICollection<WareHouse> WareHouses { get; set; } = new HashSet<WareHouse>();
        public ICollection<VatClass> VatClasses { get; set; } = new HashSet<VatClass>();
        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<Status> Statuses { get; set; } = new HashSet<Status>();
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public ICollection<Log> Logs { get; set; } = new HashSet<Log>();
        public ICollection<DocumentType> DocumentTypes { get; set; } = new HashSet<DocumentType>();
        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();
        public ICollection<ConnectorParameters> ConnectorsParameters { get; set; } = new HashSet<ConnectorParameters>();
        public ICollection<ConnectorJob> ConnectorJobs { get; set; } = new HashSet<ConnectorJob>();
        public ICollection<Brand> Brands { get; set; } = new HashSet<Brand>();
        public ICollection<AdditionalCharge> AdditionalCharges { get; set; } = new HashSet<AdditionalCharge>();
        public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
        public ICollection<Supplier> Suppliers { get; set; } = new HashSet<Supplier>();

        public ICollection<ProductSize> ProductSizes { get; set; } = new HashSet<ProductSize>();
        public ICollection<Lot> Lots { get; set; } = new HashSet<Lot>();
        public ICollection<LotSettings> LotsSettings { get; set; } = new HashSet<LotSettings>();
        public ICollection<GeneralOptions> GeneralAppOptions { get; set; } = new HashSet<GeneralOptions>();
        public ICollection<WorkItemType> WorkItemTypes { get; set; } = new HashSet<WorkItemType>();

        public ICollection<WorkItem> WorkItems { get; set; } = new HashSet<WorkItem>();
        public ICollection<AppPermission> AppPermissions { get; set; } = new HashSet<AppPermission>();
        public ICollection<UserAppPermission> UserAppPermissions { get; set; } = new HashSet<UserAppPermission>();
        public ICollection<CntorDatasource> CntorDatasources { get; set; } = new HashSet<CntorDatasource>();
        public ICollection<CntorDatasourceEntity> CntorDatasourceEntities { get; set; } = new HashSet<CntorDatasourceEntity>();
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public ICollection<CustomerAddress> CustomerAddresses { get; set; } = new HashSet<CustomerAddress>();

    }
}
