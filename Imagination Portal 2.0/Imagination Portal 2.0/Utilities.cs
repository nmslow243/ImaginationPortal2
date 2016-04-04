using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace Imagination_Portal_2._0
{
    public static class Utilities
    {
        public enum solutionStatuses {Step1, Step2, Step3, Final, Complete};

    }
    public static class IdentityExtensions
    {
        public static string GetName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Name");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
        public static Guid GetGUID(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("GUID");
            // Test for null to avoid issues during local testing
            return (claim != null) ? Guid.Parse(claim.Value) : Guid.Empty;
        }
    }
}