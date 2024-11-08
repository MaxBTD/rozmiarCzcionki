namespace rozmiarCzcionki
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void sizeSldrMoved(object sender, EventArgs e)
        {
            textToChange.FontSize = sldrSize.Value;
            lblFontSize.Text = $"Rozmiar czcionki: {sldrSize.Value.ToString("0.00")}";
        }

        private void radioTextAlign(object sender, EventArgs e) {
            if (radioLeft.IsChecked)
                textToChange.HorizontalTextAlignment = TextAlignment.Start;
            else if(radioRight.IsChecked)
                textToChange.HorizontalTextAlignment= TextAlignment.End;
            else
                textToChange.HorizontalTextAlignment= TextAlignment.Center;
        }

        private void btnChangeColorClicked(object sender, EventArgs e)
        {
            string[] colors = { "#32a852", "#6e2999", "#b32b2b", "#2b8cb3", "#ffffff" };

            if (count < 4)
                count++;
            else
                count = 0;

            textToChange.TextColor = Color.FromHex(colors[count]);
        }
    }

}
