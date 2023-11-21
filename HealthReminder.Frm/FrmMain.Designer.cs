using HealthReminder.Frm.UserControls;

namespace HealthReminder.Frm;

partial class FrmMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lsvReminder = new MyListView();
        colReminder = new ColumnHeader();
        colTimeInterval = new ColumnHeader();
        DdlTimeInterval = new ComboBox();
        SuspendLayout();
        // 
        // lsvReminder
        // 
        lsvReminder.Columns.AddRange(new ColumnHeader[] { colReminder, colTimeInterval });
        lsvReminder.FullRowSelect = true;
        lsvReminder.Location = new Point(12, 12);
        lsvReminder.MultiSelect = false;
        lsvReminder.Name = "lsvReminder";
        lsvReminder.Size = new Size(400, 300);
        lsvReminder.TabIndex = 5;
        lsvReminder.UseCompatibleStateImageBehavior = false;
        lsvReminder.View = View.Details;
        lsvReminder.MouseUp += LsvReminder_MouseUp;
        // 
        // colReminder
        // 
        colReminder.Text = "Reminder";
        colReminder.Width = 200;
        // 
        // colTimeInterval
        // 
        colTimeInterval.Text = "Time Interval";
        colTimeInterval.Width = 150;
        // 
        // DdlTimeInterval
        // 
        DdlTimeInterval.FormattingEnabled = true;
        DdlTimeInterval.Items.AddRange(new object[] { "Never", "Every 5 minutes", "Every 10 minutes", "Every 15 minutes", "Every 20 minutes", "Every 30 minutes", "Every 45 minutes", "Every 60 minutes", "Every 90 minutes", "Every 120 minutes" });
        DdlTimeInterval.Location = new Point(12, 289);
        DdlTimeInterval.Name = "DdlTimeInterval";
        DdlTimeInterval.Size = new Size(121, 23);
        DdlTimeInterval.TabIndex = 4;
        DdlTimeInterval.Visible = false;
        DdlTimeInterval.SelectedValueChanged += DdlTimeInterval_SelectedValueChanged;
        DdlTimeInterval.KeyPress += DdlTimeInterval_KeyPress;
        DdlTimeInterval.Leave += DdlTimeInterval_Leave;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(424, 324);
        Controls.Add(DdlTimeInterval);
        Controls.Add(lsvReminder);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmMain";
        Load += FrmMain_Load;
        ResumeLayout(false);
    }

    #endregion
    private MyListView lsvReminder;
    private ComboBox DdlTimeInterval;
    private ColumnHeader colReminder;
    private ColumnHeader colTimeInterval;
}