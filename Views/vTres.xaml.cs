namespace SGualpaS3A.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

    private void btnGuardad_Clicked(object sender, EventArgs e)
    {
		string usuarioc = txtUsuario.Text;
		string contrase�ac = txtContrase�a.Text;
		DisplayAlert("Alerta", "Usuario almacenado", "ok");
		Navigation.PushAsync(new Views.vUno(usuarioc, contrase�ac));
    }
}