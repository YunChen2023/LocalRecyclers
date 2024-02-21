using System.Diagnostics;
using System.IO;
namespace LocalRecyclers
{
    public partial class Form1 : Form
    {
        // recyclerList of recycler data
        // stored in external file 
        private List<Recycler> recyclerList;

        //current selected record (index value)
        private int currentRecord;
        public Form1()
        {
            InitializeComponent();

            find_TextBox.Text = "Enter Business Name to Find";
            find_TextBox.TextAlign = HorizontalAlignment.Center;

            //instantiate the recyclerList
            recyclerList = new List<Recycler>();

            //read external file data and set up recyclerList
            ReadRecyclerData();

            //sort
            recyclerList.Sort();

            //display recycler data in recycler textbox
            DisplayRecyclerData();

            currentRecord = 0;
            DisplayCurrentRecord();
        }

        public void ReadRecyclerData()
        {
            //string filePath = @"C:\Users\jason\source\repos\LocalRecyclers\LocalRecyclers\LocalRecyclers\recyclers.csv";

            string filePath = @"recyclers.csv";
            //string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);
            //Console.WriteLine("Base directory: " + AppDomain.CurrentDomain.BaseDirectory);
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader file = new StreamReader(filePath))
                    {
                        string line;
                        int lineCount = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            lineCount++;

                            //split the line into a string array
                            string[] lineArray = line.Split(',');
                            string reName = lineArray[0];
                            string reAddress = lineArray[1];
                            string rePhone = lineArray[2];
                            string reWebsite = lineArray[3];
                            string reType = lineArray[4];


                            Recycler recycler = new Recycler(reName, reAddress, rePhone, reWebsite, reType);
                            recyclerList.Add(recycler);

                        }//end while loop

