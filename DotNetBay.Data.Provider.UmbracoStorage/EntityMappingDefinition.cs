using DotNetBay.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;


namespace DotNetBay.Data.Provider.UmbracoStorage
{
    public class EntityMappingDefinition : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<Umbraco.Web.PublishedModels.Auction, Auction>((source, context) => new Auction(), MapAuction);
            mapper.Define<Umbraco.Core.Models.IMember, Member>((source, context) => new Member(), MapMember);
        }

        private void MapAuction(Umbraco.Web.PublishedModels.Auction source, Auction target, MapperContext context)
        {
            target.Title = source.Name;
            double price = 0;
            double.TryParse(source.StartPrice, out price);
            target.StartPrice = price;
            target.StartDateTimeUtc = source.StartDateTime;
            target.EndDateTimeUtc = source.EndDateTimeUtc;
        }

        private void MapMember(Umbraco.Core.Models.IMember source, Member target, MapperContext context)
        {
            target.Id = source.Id;
            target.EMail = source.Email;
            target.DisplayName = source.Name;
            target.UniqueId = source.Id.ToString();
           
        }
    }


    public class EntityMappingComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<EntityMappingDefinition>();

         
        }
    }
}
