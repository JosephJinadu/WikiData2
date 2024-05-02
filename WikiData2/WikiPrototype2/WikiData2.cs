using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WikiPrototype2
{
    public partial class WikiData2 : Form
    {
        //6.2 global List<T> of type Information called Wiki
        private List<Information> Wiki;
        public WikiData2()
        {

            InitializeComponent();
            Wiki = new List<Information>();
            FillCategorycomboBox();
            toolStripStatusLabel1.Text = "WikiData Application opened ";
            const string fileName = "definitions.dat";


            #region Comment and Q4
            /*
             6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide).
             Use private properties for the fields which must be of type “string”. The class file must have separate setters and getters,
             add an appropriate IComparable for the Name attribute. Save the class as “Information.cs”.

             6.2 Create a global List<T> of type Information called Wiki.

             6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for the Category,
             Radio group for the Structure and Multiline TextBox for the Definition.

             6.4 Create a custom method to populate the ComboBox when the Form Load method is called. The six categories must be read from a simple text file.

             6.5 Create a custom ValidName method which will take a parameter string value from the TextBox Name and returns a Boolean after checking for duplicates.
             Use the built-in List<T> method “Exists” to answer this requirement.

             6.6 Create two methods to highlight and return the values from the Radio button GroupBox. The first method must return a string value from the selected radio button (Linear or Non-Linear).
             The second method must send an integer index which will highlight an appropriate radio button.

             6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user has the option to back out of this action by using a dialog box.
             Display an updated version of the sorted list at the end of this process.

             6.8 Create a button method that will save the edited record of the currently selected item in the ListView. All the changes in the input controls will be written back to the list.
             Display an updated version of the sorted list at the end of this process.

             6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.

             6.10 Create a button method that will use the built-in binary search to find a Data Structure name. If the record is found the associated details will populate the appropriate input controls
             and highlight the name in the ListView. At the end of the search process the search input TextBox must be cleared.

             6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button.

             6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button.

             6.13 Create a double click event on the Name TextBox to clear the TextBoxes, ComboBox and Radio button.

             6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file.
             All Wiki data is stored/retrieved using a binary reader/writer file format.

            6.15 The Wiki application will save data when the form closes.

           
            6.16 All code is required to be adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures.
            */
            #endregion

        }
        #region Button 

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // 6.3 AddButton codes
            {
                // Check if all required fields are filled out
                if (!string.IsNullOrEmpty(Nametxtbox.Text) &&
                    !string.IsNullOrEmpty(Categorycombobox.Text) &&
                    !string.IsNullOrEmpty(GetSelectedStructure()) &&
                    !string.IsNullOrEmpty(Defintiontxtbox.Text))
                {
                    // Check if the name is valid (not a duplicate)
                    if (ValidName(Nametxtbox.Text))
                    {
                        try
                        {
                            // Create a new Information object with the input data
                            Information newInformation = new Information(Nametxtbox.Text.ToUpper(), Categorycombobox.Text, GetSelectedStructure(), Defintiontxtbox.Text);

                            // Add the newInformation object to the WikiList
                            Wiki.Add(newInformation);

                            // Clear all input fields after data has been added
                            ResetControls();

                            // Print success message
                            toolStripStatusLabel1.Text = "Successfully added data to the list!";
                        }
                        catch (Exception ex)
                        {
                            // Display error message if an exception occurs
                            toolStripStatusLabel1.Text = ex.Message;
                        }
                    }
                    else
                    {
                        // Print message if name already exists
                        toolStripStatusLabel1.Text = "Name already exists. Please enter a different name.";
                    }
                }
                else
                {
                    // Print message if all fields have not been filled
                    toolStripStatusLabel1.Text = "Please fill out all required fields.";
                    return;
                }

                // Set focus to the Nametxtbox
                Nametxtbox.Focus();

                // Sort the WikiList and display the updated list
                Wiki.Sort();
                DisplayWikiInformation();
            }

        }

        private void ResetInputFields()
        {
            Nametxtbox.Text = "";
            Categorycombobox.SelectedIndex = -1;
            LinearRadioBtn.Checked = false;
            NonLinearRadioBtn.Checked = false;
            Defintiontxtbox.Text = "";
        }

        private string GetSelectedStructure()
        {
            {
                if (LinearRadioBtn.Checked)
                {
                    return "Linear";
                }
                else if (NonLinearRadioBtn.Checked)
                {
                    return "Non-Linear";
                }
                else
                {
                    // Handle case where neither radio button is checked
                    return string.Empty;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        // 6.7  Button method that will delete the currently selected record in the ListView
        {
            {
                // Check if any item is selected in the ListView
                if (ListView.SelectedItems.Count > 0)
                {
                    // Get the selected item
                    ListViewItem selectedItem = ListView.SelectedItems[0];

                    // Get the index of the selected item
                    int selectedIndex = ListView.Items.IndexOf(selectedItem);

                    // Ensure the selected index is within the bounds
                    if (selectedIndex >= 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Remove the selected item from the ListView
                            ListView.Items.RemoveAt(selectedIndex);

                            // Remove the corresponding item from the Wiki list
                            Wiki.RemoveAt(selectedIndex);

                            // Provide feedback
                            toolStripStatusLabel1.Text = "Record deleted successfully.";
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Record deletion cancelled.";
                        }
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Invalid selection.";
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "No record selected for deletion.";
                }
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            {
                // 6.8 Save Button code
                {
                    // Create SaveFileDialog to allow the user to choose the save location
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
                    saveFileDialog.FileName = "definitions.dat";
                    saveFileDialog.Title = "Save data to binary file";

                    // Show SaveFileDialog and handle result
                    DialogResult result = saveFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;

                        try
                        {
                            // Sort the list of Information objects by Name before saving
                            Wiki.Sort();

                            // Write data from the sorted list into the binary file
                            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                            {
                                foreach (var info in Wiki)
                                {
                                    writer.Write(info.Name);
                                    writer.Write(info.Category);
                                    writer.Write(info.Structure);
                                    writer.Write(info.Definition);
                                }
                            }

                            // Provide feedback
                            toolStripStatusLabel1.Text = "Data saved successfully.";
                        }
                        catch (Exception ex)
                        {
                            // Provide feedback in case of error
                            toolStripStatusLabel1.Text = $"Error saving data: {ex.Message}";
                        }
                    }
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            {
                // Get the search name from the input TextBox
                string searchName = Searchtxtbox.Text.ToUpper();

                // Perform binary search on the sorted WikiList by name
                int index = Wiki.BinarySearch(new Information(searchName, "", "", ""),
                                                   Comparer<Information>.Create((x, y) => string.Compare(x.Name, y.Name)));

                // If the record is found
                if (index >= 0)
                {
                    // Clear any previous selections in the ListView
                    ListView.SelectedItems.Clear();

                    // Select the data at the found index in the ListView
                    ListView.Items[index].Selected = true;

                    // Set focus to the ListView
                    ListView.Focus();

                    // Update text boxes and radio buttons with data from WikiList at the found index
                    Nametxtbox.Text = Wiki[index].Name;
                    Categorycombobox.SelectedItem = Wiki[index].Category;
                    if (Wiki[index].Structure == "Linear")
                    {
                        LinearRadioBtn.Checked = true;
                    }
                    else if (Wiki[index].Structure == "Non-Linear")
                    {
                        NonLinearRadioBtn.Checked = true;
                    }
                    Defintiontxtbox.Text = Wiki[index].Definition;

                    // Provide feedback
                    toolStripStatusLabel1.Text = "Found at index " + index;
                }
                else
                {
                    // Provide feedback if the record is not found
                    toolStripStatusLabel1.Text = "Data cannot be found";
                }

                // Clear the search input TextBox
                Searchtxtbox.Text = "";
            }
        }


        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (ListView.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = ListView.SelectedItems[0];

                    if (selectedItem != null)
                    {
                        // Get the data from the selected item and populate the textboxes
                        Nametxtbox.Text = selectedItem.SubItems[0].Text;
                        Categorycombobox.Text = selectedItem.SubItems[1].Text;
                        // Set the appropriate radio button based on the structure value
                        string structure = selectedItem.SubItems[2].Text;
                        if (structure == "Linear")
                        {
                            LinearRadioBtn.Checked = true;
                        }
                        else if (structure == "Non-Linear")
                        {
                            NonLinearRadioBtn.Checked = true;
                        }
                        Defintiontxtbox.Text = selectedItem.SubItems[3].Text;
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            {
                Nametxtbox.Clear();
                Categorycombobox.SelectedIndex = -1;
                LinearRadioBtn.Checked = false;
                NonLinearRadioBtn.Checked = false;
                Defintiontxtbox.Clear();
            }
        }

        #endregion

        #region other void 
        private void ResetControls()
        {
            {
                Nametxtbox.Text = "";
                Categorycombobox.SelectedIndex = -1;
                LinearRadioBtn.Checked = false;
                NonLinearRadioBtn.Checked = false;
                Defintiontxtbox.Text = "";
            }

        }

        private bool ValidName(string name)
        // 6.5: Custom method to check if the name already exists in the list
        {
            {
                if (!string.IsNullOrEmpty(name))
                {
                    // Check if the name already exists in the Wiki list
                    if (Wiki.Exists(info => info.Name.Equals(name.ToUpper())))
                    {
                        // Name already exists, return false
                        return false;
                    }
                    else
                    {
                        // Name doesn't exist, return true
                        return true;
                    }
                }
                else
                {
                    // If the input name is null or empty, return false
                    return false;
                }
            }
        }

        private string GetRadioButton()
        //6.6  two methods to highlight and return the values from the Radio button GroupBox
        {
            if (LinearRadioBtn.Checked)
            {
                return "Linear";
            }
            else if (NonLinearRadioBtn.Checked)
            {
                return "Non-Linear";
            }
            else
            {
                return "";
            }
        }

        private void SetRadioButton(string structure)
        {
            //6.6  two methods to highlight and return the values from the Radio button GroupBox
            if (structure == "Linear")
            {
                LinearRadioBtn.Checked = true;
            }
            else if (structure == "Non-Linear")
            {
                NonLinearRadioBtn.Checked = true;
            }
            else
            {
                // Default behavior: none checked
                LinearRadioBtn.Checked = false;
                NonLinearRadioBtn.Checked = false;
            }
        }

        private void DisplayWikiInformation()
        //6.9 single custom method that will sort and then display the Name and Category from the wiki information in the list
        {
            // Clear existing items from the ListView
            ListView.Items.Clear();

            // Sort the WikiList alphabetically by name
            Wiki.Sort((x, y) => string.Compare(x.Name, y.Name));

            // Iterate through each item in the WikiList
            foreach (var item in Wiki)
            {
                // Create a new ListViewItem with the item's properties
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Category);
                listViewItem.SubItems.Add(item.Structure);
                listViewItem.SubItems.Add(item.Definition);

                // Add the ListViewItem to the ListView
                ListView.Items.Add(listViewItem);
            }

        }

        private void SaveEditedRecord()
        {
            {
                // Check if an item is selected in the ListView
                if (ListView.SelectedItems.Count > 0)
                {
                    // Update the selected item with the new information
                    Information selectedItem = (Information)ListView.SelectedItems[0].Tag;
                    selectedItem.Name = Nametxtbox.Text;
                    selectedItem.Category = Categorycombobox.SelectedItem.ToString();
                    selectedItem.Structure = GetRadioButton();
                    selectedItem.Definition = Defintiontxtbox.Text;

                    // Display the updated list
                    DisplayWikiInformation();
                }
            }
        }

        private void SaveWikiDataToFile()
        {
            {
                // Create SaveFileDialog to allow the user to choose the save location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
                saveFileDialog.FileName = "definitions.dat";
                saveFileDialog.Title = "Save data to binary file";

                // Show SaveFileDialog and handle result
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    // Write data to the selected binary file
                    using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                    {
                        foreach (var info in Wiki)
                        {
                            writer.Write(info.Name);
                            writer.Write(info.Category);
                            writer.Write(info.Structure);
                            writer.Write(info.Definition);
                        }
                    }
                }
            }
        }

        private void ShowData()
        {
            // Clear existing items in the ListView
            ListView.Items.Clear();

            // Loop through each item in the Wiki list and add it to the ListView
            foreach (var item in Wiki)
            {
                // Create a new ListViewItem
                ListViewItem listItem = new ListViewItem(item.Name);

                // Add sub-items to the ListViewItem
                listItem.SubItems.Add(item.Category);
                listItem.SubItems.Add(item.Structure);
                listItem.SubItems.Add(item.Definition);

                // Add the ListViewItem to the ListView
                ListView.Items.Add(listItem);
            }
        }

        #endregion
        #region populate Category combo box 
       
        //6.4 the populate Category combo box 
        private void FillCategorycomboBox()
        {

            // Read categories from the text file
            string[] categories = File.ReadAllLines(@"categories.txt");
            for (int x = 0; x < categories.Length; x++)
            {
                Categorycombobox.Items.Add(categories[x]);
            }



        }

        #endregion

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            {
                // Create and configure an OpenFileDialog instance
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
                openFileDialog.Title = "Open data from binary file";

                // Show OpenFileDialog and handle result
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    try
                    {
                        // Read data from the selected binary file
                        using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                        {
                            // Clear existing data before adding new data from the file
                            Wiki.Clear();
                            ListView.Items.Clear();

                            // Read data from the file until the end is reached
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                try
                                {
                                    // Read data from the file
                                    string name = reader.ReadString().ToUpper();
                                    string category = reader.ReadString();
                                    string structure = reader.ReadString();
                                    string definition = reader.ReadString();

                                    // Create a new Information object with the read data
                                    Information newInformation = new Information(name, category, structure, definition);

                                    // Add the newInformation object to the WikiList
                                    Wiki.Add(newInformation);
                                }
                                catch (Exception fe)
                                {
                                    // Display an error message if data cannot be read from the file or if the end of file is reached unexpectedly
                                    MessageBox.Show("Cannot read data from file or EOF: " + fe.Message);
                                    break; // Exit the loop if an error occurs
                                }
                            }

                            // Display the updated list in the ListView
                            DisplayWikiInformation();
                        }

                        // Provide feedback
                        toolStripStatusLabel1.Text = "Data loaded successfully.";
                    }
                    catch (Exception ex)
                    {
                        // Provide feedback in case of error
                        toolStripStatusLabel1.Text = $"Error loading data: {ex.Message}";
                    }
                }
            }
        }

        private void Edittn_Click(object sender, EventArgs e)
        {
            {
                if (ListView.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = ListView.SelectedItems[0];

                    if (selectedItem != null)
                    {
                        // Update the selected item with the new values from the textboxes
                        selectedItem.SubItems[0].Text = Nametxtbox.Text;
                        selectedItem.SubItems[1].Text = Categorycombobox.Text;
                        selectedItem.SubItems[2].Text = GetSelectedStructure();
                        selectedItem.SubItems[3].Text = Defintiontxtbox.Text;

                        // Optionally, clear the textboxes after editing
                        ResetControls();
                    }
                }
            }




        }

        private void WikiData2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWikiDataToFile();
        }
    }
}



