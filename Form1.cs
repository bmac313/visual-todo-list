//-----VISUAL TO-DO LIST, v0.1-----
//--------Brendan M., 2016---------

//> Possible feature: save list with numbering, separate numbers from tasks when loading.
//> Possible feature: export list as html, rtf, etc.

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListCS
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String task = txtTextInput.Text;
            if (String.IsNullOrWhiteSpace(task))
            {
                MessageBox.Show("The input box is empty. Please type something first!", "Error");
            }
            else
            {
                lstList.Items.Add(task);
                lstTaskNumbers.Items.Add(lstList.Items.Count);
                txtTextInput.Clear();
                txtTextInput.Focus();
                checkListForItems(lstList, btnAdd, btnRemove, btnUpdate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((lstList.SelectedIndex) != -1)
            {
                char choice = promptYesOrNo("Are you sure you want to remove that task? This cannot be undone.");
                if (choice == 'y')
                {
                    int selection = lstList.SelectedIndex;
                    lstList.Items.RemoveAt(selection);
                    lstTaskNumbers.Items.RemoveAt(lstList.Items.Count);
                    checkListForItems(lstList, btnAdd, btnRemove, btnUpdate);
                }
                else if (choice == 'n')
                {
                    MessageBox.Show("Cancelled.", "Action cancelled");
                }
            }
            else
            {
                MessageBox.Show("You haven't selected an item to remove yet!", "Error");
            }
        }

        public void toggleButton(Button btn, bool isOn) //true enables button; false disables it.
        {
            btn.Enabled = isOn;
        }

        //check the number of items in the list and enable / disable buttons depending on how many.
        //this method takes in the list and three buttons; these buttons represent the three buttons on 
        //the GUI.
        public void checkListForItems(ListBox lst, Button btn1, Button btn2, Button btn3)
        {
            if (lst.Items.Count <= 0)
            {
                toggleButton(btn1, true);
                toggleButton(btn2, false);
                toggleButton(btn3, false);
            }
            if ((lst.Items.Count > 0) && (lst.Items.Count < 23))
            {
                toggleButton(btn1, true);
                toggleButton(btn2, true);
                toggleButton(btn3, true);
            }
            if (lst.Items.Count >= 23)
            {
                toggleButton(btn1, false);
                toggleButton(btn2, true);
                toggleButton(btn3, true);
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            checkListForItems(lstList, btnAdd, btnRemove, btnUpdate);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((lstList.Items.Count) != 0)
            {
                char choice = promptYesOrNo("Would you like to save your current list before opening a new one?");
                
                if (choice == 'y')
                {
                    saveList();
                    openList();
                }
                else if (choice == 'n')
                {
                    openList();
                }
            }
            else
            {
                openList();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((lstList.Items.Count) > 0)
            {
                char choice = promptYesOrNo("Would you like to save your list before exiting?");
                if (choice == 'y')
                {
                    saveList();
                    this.Close();
                }
                else if (choice == 'n')
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((lstList.Items.Count) != 0)
            {
                char choice = promptYesOrNo("Would you like to save your current list before creating a new one?");
                
                if (choice == 'y')
                {
                    saveList();
                    newList();
                }
                else if (choice == 'n')
                {
                    newList();
                }
            }
            else
            {
                newList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if((lstList.SelectedIndex) != -1)
            {
                int selection = lstList.SelectedIndex;
                string response = Microsoft.VisualBasic.Interaction.InputBox("Please enter an updated task.", "Update Task");
                //only reassign task if the user types something.
                //this helps avoid accidentally setting the task to white space if the user cancels.
                if (!(String.IsNullOrWhiteSpace(response)))
                {
                    lstList.Items[selection] = response;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected an item to update yet!", "Error");
            }
        }

        private void btnStatusSet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added at a later time.", "Feature coming soon!");
        }

        //returns a char, 'y', 'n', or 'c', depending on the user's choice.
        public char promptYesOrNo(string message)
        {
            char choice = 'c'; //default value is 'c' (cancel) for safety purposes.

            DialogResult dResult = MessageBox.Show(message, "Confirm Action", MessageBoxButtons.YesNoCancel);
            if(dResult == DialogResult.Yes)
            {
                choice = 'y';
            }
            else if(dResult == DialogResult.No)
            {
                choice = 'n';
            }
            else if(dResult == DialogResult.Cancel)
            {
                choice = 'c';
            }
            else
            {
                choice = 'c';
            }

            return choice;
        }

        public void saveList()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter saveList = new StreamWriter(sfd.OpenFile());
                for (int i = 0; i < lstList.Items.Count; i++)
                {
                    saveList.WriteLine(lstList.Items[i]);
                }
                saveList.Dispose();
                saveList.Close();
            }

            checkListForItems(lstList, btnAdd, btnRemove, btnUpdate);
        }

        public void newList()
        {
            lstList.Items.Clear();
            lstTaskNumbers.Items.Clear();
            checkListForItems(lstList, btnAdd, btnRemove, btnUpdate);
        }

        public void openList()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lstList.Items.Clear();
                lstTaskNumbers.Items.Clear();
                try
                {
                    using (StreamReader openList = new StreamReader(ofd.OpenFile()))
                    {
                        string line;
                        int count = 1;
                        while ((line = openList.ReadLine()) != null)
                        {
                            lstList.Items.Add(line);
                            lstTaskNumbers.Items.Add(count);
                            count++;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The file could not be read.", "Problem reading file");
                }

                checkListForItems(lstList, btnAdd, btnRemove, btnUpdate);
            }
        }
    }
}
