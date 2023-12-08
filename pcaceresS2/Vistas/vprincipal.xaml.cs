namespace pcaceresS2.Vistas;

public partial class vprincipal : ContentPage
{
	public vprincipal(string usuario) //aqui se especifica los datos que se quiere recibir 
	{
		InitializeComponent();
		lblUsuario.Text = "Bievenido " + usuario;
	}

	private void btnMostrar_Clicked(object sender, EventArgs e)
	{ 
		string dato = pkPaises.Items[pkPaises.SelectedIndex];
		lblSeleccionado.Text = "El elemento seleccionado es: " + dato;
		//DisplayAlert("Elemento Seleccionado", dato.ToString(),"Cancel");
	}

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string fecha = dpfecha.Date.ToString();
		DisplayAlert("El elemento seleccionado", fecha, "Cancel");

    }
}