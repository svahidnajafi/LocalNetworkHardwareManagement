﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetworkHardware.DataLayer.Services
{
    public interface IGpuRepository: IGenericRepository<GPUs>
    {
        IEnumerable<GPUs> GetSystemExistingGPUs(int systemId);
    }
}
