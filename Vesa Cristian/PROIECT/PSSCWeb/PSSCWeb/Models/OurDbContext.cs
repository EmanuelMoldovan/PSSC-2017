using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PSSCWeb.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }

        public System.Data.Entity.DbSet<PSSC.Models.DTO.ClientDTO> ClientDTOes { get; set; }

        public System.Data.Entity.DbSet<PSSC.Models.DTO.ContDTO> ContDTOes { get; set; }

        public System.Data.Entity.DbSet<PSSCWeb.Models.ContModel> ContModels { get; set; }

        public System.Data.Entity.DbSet<PSSCWeb.Models.ActionModel> ActionModels { get; set; }

        public System.Data.Entity.DbSet<PSSC.Models.DTO.ActionDTO> ActionDTOes { get; set; }
    }
}