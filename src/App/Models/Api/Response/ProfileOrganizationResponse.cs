﻿using Bit.App.Enums;

namespace Bit.App.Models.Api
{
    public class ProfileOrganizationResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool UseGroups { get; set; }
        public bool UseDirectory { get; set; }
        public bool UseEvents { get; set; }
        public bool UseTotp { get; set; }
        public bool Use2fa { get; set; }
        public bool UsersGetPremium { get; set; }
        public int Seats { get; set; }
        public int MaxCollections { get; set; }
        public short? MaxStorageGb { get; set; }
        public string Key { get; set; }
        public OrganizationUserStatusType Status { get; set; }
        public OrganizationUserType Type { get; set; }
        public bool Enabled { get; set; }
    }
}
