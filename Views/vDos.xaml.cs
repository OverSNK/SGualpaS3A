namespace SGualpaS3A.Views;

public partial class vDos : ContentPage
{
	public vDos(String usuario)
	{
		InitializeComponent();
		lblUsuario.Text= "USUARIO CONECTADO "+usuario;
	}

	private void btnAbrir_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Views.vTres());
    }
}