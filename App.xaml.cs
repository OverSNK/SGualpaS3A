namespace SGualpaS3A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //NavigationPage para Navegación
            return new Window(new NavigationPage(new Views.vUno()));
        }
    }
}