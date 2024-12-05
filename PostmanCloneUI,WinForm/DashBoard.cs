namespace PostmanCloneUI_WinForm;

using PostmanCloneLibrary;

public partial class DashBoard : Form
{
    private readonly IApiAccess _api = new ApiAccess();
    public DashBoard()
    {
        InitializeComponent();
    }

    private void DashBoard_Shown(object sender, EventArgs e)
    {
        this.ActiveControl = null;
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        statusLabel.Text = $"Calling Api";
        resultsTextBox.Text = "";

        if (_api.CheckUrlValidation(apiTextBox.Text) == false)
        {
            statusLabel.Text = "Invalid URL";
            return;
        }

        try
        {
            resultsTextBox.Text = await _api.CallApiAsync(apiTextBox.Text);
            statusLabel.Text = $"Ready";
        }
        catch (Exception ex)
        {

            resultsTextBox.Text = $"Error {ex.Message}";
            statusLabel.Text = "Error";
        }

        this.ActiveControl = null;
    }

    private void clearApiText_Click(object sender, EventArgs e)
    {
        apiTextBox.Text = "";
        resultsTextBox.Text = "";
        apiTextBox.Focus();
        statusLabel.Text = $"Ready";
    }

    private void apiTextBox_TextChanged(object sender, EventArgs e)
    {
        clearApiText.Enabled = !string.IsNullOrEmpty(apiTextBox.Text);
    }
}
