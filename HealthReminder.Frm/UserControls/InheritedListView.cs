using System.ComponentModel;

namespace HealthReminder.Frm.UserControls;

/// <summary>
/// Summary description for UserControl1.
/// </summary>
public class MyListView : ListView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private Container components = new();

    public MyListView() => InitializeComponent();

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() => components = new Container();
    #endregion

    private const int WM_HSCROLL = 0x114;
    private const int WM_VSCROLL = 0x115;

    protected override void WndProc(ref Message msg)
    {
        // Look for the WM_VSCROLL or the WM_HSCROLL messages.
        if (msg.Msg is WM_VSCROLL or WM_HSCROLL)
        {
            // Move focus to the ListView to cause ComboBox to lose focus.
            Focus();
        }

        // Pass message to default handler.
        base.WndProc(ref msg);
    }
}