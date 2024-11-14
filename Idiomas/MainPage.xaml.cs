namespace Idiomas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnInsertarValencianoClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Nivel de Valenciano", "Escribe A, M o B:", "Aceptar", "Cancelar", "A, M o B", maxLength: 1, keyboard: Keyboard.Text);
            if (result == "A" || result == "M" || result == "B")
            {
                ValencianoEntry.Text = result;
                CambiarColorEntry(ValencianoEntry, result);
            }
            else if (!string.IsNullOrEmpty(result))
            {
                await DisplayAlert("Error", "Por favor, ingresa un valor válido (A, M o B).", "OK");
            }
        }

        private async void OnInsertarInglesClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Nivel de Inglés", "Escribe A, M o B:", "Aceptar", "Cancelar", "A, M o B", maxLength: 1, keyboard: Keyboard.Text);
            if (result == "A" || result == "M" || result == "B")
            {
                InglesEntry.Text = result;
                CambiarColorEntry(InglesEntry, result);
            }
            else if (!string.IsNullOrEmpty(result))
            {
                await DisplayAlert("Error", "Por favor, ingresa un valor válido (A, M o B).", "OK");
            }
        }

        private async void OnInsertarFrancesClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Nivel de Francés", "Escribe A, M o B:", "Aceptar", "Cancelar", "A, M o B", maxLength: 1, keyboard: Keyboard.Text);
            if (result == "A" || result == "M" || result == "B")
            {
                FrancesEntry.Text = result;
                CambiarColorEntry(FrancesEntry, result);
            }
            else if (!string.IsNullOrEmpty(result))
            {
                await DisplayAlert("Error", "Por favor, ingresa un valor válido (A, M o B).", "OK");
            }
        }

        private void CambiarColorEntry(Entry entry, string nivel)
        {
            switch (nivel)
            {
                case "A":
                    entry.BackgroundColor = Colors.LightGreen;
                    entry.TextColor = Colors.White;
                    break;
                case "M":
                    entry.BackgroundColor = Colors.Orange;
                    entry.TextColor = Colors.White;
                    break;
                case "B":
                    entry.BackgroundColor = Colors.Red;
                    entry.TextColor = Colors.White;
                    break;
                default:
                    entry.BackgroundColor = Colors.Transparent;
                    entry.TextColor = Colors.Black;
                    break;
            }
        }

        private async void OnComprobarClicked(object sender, EventArgs e)
        {
            // Mostrar el DisplayAlert para confirmar
            bool respuesta = await DisplayAlert("Avanzados", "¿Quieres ver el número de idiomas a nivel avanzado?", "Sí", "No");

            if (respuesta) // Si el usuario selecciona "Sí"
            {
                // Contar cuántos Entry tienen la letra "A"
                int count = 0;
                if (ValencianoEntry.Text == "A") count++;
                if (InglesEntry.Text == "A") count++;
                if (FrancesEntry.Text == "A") count++;

                // Activar los botones Avanzado según el número de "A"
                Avanzado1Button.IsEnabled = count >= 1;
                Avanzado2Button.IsEnabled = count >= 2;
                Avanzado3Button.IsEnabled = count >= 3;

                // Mostrar el mensaje con la suma de idiomas avanzados
                MensajeAvanzado.Text = $"Idiomas a nivel avanzado: {count}";
                MensajeAvanzado.IsVisible = true;
            }
        }

        private async void OnVerCreditosClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Créditos", "Desarrollado por: \n\n Piero Zavala Chira", "OK");
        }
    }
}



