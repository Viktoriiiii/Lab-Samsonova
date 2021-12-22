using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Samsonova
{
    public partial class FormLab01Samsonova : Form
    {
        int old_x, old_y;
        List<Figure> lst = new List<Figure>();
        int iGlobName = 1;
        int add = 0;

        Figure createFigure(string fig_type)
        {
            switch (fig_type)
            {
                case "circle": return new Circle();
                case "square": return new Square();
                case "triangle": return new Triangle();
            }
            return null;
        }

        public FormLab01Samsonova()
        {
            InitializeComponent();
        }

        void pictureBoxPict_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0,
                pictureBoxPict.Width, pictureBoxPict.Height);
            foreach (Figure fig in lst)
                fig.draw(e.Graphics);
        }

        void pictureBoxPict_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {
                foreach (Figure fig in lst)
                {
                    fig.selected |= fig.test(e.X, e.Y);
                    //  MessageBox.Show(e.X.ToString() + " " + e.Y.ToString() + " " + fig.pos_x.ToString() + " " + fig.pos_y.ToString());
                    if (fig.selected)
                    {
                        string name = fig.GetName();
                        for (int i = 0; i < listBoxNames.Items.Count; i++)
                            if (name == listBoxNames.Items[i].ToString()) listBoxNames.SetSelected(i, true);
                    }
                }
            }
            else
            {
                foreach (Figure fig in lst)
                    fig.selected = false;
                listBoxNames.ClearSelected();

                for (int i = lst.Count - 1; i >= 0; i--)
                {
                    Figure fig = lst[i];
                    fig.selected |= fig.test(e.X, e.Y);
                    if (fig.selected)
                    {
                        if (listBoxNames.Items.Contains(fig.GetName()))
                        {
                            listBoxNames.ClearSelected();
                            listBoxNames.SelectedItem = fig.GetName();
                        }
                        break;
                    }
                }
            }
            pictureBoxPict.Invalidate();
        }

        void pictureBoxPict_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;
                foreach (Figure fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;

                }
                pictureBoxPict.Invalidate();
            }
            old_x = e.X;
            old_y = e.Y;
        }

        private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {
                foreach (var list in listBoxNames.SelectedItems)
                    foreach (Figure fig in lst)
                        if (list.ToString() == fig.GetName()) fig.selected = true;
                pictureBoxPict.Invalidate();
            }
            else
            {
                int nItems = lst.Count;
                for (int i = 0; i < nItems; i++)
                {
                    int ind = listBoxNames.SelectedIndex;
                    int indBox = listBoxNames.FindStringExact(lst[i].GetName());
                    if (ind == indBox) lst[i].selected = true;
                    else lst[i].selected = false;
                    pictureBoxPict.Invalidate();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(comboBoxFigure.Text);
            string fig_type = comboBoxFigure.Text;
            if (fig == null) return;
            if (textBoxLength.Text == "")
            {
                MessageBox.Show("Input length");
                textBoxLength.Focus();
                return;
            }
            if (textBoxLength.Text == "0")
            {
                MessageBox.Show("Input number > 0");
                textBoxLength.Focus();
                return;
            }

            float length = (float)Convert.ToDouble(textBoxLength.Text.ToString());

            switch (fig_type)
            {
                case "circle": fig.Set(length); break;
                case "square": fig.Set(length); break;
                case "triangle": fig.Set(length); break;
            }

            listBoxNames.Items.Add(fig.GiveName(iGlobName));
            iGlobName++;

            add++;

            fig.pos_x = pictureBoxPict.Width / 2;
            fig.pos_y = pictureBoxPict.Height / 2;
            lst.Add(fig);
            pictureBoxPict.Invalidate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItems.Count < 2)
            {
                int i = 0;
                while (i < lst.Count)
                {
                    if (lst[i].selected == true)
                    {
                        lst.RemoveAt(i);
                        listBoxNames.Items.Remove(listBoxNames.SelectedItem);
                    }
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Are you sure you want to remove these items?", "Attention!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                foreach (var list in listBoxNames.SelectedItems) // go through the list of selected items in the listbox
                    lst.RemoveAll(x => x.GetName() == list.ToString()); // emoving items that match a condition

                object[] itemsToRemove = new object[listBoxNames.SelectedItems.Count];
                listBoxNames.SelectedItems.CopyTo(itemsToRemove, 0);
                ListBox lsb = new ListBox();

                foreach (object item in itemsToRemove)
                {
                    listBoxNames.Items.Remove(item);
                    lsb.Items.Add(item);
                }
            }
            pictureBoxPict.Invalidate();
        }

        private void textBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == 8) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxLength.Text.Contains(",")) e.Handled = true;
                if (textBoxLength.Text == "") e.Handled = true;
                return;
            }
            e.Handled = true;
        }
    }
}
