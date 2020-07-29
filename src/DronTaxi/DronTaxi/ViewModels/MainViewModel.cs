namespace DronTaxi.ViewModels
{
    using Catel.IoC;
    using Catel.MVVM;
    using Catel.Windows.Controls;
    using DronTaxi.Views;
    using System.Threading.Tasks;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(/* dependency injection here */)
        {
            MainContent = TypeFactory.Default.CreateInstance<LoginView>();
        }

        public override string Title { get { return "Dron Taxi"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        public UserControl MainContent { get; set; }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
