namespace agalloS2A.NewFolder;

public partial class vLogin : ContentPage
{
    private string[] users = { "Carlos", "Ana", "Jose" };
    private string[] passwords = { "carlos123", "ana123", "jose123" };

    public vLogin()
	{
		InitializeComponent();
	}

    private async void btnInicioSesion_Clicked(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string password = txtPassword.Text;

        for (int i = 0; i < users.Length; i++)
        {
            if (user == users[i] && password == passwords[i])
            {
                await DisplayAlert("Bienvenido/a", $"¡Bienvenido, {user}!", "Cerrar");
                await Navigation.PushAsync(new vElementos(user));
                return;
            }
        }

        await DisplayAlert("Error", "Usuario o contraseña incorrectos", "Cerrar");
    }
}