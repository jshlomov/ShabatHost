namespace ShabatHost
{
    partial class HostForm
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
            listView_viewCategories = new ListView();
            button_input = new Button();
            textBox_Category = new TextBox();
            label_input = new Label();
            SuspendLayout();
            // 
            // listView_viewCategories
            // 
            listView_viewCategories.AllowDrop = true;
            listView_viewCategories.FullRowSelect = true;
            listView_viewCategories.Location = new Point(232, 304);
            listView_viewCategories.Margin = new Padding(3, 4, 3, 4);
            listView_viewCategories.Name = "listView_viewCategories";
            listView_viewCategories.Size = new Size(186, 259);
            listView_viewCategories.TabIndex = 7;
            listView_viewCategories.UseCompatibleStateImageBehavior = false;
            // 
            // button_input
            // 
            button_input.Location = new Point(267, 202);
            button_input.Margin = new Padding(3, 4, 3, 4);
            button_input.Name = "button_input";
            button_input.Size = new Size(106, 51);
            button_input.TabIndex = 6;
            button_input.Text = "הכנס";
            button_input.UseVisualStyleBackColor = true;
            button_input.Click += button_input_Click;
            // 
            // textBox_Category
            // 
            textBox_Category.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 177);
            textBox_Category.Location = new Point(232, 136);
            textBox_Category.Margin = new Padding(3, 4, 3, 4);
            textBox_Category.Name = "textBox_Category";
            textBox_Category.Size = new Size(186, 41);
            textBox_Category.TabIndex = 5;
            // 
            // label_input
            // 
            label_input.AutoSize = true;
            label_input.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label_input.Location = new Point(202, 66);
            label_input.Name = "label_input";
            label_input.Size = new Size(260, 36);
            label_input.TabIndex = 4;
            label_input.Text = "מארח - הכנס קטגוריה";
            // 
            // HostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 696);
            Controls.Add(listView_viewCategories);
            Controls.Add(button_input);
            Controls.Add(textBox_Category);
            Controls.Add(label_input);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HostForm";
            Text = "HostForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView_viewCategories;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.TextBox textBox_Category;
        private System.Windows.Forms.Label label_input;
    }
}