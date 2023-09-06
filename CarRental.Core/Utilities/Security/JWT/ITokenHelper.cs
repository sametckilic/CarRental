﻿using CarRental.Core.Entities.Concrete;
using System.Collections.Generic;

namespace CarRental.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);

    }
}
