namespace agalloS2A.NewFolder;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}

    private void btnPaises_Clicked(object sender, EventArgs e)
    {
		try
		{
            if(pkPaises.SelectedIndex == -1)
			{
                DisplayAlert("Error", "No existe un dato seleccionado", "Cerrar");
            }
			else
			{
                string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
                DisplayAlert("Paises", " El país seleccionado es " + pais, "Cerrar");
            }
        }
		catch (Exception ex)
		{
			DisplayAlert("Paises", ex.Message, "Cerrar");
		}
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
        string fecha = dpkFecha.Date.ToString();
        DisplayAlert("Mensaje", " La fecha es: " + fecha, "Cerrar");
    }
}