﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Core
{
    public static class GCCleanupTask
    {
        public static void Main()
        {
            while (true)
            {
                Processes.Scheduler.Disable();
                FOS_System.GC.Cleanup();
                Processes.Scheduler.Enable();

                Processes.Thread.Sleep(300);
            }
        }
    }
}
