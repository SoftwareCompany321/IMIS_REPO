using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;

namespace IMIS_Service.ModelMapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<InvItemMst, ItemMasterVM>();
            CreateMap<ItemMasterVM, InvItemMst>();
            CreateMap<InvSupplier, ItemSupplierDtlVM>();
            CreateMap<ItemSupplierDtlVM, InvSupplier>();
        }
    }
}
