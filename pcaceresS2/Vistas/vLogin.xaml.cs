namespace pcaceresS2.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();

	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		string usuario = "pcaceres";
		string contrasena = "12345";

		if (txtUsuario.Text == usuario && txtContrase�a.Text == contrasena)
		{
			Navigation.PushAsync(new vprincipal(usuario));

		}
		else
		{
			DisplayAlert("Alerta", "Usuario/contrase�a incorrectos", "Cancel");
		}
    }
}