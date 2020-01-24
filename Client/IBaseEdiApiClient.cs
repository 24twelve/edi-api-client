﻿using JetBrains.Annotations;

using SkbKontur.EdiApi.Types.Boxes;
using SkbKontur.EdiApi.Types.Organization;
using SkbKontur.EdiApi.Types.Parties;

using PartyInfo = SkbKontur.EdiApi.Types.Parties.PartyInfo;

namespace SkbKontur.EdiApi.Client
{
    public interface IBaseEdiApiClient
    {
        [NotNull]
        string Authenticate([NotNull] string portalSid);

        [NotNull]
        string Authenticate([NotNull] string login, [NotNull] string password);

        [NotNull]
        PartiesInfo GetAccessiblePartiesInfo([NotNull] string authToken);

        [NotNull]
        PartyInfo GetPartyInfo([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        PartyInfo GetPartyInfoByGln([NotNull] string authToken, [NotNull] string partyGln);

        [NotNull]
        BoxesInfo GetBoxesInfo([NotNull] string authToken);

        [NotNull]
        BoxInfo GetMainApiBox([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        OrganizationCatalogueInfo GetOrganizationCatalogueInfo([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        PartyInfo GetPartyInfoByDepartmentGln([NotNull] string authToken, [NotNull] string departmentGln);
    }
}