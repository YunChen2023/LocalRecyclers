namespace LocalRecyclers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contract_Panel = new Panel();
            url_Button = new Button();
            last_Button = new Button();
            next_Button = new Button();
            prev_Button = new Button();
            first_Button = new Button();
            recycles_TextBox = new TextBox();
            website_TextBox = new TextBox();
            phone_TextBox = new TextBox();
            address_TextBox = new TextBox();
            name_TextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            find_Panel = new Panel();
            exit_Button = new Button();
            delete_Button = new Button();
            update_Button = new Button();
            addNew_Button = new Button();
            clear_Button = new Button();
            binarySearch_Button = new Button();
            find_TextBox = new TextBox();
            label7 = new Label();
            list_Panel = new Panel();
            recycler_TextBox = new TextBox();
            label9 = new Label();
            fiter_ComboBox = new ComboBox();
            label8 = new Label();
            contract_Panel.SuspendLayout();
            find_Panel.SuspendLayout();
            list_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // contract_Panel
            // 
            contract_Panel.BackColor = SystemColors.Info;
            contract_Panel.Controls.Add(url_Button);
            contract_Panel.Controls.Add(last_Button);
            contract_Panel.Controls.Add(next_Button);
            contract_Panel.Controls.Add(prev_Button);
            contract_Panel.Controls.Add(first_Button);
            contract_Panel.Controls.Add(recycles_TextBox);
            contract_Panel.Controls.Add(website_TextBox);
            contract_Panel.Controls.Add(phone_TextBox);
            contract_Panel.Controls.Add(address_TextBox);
            contract_Panel.Controls.Add(name_TextBox);
            contract_Panel.Controls.Add(label6);
            contract_Panel.Controls.Add(label5);
            contract_Panel.Controls.Add(label4);
            contract_Panel.Controls.Add(label3);
            contract_Panel.Controls.Add(label2);
            contract_Panel.Controls.Add(label1);
            contract_Panel.Location = new Point(12, 12);
            contract_Panel.Name = "contract_Panel";
            contract_Panel.Size = new Size(561, 433);
            contract_Panel.TabIndex = 0;
            // 
            // url_Button
            // 
            url_Button.BackColor = SystemColors.ButtonFace;
            url_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            url_Button.Location = new Point(422, 386);
            url_Button.Name = "url_Button";
            url_Button.Size = new Size(113, 28);
            url_Button.TabIndex = 15;
            url_Button.Text = "GO TO URL";
            url_Button.UseVisualStyleBackColor = false;
            url_Button.Click += url_Button_Click;
            // 
            // last_Button
            // 
            last_Button.BackColor = SystemColors.ButtonFace;
            last_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            last_Button.Location = new Point(324, 386);
            last_Button.Name = "last_Button";
            last_Button.Size = new Size(75, 28);
            last_Button.TabIndex = 14;
            last_Button.Text = "LAST";
            last_Button.UseVisualStyleBackColor = false;
            last_Button.Click += last_Button_Click;
            // 
            // next_Button
            // 
            next_Button.BackColor = SystemColors.ButtonFace;
            next_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            next_Button.Location = new Point(226, 386);
            next_Button.Name = "next_Button";
            next_Button.Size = new Size(75, 28);
            next_Button.TabIndex = 13;
            next_Button.Text = "NEXT";
            next_Button.UseVisualStyleBackColor = false;
            next_Button.Click += next_Button_Click;
            // 
            // prev_Button
            // 
            prev_Button.BackColor = SystemColors.ButtonFace;
            prev_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            prev_Button.ForeColor = Color.Black;
            prev_Button.Location = new Point(128, 386);
            prev_Button.Name = "prev_Button";
            prev_Button.Size = new Size(75, 28);
            prev_Button.TabIndex = 12;
            prev_Button.Text = "PREV";
            prev_Button.TextAlign = ContentAlignment.TopCenter;
            prev_Button.UseVisualStyleBackColor = false;
            prev_Button.Click += prev_Button_Click;
            // 
            // first_Button
            // 
            first_Button.BackColor = SystemColors.ButtonFace;
            first_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            first_Button.ForeColor = Color.Black;
            first_Button.Location = new Point(30, 386);
            first_Button.Name = "first_Button";
            first_Button.Size = new Size(75, 28);
            first_Button.TabIndex = 11;
            first_Button.Text = "FIRST";
            first_Button.TextAlign = ContentAlignment.TopCenter;
            first_Button.UseVisualStyleBackColor = false;
            first_Button.Click += first_Button_Click;
            // 
            // recycles_TextBox
            // 
            recycles_TextBox.Location = new Point(180, 263);
            recycles_TextBox.Multiline = true;
            recycles_TextBox.Name = "recycles_TextBox";
            recycles_TextBox.Size = new Size(319, 89);
            recycles_TextBox.TabIndex = 10;
            // 
            // website_TextBox
            // 
            website_TextBox.Location = new Point(180, 215);
            website_TextBox.Name = "website_TextBox";
            website_TextBox.Size = new Size(319, 23);
            website_TextBox.TabIndex = 9;
            // 
            // phone_TextBox
            // 
            phone_TextBox.Location = new Point(180, 169);
            phone_TextBox.Name = "phone_TextBox";
            phone_TextBox.Size = new Size(319, 23);
            phone_TextBox.TabIndex = 8;
            // 
            // address_TextBox
            // 
            address_TextBox.Location = new Point(180, 122);
            address_TextBox.Name = "address_TextBox";
            address_TextBox.Size = new Size(319, 23);
            address_TextBox.TabIndex = 7;
            // 
            // name_TextBox
            // 
            name_TextBox.Location = new Point(180, 75);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new Size(319, 23);
            name_TextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(78, 262);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Recycles:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(75, 215);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Web Site:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(93, 168);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Business Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(165, 26);
            label1.Name = "label1";
            label1.Size = new Size(240, 44);
            label1.TabIndex = 0;
            label1.Text = "Local Recycler Contracts\r\n\r\n";
            // 
            // find_Panel
            // 
            find_Panel.BackColor = SystemColors.Info;
            find_Panel.Controls.Add(exit_Button);
            find_Panel.Controls.Add(delete_Button);
            find_Panel.Controls.Add(update_Button);
            find_Panel.Controls.Add(addNew_Button);
            find_Panel.Controls.Add(clear_Button);
            find_Panel.Controls.Add(binarySearch_Button);
            find_Panel.Controls.Add(find_TextBox);
            find_Panel.Controls.Add(label7);
            find_Panel.Location = new Point(589, 12);
            find_Panel.Name = "find_Panel";
            find_Panel.Size = new Size(383, 433);
            find_Panel.TabIndex = 1;
            // 
            // exit_Button
            // 
            exit_Button.BackColor = SystemColors.ButtonFace;
            exit_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            exit_Button.Location = new Point(269, 386);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(84, 33);
            exit_Button.TabIndex = 21;
            exit_Button.Text = "EXIT";
            exit_Button.UseVisualStyleBackColor = false;
            exit_Button.Click += exit_Button_Click;
            // 
            // delete_Button
            // 
            delete_Button.BackColor = SystemColors.ButtonFace;
            delete_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete_Button.Location = new Point(90, 295);
            delete_Button.Name = "delete_Button";
            delete_Button.Size = new Size(233, 33);
            delete_Button.TabIndex = 20;
            delete_Button.Text = "Delete Existing Record";
            delete_Button.UseVisualStyleBackColor = false;
            delete_Button.Click += delete_Button_Click;
            // 
            // update_Button
            // 
            update_Button.BackColor = SystemColors.ButtonFace;
            update_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            update_Button.Location = new Point(90, 253);
            update_Button.Name = "update_Button";
            update_Button.Size = new Size(233, 33);
            update_Button.TabIndex = 19;
            update_Button.Text = "Update Existing Button";
            update_Button.UseVisualStyleBackColor = false;
            update_Button.Click += update_Button_Click;
            // 
            // addNew_Button
            // 
            addNew_Button.BackColor = SystemColors.ButtonFace;
            addNew_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addNew_Button.Location = new Point(90, 211);
            addNew_Button.Name = "addNew_Button";
            addNew_Button.Size = new Size(233, 33);
            addNew_Button.TabIndex = 18;
            addNew_Button.Text = "Add New Record";
            addNew_Button.UseVisualStyleBackColor = false;
            addNew_Button.Click += addNew_Button_Click;
            // 
            // clear_Button
            // 
            clear_Button.BackColor = SystemColors.ButtonFace;
            clear_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clear_Button.Location = new Point(90, 169);
            clear_Button.Name = "clear_Button";
            clear_Button.Size = new Size(233, 33);
            clear_Button.TabIndex = 17;
            clear_Button.Text = "Clear Fields";
            clear_Button.UseVisualStyleBackColor = false;
            clear_Button.Click += clear_Button_Click;
            // 
            // binarySearch_Button
            // 
            binarySearch_Button.BackColor = SystemColors.ButtonFace;
            binarySearch_Button.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            binarySearch_Button.Location = new Point(74, 66);
            binarySearch_Button.Name = "binarySearch_Button";
            binarySearch_Button.Size = new Size(279, 33);
            binarySearch_Button.TabIndex = 16;
            binarySearch_Button.Text = "Binary Search by Business Name";
            binarySearch_Button.UseVisualStyleBackColor = false;
            binarySearch_Button.Click += binarySearch_Button_Click;
            // 
            // find_TextBox
            // 
            find_TextBox.Location = new Point(74, 26);
            find_TextBox.Name = "find_TextBox";
            find_TextBox.Size = new Size(279, 23);
            find_TextBox.TabIndex = 7;
            find_TextBox.TextChanged += find_TextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(13, 26);
            label7.Name = "label7";
            label7.Size = new Size(55, 22);
            label7.TabIndex = 1;
            label7.Text = "Find:";
            // 
            // list_Panel
            // 
            list_Panel.BackColor = SystemColors.GradientInactiveCaption;
            list_Panel.Controls.Add(recycler_TextBox);
            list_Panel.Controls.Add(label9);
            list_Panel.Controls.Add(fiter_ComboBox);
            list_Panel.Controls.Add(label8);
            list_Panel.Location = new Point(12, 460);
            list_Panel.Name = "list_Panel";
            list_Panel.Size = new Size(960, 189);
            list_Panel.TabIndex = 2;
            // 
            // recycler_TextBox
            // 
            recycler_TextBox.Location = new Point(13, 64);
            recycler_TextBox.Multiline = true;
            recycler_TextBox.Name = "recycler_TextBox";
            recycler_TextBox.ScrollBars = ScrollBars.Vertical;
            recycler_TextBox.Size = new Size(887, 112);
            recycler_TextBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 38);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 6;
            label9.Text = "Recycler Listing:";
            // 
            // fiter_ComboBox
            // 
            fiter_ComboBox.FormattingEnabled = true;
            fiter_ComboBox.Items.AddRange(new object[] { "Electronic Waste", "Household Waste", "Hazardous Waste", "Unwanted Items", "Scrap Metal", "Scrap Cars", "Green Waste" });
            fiter_ComboBox.Location = new Point(686, 21);
            fiter_ComboBox.Name = "fiter_ComboBox";
            fiter_ComboBox.Size = new Size(214, 23);
            fiter_ComboBox.TabIndex = 3;
            fiter_ComboBox.SelectedIndexChanged += fiter_ComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(590, 22);
            label8.Name = "label8";
            label8.Size = new Size(90, 22);
            label8.TabIndex = 2;
            label8.Text = "Filter by:";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(list_Panel);
            Controls.Add(find_Panel);
            Controls.Add(contract_Panel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Local Recyclers";
            contract_Panel.ResumeLayout(false);
            contract_Panel.PerformLayout();
            find_Panel.ResumeLayout(false);
            find_Panel.PerformLayout();
            list_Panel.ResumeLayout(false);
            list_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contract_Panel;
        private TextBox recycles_TextBox;
        private TextBox website_TextBox;
        private TextBox phone_TextBox;
        private TextBox address_TextBox;
        private TextBox name_TextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel find_Panel;
        private Panel list_Panel;
        private Button url_Button;
        private Button last_Button;
        private Button next_Button;
        private Button prev_Button;
        private Button first_Button;
        private Label label7;
        private Label label8;
        private Button exit_Button;
        private Button delete_Button;
        private Button update_Button;
        private Button addNew_Button;
        private Button clear_Button;
        private Button binarySearch_Button;
        private TextBox find_TextBox;
        private TextBox recycler_TextBox;
        private Label label9;
        private ComboBox fiter_ComboBox;
    }
}