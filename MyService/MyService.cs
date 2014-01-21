using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace MyService
{
    public partial class MyService : ServiceBase
    {
        public MyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Start();
        }

        protected override void OnStop()
        {

        }

        protected void Start()
        {
            Thread thread = new Thread(Task);
            thread.Start();
        }

        protected void Task()
        {
            // do a task here
            // create a thread
            while (true)
            {
                // do something
            }
        }
    }
}
