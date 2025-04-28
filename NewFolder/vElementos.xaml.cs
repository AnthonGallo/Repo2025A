namespace agalloS2A.NewFolder;

public partial class vElementos : ContentPage
{
	public vElementos(string nombreUsuario)
	{
		InitializeComponent();
        lblUsuario.Text = $"Bienvenido, {nombreUsuario}";
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

    private void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        var mainWindow = Application.Current?.Windows.FirstOrDefault();
        if (mainWindow is not null)
        {
            mainWindow.Page = new NavigationPage(new NewFolder.vLogin());
        }
    }
}