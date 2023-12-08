namespace pcaceresS2.Vistas;

public partial class vcalificaciones : ContentPage
{
	public vcalificaciones()
	{
		InitializeComponent();
	}
    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
        string dato = pkEstudiantes.Items[pkEstudiantes.SelectedIndex];
        lblSeleccionado.Text = "El elemento seleccionado es: " + dato;
        //DisplayAlert("Elemento Seleccionado", dato.ToString(),"Cancel");
    }
}