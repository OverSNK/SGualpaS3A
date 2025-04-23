namespace SGualpaS3A.Views;

public partial class vUno : ContentPage
{
	public vUno()
	{
		InitializeComponent();
	}
    string usuariof = " ";
    string contraseñaf = " ";
    public vUno(String usuarioc, String contraseñac)
    {
        InitializeComponent();
        this.usuariof = usuarioc;
        this.contraseñaf = contraseñac;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if(txtUsuario.Text == usuariof && txtContraseña.Text == contraseñaf )
        {
            Navigation.PushAsync(new Views.vDos(usuariof));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "ok");
        }
		
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vTres());
    }
}