using Autofac;
using RestSharp;
using Wildlife.Services;
using Wildlife.Views;

namespace Wildlife
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            RegisterDependencies(builder);

            return builder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            #region Services

            builder.RegisterType<WildlifeHttpService>().As<IWildlifeHttpService>();

            #endregion

            #region Views

            builder.RegisterType<MainPage>().As<IMainPage>();
            builder.RegisterType<SpeciesListPage>().As<ISpeciesListPage>();
            builder.RegisterType<SpeciesDetailPage>().As<ISpeciesDetailPage>();
            builder.RegisterType<VideoCapturePage>().As<IVideoCapturePage>();

            #endregion

            #region External

            builder.RegisterType<RestClient>().As<IRestClient>();

            #endregion
        }
    }
}
