namespace MAUI_Lessons
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState) =>
        new Window(new AppShell())
        {
            Width = 1500,
            Height = 600,
            X = 100,
            Y = 100
        };

    }
}