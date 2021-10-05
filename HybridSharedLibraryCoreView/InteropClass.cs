using Microsoft.Extensions.DependencyInjection;
using System;

namespace HybridSharedLibraryCoreView
{
    public class InteropClass
    {
        
        public InteropClass()
        {
           
        }

        public void Execute()
        {
            HostingView hostingView= new HostingView();
            hostingView.ShowDialog();
            hostingView.Dispose();
        }
    }
}
