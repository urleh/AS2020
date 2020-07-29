namespace DronTaxi.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;
    using System.Windows;

    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(/* dependency injection here */)
        {
            CommandExit = new Command(OnCommandExitExecute);
        }

        public override string Title { get { return "Логин"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        public Command CommandExit { get; private set; }

        private void OnCommandExitExecute()
        {
            Application.Current.Shutdown(0);
        }

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
