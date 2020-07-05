﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL.Settings
{
    public interface IDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public string CollectionName { get; set; }
    }
}
