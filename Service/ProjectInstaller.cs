﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace Cliver.CisteraScreenCaptureService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            this.Committed += delegate
            {
                try
                {
                    ServiceController sc = new ServiceController(Program.SERVICE_NAME);
                    sc.Start();
                }
                catch (Exception e)
                {
                    Message.Error(e);
                }
            };

            this.BeforeUninstall += delegate
            {
                try
                {
                    ServiceController sc = new ServiceController(Program.SERVICE_NAME);
                    if (sc.Status != ServiceControllerStatus.Stopped)
                    {
                        sc.Stop();
                        double timeoutSecs = 20;
                        sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(timeoutSecs));
                        if (sc.Status != ServiceControllerStatus.Stopped)
                            throw new Exception("Could not stop service '" + Cliver.CisteraScreenCaptureService.Program.SERVICE_NAME + "'. To unistall it, stop it manually.");
                    }
                }
                catch (Exception e)
                {
                    Message.Error(e);
                    throw e;//to stop uninstalling(?)
                }
            };
        }
    }
}