                        file.Close();
                    }//end using StreamReader file
                }//end if
                else
                {
                    Console.WriteLine("ERROR: No external file exists for: " + filePath);
                }
            }//end try block
            catch (IOException ioe)
            {
                Console.WriteLine("ERROR: Problem in reading the external file: " + filePath);
                Console.WriteLine(ioe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Problem with external file: " + filePath);
                Console.WriteLine(e.Message);
            }
        }//end ReadRecyclerData() method

        public void DisplayRecyclerData()
        {
            String displayText = "Name\t\tAddress\t\tPhone\t\tWebsite\t\tWaste Type\r\n";
            displayText += "---------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
            for (int i = 0; i < recyclerList.Count(); i++)
            {
                displayText += recyclerList[i].ToString() + "\r\n";

            }
            recycler_TextBox.Text = displayText;
        }

        public void DisplayCurrentRecord()
        {
            name_TextBox.Text = recyclerList[currentRecord].ReName;
            address_TextBox.Text = recyclerList[currentRecord].ReAddress;
            phone_TextBox.Text = recyclerList[currentRecord].RePhone;
            website_TextBox.Text = recyclerList[currentRecord].ReWebsite;
            recycles_TextBox.Text = recyclerList[currentRecord].ReType;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            name_TextBox.Text = "";
            address_TextBox.Text = "";
            phone_TextBox.Text = "";
            website_TextBox.Text = "";
            recycles_TextBox.Text = "";
        }

        public bool IsRecyclerValid()
        {
            bool recyclerStatus = true;
            string errorMessage = "ERROR(S) encountered\n";
            if (String.IsNullOrEmpty(name_TextBox.Text))
            {
                errorMessage += "Business name is required\n";
                recyclerStatus = false;
            }

            if (String.IsNullOrEmpty(address_TextBox.Text))
            {
                errorMessage += "Address is required\n";
                recyclerStatus = false;
            }

            if (String.IsNullOrEmpty(phone_TextBox.Text))
            {
                errorMessage += "Phone number is required\n";
                recyclerStatus = false;
            }

            if (String.IsNullOrEmpty(website_TextBox.Text))
            {
                errorMessage += "Web site is required\n";
                recyclerStatus = false;
            }

            if (String.IsNullOrEmpty(recycles_TextBox.Text))
            {
                errorMessage += "Recyles type is required\n";
                recyclerStatus = false;
            }

            if (recyclerStatus == false)
            {
                MessageBox.Show(errorMessage, "ERRORS!");
            }
            return recyclerStatus;
        }

        private void addNew_Button_Click(object sender, EventArgs e)
        {
            if (IsRecyclerValid() == false)
            {
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you wish to proceed in adding this new recycler record?", "NEW RECYCLER RECORD", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string reName = name_TextBox.Text;
                    string reAddress = address_TextBox.Text;
                    string rePhone = phone_TextBox.Text;
                    string reWebsite = website_TextBox.Text;
                    string reType = recycles_TextBox.Text;

                    Recycler newRecycler = new Recycler(reName, reAddress, rePhone, reWebsite, reType);
                    recyclerList.Add(newRecycler);

                    recyclerList.Sort();
                    DisplayRecyclerData();
                    currentRecord = recyclerList.IndexOf(newRecycler);

                }
            }
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            if (IsRecyclerValid() == false)
            {
                return;
            }
            else
            {
                string originalReName = recyclerList[currentRecord].ReName;
                DialogResult dialogResult = MessageBox.Show("Do you wish to proceed in updating the record for " + originalReName + "?", "UPDATING EXISTING RECYCLER RECORD", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string reName = name_TextBox.Text;
                    string reAddress = address_TextBox.Text;
                    string rePhone = phone_TextBox.Text;
                    string reWebsite = website_TextBox.Text;
                    string reType = recycles_TextBox.Text;

                    Recycler updatedRecycler = new Recycler(reName, reAddress, rePhone, reWebsite, reType);
                    recyclerList[currentRecord] = updatedRecycler;

                    recyclerList.Sort();
                    DisplayRecyclerData();
                    currentRecord = recyclerList.IndexOf(updatedRecycler);
                }
            }
        }

        private void prev_Button_Click(object sender, EventArgs e)
        {
            currentRecord--;
            if (currentRecord < 0)
            {
                currentRecord = recyclerList.Count - 1;
            }
            DisplayCurrentRecord();
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            currentRecord++;
            if (currentRecord == recyclerList.Count)
            {
                currentRecord = 0;
            }
            DisplayCurrentRecord();
        }

        private void first_Button_Click(object sender, EventArgs e)
        {
            currentRecord = 0;
            DisplayCurrentRecord();
        }

        private void last_Button_Click(object sender, EventArgs e)
        {
            currentRecord = recyclerList.Count - 1;
            DisplayCurrentRecord();
        }

        private void find_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void binarySearch_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(find_TextBox.Text))
            {
                MessageBox.Show("Business name is required in the search field", "ERROR!");
                return;
            }
            if (find_TextBox.Text == "Enter Business Name to Find")
            {
                MessageBox.Show("Business name is required in the search field", "ERROR!");
                return;
            }
            else
            {
                string recordToSearch = find_TextBox.Text;
                bool foundStatus = false;
                for (int i = 0; i < recyclerList.Count; i++)
                {
                    if (recordToSearch.Equals(recyclerList[i].ReName))
                    {
                        currentRecord = i;
                        DisplayCurrentRecord();
                        MessageBox.Show(recordToSearch + " found!", "FOUND!");
                        String displayText = "Name\t\tAddress\t\tPhone\t\tWebsite\t\tWaste Type\r\n";
                        displayText += "---------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
                        displayText += recyclerList[i].ToString() + "\r\n";

                        recycler_TextBox.Text = displayText;
                        foundStatus = true;
                        break;
                    }
                }

                if (foundStatus == false)
                {
                    MessageBox.Show(recordToSearch + " NOT found!", "NOT FOUND!");
                }
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            string originalReName = recyclerList[currentRecord].ReName;
            DialogResult dialogResult = MessageBox.Show("Do you wish to proceed in deleting the record for " + originalReName + "?", "DELETING EXISTING RECYCLER RECORD", MessageBoxButtons.YesNo);
            {
                recyclerList.RemoveAt(currentRecord);
                if (currentRecord > 0)
                {
                    currentRecord--;
                }
                DisplayRecyclerData();
            }
        }

        private void fiter_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterType = fiter_ComboBox.SelectedItem.ToString();
            String displayText = "Name\t\tAddress\t\tPhone\t\tWebsite\t\tWaste Type\r\n";
            displayText += "---------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
            if (string.IsNullOrEmpty(filterType))
            {
                // Handle null or empty filterType
                return;
            }
            else
            {
                for (int i = 0; i < recyclerList.Count; i++)
                {
                    if (recyclerList[i].ReType.Contains(filterType))
                    {
                        currentRecord = i;

                        displayText += recyclerList[i].ToString() + "\r\n";

                        recycler_TextBox.Text = displayText;
                        //break;
                    }
                }
            }
        }

        private void url_Button_Click(object sender, EventArgs e)
        {
            string websiteUrl = recyclerList[currentRecord].ReWebsite;
            System.Diagnostics.Process.Start("cmd", "/c start " + websiteUrl);
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are to exit the application - do you wish to SAVE changes to all records?", "SAVE!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (recyclerList.Count > 0)
                {
                    try
                    {
                        //string filePath = @"C:\Users\jason\source\repos\LocalRecyclers\LocalRecyclers\LocalRecyclers\recyclers.csv";
                        string filePath = @"recyclers.csv";
                        StreamWriter sw = new StreamWriter(filePath);

                        for (int i = 0; i < recyclerList.Count; i++)
                        {
                            sw.WriteLine(recyclerList[i].ToCSVString());

                        }
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: Problem in writing to external file!", "ERROR!");
                    }
                }
            }
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);

            }
        }
    }
}