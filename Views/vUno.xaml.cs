namespace SGualpaS3A.Views;

public partial class vUno : ContentPage
{
	public vUno()
	{
		InitializeComponent();
	}
    string usuariof = " ";
    string contrase�af = " ";
    public vUno(String usuarioc, String contrase�ac)
    {
        InitializeComponent();
        this.usuariof = usuarioc;
        this.contrase�af = contrase�ac;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if(txtUsuario.Text == usuariof && txtContrase�a.Text == contrase�af )
        {
            Navigation.PushAsync(new Views.vDos(usuariof));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contrase�a incorrectos", "ok");
        }
		
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vTres());
    }
}