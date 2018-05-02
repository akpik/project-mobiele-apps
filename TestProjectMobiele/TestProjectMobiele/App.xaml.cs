﻿using Prism;
using Prism.Ioc;
using TestProjectMobiele.ViewModels;
using TestProjectMobiele.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using TestProjectMobieles.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestProjectMobiele
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LogInPage>();
            containerRegistry.RegisterForNavigation<FotosKleutersPage>();
            containerRegistry.RegisterForNavigation<OudersMainPage>();
            containerRegistry.RegisterForNavigation<TimelinePage>();
            containerRegistry.RegisterInstance<IDataConnection>(new DataConnection("Data Source=daanvandebosch.database.windows.net;Initial Catalog=MobieleApps;User ID=r0664592;Password=Bobeke007"));
        }
    }
}
