namespace PostmanCloneUI_WinForm;

using PostmanCloneLibrary;

public partial class DashBoard : Form
{
    private readonly IApiAccess _api;
    public DashBoard(IApiAccess api)
    {
        _api = api;
        InitializeComponent();
    }

    private void DashBoard_Shown(object sender, EventArgs e)
    {
        this.ActiveControl = null;
        httpVerbSelection.SelectedIndex = 0;
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

    private void httpVerbSelection_DrawItem(object sender, DrawItemEventArgs e)
    {
        int index = e.Index >= 0 ? e.Index : 0;
        var brush = Brushes.Black;
        e.DrawBackground();
        e.Graphics.DrawString(httpVerbSelection.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
        e.DrawFocusRectangle();
    }

    private void httpVerbSelection_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.ActiveControl = null ;
    }
}
