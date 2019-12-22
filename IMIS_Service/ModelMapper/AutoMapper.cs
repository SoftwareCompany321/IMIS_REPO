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
            CreateMap<ItemSupplierDtlVM, InvSupplier>(); 
            CreateMap<InvSupplier, ItemSupplierDtlVM>().ForMember(x=>x.SubT,src=>src.MapFrom(x=>x.SupType=="Y"?true:false));
        }
    }
}
