﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Identity
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext( DbContextOptions<IdentityContext> options ) : base(options) { }

     
    }
}
