﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Armors.Providers
{
    public class ArmorPageWithGroupProvider : GraphqlPageProvider<IArmorsPage, ArmorSortInput>
    {
        private Guid WeaponGroupId { get; }

        public ArmorPageWithGroupProvider(IPathfinderOfficialApi api, Guid weaponGroupId)
            : base(api)
        {
            WeaponGroupId = weaponGroupId;
        }

        public override async Task<TableData<IArmorsPage>> GetPage(ArmorSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArmorPageWithGroupResult> result = await PathfinderOfficialApi.GetArmorPageWithGroup
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, WeaponGroupId, searchTerm, sortInputs);

            if (result.Data?.Armors == null)
            {
                return EmptyPage();
            }

            TableData<IArmorsPage> page = new TableData<IArmorsPage>()
            {
                TotalItems = result.Data!.Armors!.TotalCount,
                Items = result.Data!.Armors!.Items!
            };

            return page;
        }
    }
}
