namespace HealthReminder.Frm;
public partial class FrmMain : Form
{
    private ListViewItem lvItem = new();

    public FrmMain() => InitializeComponent();

    private void FrmMain_Load(object sender, EventArgs e)
    {
        //Add data to the ListView.
        ListViewItem item;

        //Create sample ListView data.
        item = new ListViewItem("Drink water");
        item.SubItems.Add("Never");
        lsvReminder.Items.Add(item);

        item = new ListViewItem("Deep breath");
        item.SubItems.Add("Never");
        lsvReminder.Items.Add(item);

        item = new ListViewItem("Blink");
        item.SubItems.Add("Never");
        lsvReminder.Items.Add(item);

        item = new ListViewItem("Posture");
        item.SubItems.Add("Never");
        lsvReminder.Items.Add(item);

        item = new ListViewItem("Stretch");
        item.SubItems.Add("Never");
        lsvReminder.Items.Add(item);
    }

    private void LsvReminder_MouseUp(object sender, MouseEventArgs e)
    {
        //Get the item on the row that is clicked.
        lvItem = lsvReminder.GetItemAt(e.X, e.Y) ?? new();

        //Make sure that an item is clicked.
        if (lvItem == null)
        {
            return;
        }

        //Get the bounds of the item that is clicked.
        Rectangle ClickedItem = lvItem.Bounds;

        //Verify that the column is completely scrolled off to the left.
        if ((ClickedItem.Left + lsvReminder.Columns[0].Width) < 0)
        {
            //If the cell is out of view to the left, do nothing.
            return;
        }

        //Verify that the column is partially scrolled off to the left.
        else if (ClickedItem.Left < 0)
        {
            //Determine if column extends beyond right side of ListView.
            if ((ClickedItem.Left + lsvReminder.Columns[0].Width) > lsvReminder.Width)
            {
                //Set width of column to match width of ListView.
                ClickedItem.Width = lsvReminder.Width;
                ClickedItem.X = 0;
            }
            else
            {
                //Right side of cell is in view.
                ClickedItem.Width = lsvReminder.Columns[0].Width + ClickedItem.Left;
                ClickedItem.X = 2;
            }
        }
        else if (lsvReminder.Columns[0].Width > lsvReminder.Width)
        {
            ClickedItem.Width = lsvReminder.Width;
        }
        else
        {
            ClickedItem.Width = lsvReminder.Columns[0].Width;
            ClickedItem.X = 2;
        }

        //Adjust the top to account for the location of the ListView.
        ClickedItem.Y += lsvReminder.Top;
        ClickedItem.X += lsvReminder.Left;

        //Assign calculated bounds to the ComboBox.
        DdlTimeInterval.Bounds = ClickedItem;

        //Set default text for ComboBox to match the item that is clicked.
        DdlTimeInterval.Text = lvItem.Text;

        //Display the ComboBox, and make sure that it is on top with focus.
        DdlTimeInterval.Visible = true;
        DdlTimeInterval.BringToFront();
        DdlTimeInterval.Focus();
    }

    private void DdlTimeInterval_SelectedValueChanged(object sender, EventArgs e)
    {
        //Set text of ListView item to match the ComboBox.
        lvItem.Text = DdlTimeInterval.Text;

        //Hide the ComboBox.
        DdlTimeInterval.Visible = false;
    }

    private void DdlTimeInterval_Leave(object sender, EventArgs e)
    {
        //Set text of ListView item to match the ComboBox.
        lvItem.Text = DdlTimeInterval.Text;

        //Hide the ComboBox.
        DdlTimeInterval.Visible = false;
    }

    private void DdlTimeInterval_KeyPress(object sender, KeyPressEventArgs e)
    {
        //Verify that the user presses ESC.
        switch (e.KeyChar)
        {
            case (char)(int)Keys.Escape:
                //Reset the original text value, and then hide the ComboBox.
                DdlTimeInterval.Text = lvItem.Text;
                DdlTimeInterval.Visible = false;
                break;
            case (char)(int)Keys.Enter:
                //Hide the ComboBox.
                DdlTimeInterval.Visible = false;
                break;
        }
    }
}