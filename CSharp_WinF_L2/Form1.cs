namespace CSharp_WinF_L2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnClearDest_Click(object sender, EventArgs e)
        {
            lstDest.Items.Clear();
            pbDest.Value = 0;
        }

        private void btnAddDest_Click(object sender, EventArgs e)
        {


            if (chbDelSource.Checked)
            {
                for (int i = 0; i < lstSource.SelectedItems.Count; i++)
                {
                    MoveItem(lstSource, lstDest);
                }
            }
            else
            {
                for (int i = 0; i < lstSource.SelectedItems.Count; i++)
                {
                    lstDest.Items.Add(lstSource.SelectedItems[i]);
                }
            }
            pgValue();
        }
        private void pgValue()
        {
            int p = lstDest.Items.Count * 20;
            if (p > 100) { p = 100; }
            pbDest.Value = p;
            p = lstSource.Items.Count * 20;
            if (p > 100) { p = 100; }
            pbSource.Value = p;
        }

        private void btnAddDestAll_Click(object sender, EventArgs e)
        {


            if (chbDelSource.Checked)
            {
                lstDest.Items.AddRange(lstSource.Items);
                lstSource.Items.Clear();
            }
            else
            {
                lstDest.Items.AddRange(lstSource.Items);

            }
            pgValue();
        }


        private void MoveItem(ListBox Source, ListBox Dest)
        {
            for (int i = 0; i < Source.SelectedItems.Count;)
            {
                Dest.Items.Add(Source.SelectedItems[i]);
                Source.Items.Remove(Source.SelectedItems[i]);
            }
        }

        private void lstAddRes_Click(object sender, EventArgs e)
        {


            if (chbDelSource.Checked)
            {
                for (int i = 0; i < lstDest.SelectedItems.Count;)
                {
                    MoveItem(lstDest, lstSource);
                }
            }
            else
            {
                for (int i = 0; i < lstDest.SelectedItems.Count;)
                {
                    lstSource.Items.Add(lstDest.SelectedItems[i]);
                }
            }
            pgValue();
        }

        private void lstAddResAll_Click(object sender, EventArgs e)
        {


            if (chbDelSource.Checked)
            {
                lstSource.Items.AddRange(lstDest.Items);
                lstDest.Items.Clear();
            }
            else
            {
                lstSource.Items.AddRange(lstDest.Items);

            }
            pgValue();
        }

        private void pbSource_Click(object sender, EventArgs e)
        {

        }

        private void pbDest_Click(object sender, EventArgs e)
        {

        }
        Form form;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if ((form is null) || (!form.Created))
            {
                form = new Form2(lstDest);
                form.Show();
            }
        }
    }
}
