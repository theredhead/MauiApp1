﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class Proxy
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string InternalUrl { get; set; } = "";
        public string ExternalUrl { get; set; } = "";
    }


    public class MainViewModel : BaseViewModel
    {
        private string _title = "Hello, World!";
        public string Title { get => _title; set => SetBackingField(ref _title, value); }

        public ObservableCollection<Proxy> Proxies { get; set; } = new();

        public MainViewModel()
        {
            Proxies.Add(new Proxy
            {
                Name = "Buildserver",
                Description = "Buildserver powered by jenkins",
                InternalUrl = "jenkins.theredhead.local",
                ExternalUrl = "jenkins.theredhead.nl"
            });
            Proxies.Add(new Proxy
            {
                Name = "Private NPM repository",
                Description = "NPM repo powered Verdaccio",
                InternalUrl = "verdaccio.theredhead.local",
                ExternalUrl = "verdaccio.theredhead.nl"
            });
            Proxies.Add(new Proxy
            {
                Name = "Authentication",
                Description = "OAuth authentication server",
                InternalUrl = "keycloak.theredhead.local",
                ExternalUrl = "auth.theredhead.nl"
            });
        }
    }
}
