﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL.Context
{
    public interface IDbSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}