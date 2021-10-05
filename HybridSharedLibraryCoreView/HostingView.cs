﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HybridSharedLibrary;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using System.Text.RegularExpressions;

namespace HybridSharedLibraryCoreView
{
    public partial class HostingView : Form
    {
      
        public HostingView()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddSingleton<HybridSharedLibrary.Data.WeatherForecastService>();

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot/index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");

        }

        

  
    }
}
