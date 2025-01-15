namespace ToDoList
{
    partial class ToDoList
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
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 55);
            label1.TabIndex = 0;
            label1.Text = "ToDoList";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(124, 75);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(262, 23);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(124, 122);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(262, 23);
            descriptionTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(18, 75);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.Location = new Point(18, 122);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Описание";
            // 
            // newButton
            // 
            newButton.Location = new Point(432, 75);
            newButton.Name = "newButton";
            newButton.Size = new Size(154, 32);
            newButton.TabIndex = 3;
            newButton.Text = "Очистить";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(432, 116);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(154, 32);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(604, 75);
            editButton.Name = "editButton";
            editButton.Size = new Size(154, 32);
            editButton.TabIndex = 3;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(604, 116);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(154, 32);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(18, 188);
            toDoListView.Name = "toDoListView";
            toDoListView.Size = new Size(770, 250);
            toDoListView.TabIndex = 4;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextbox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ToDoList";
            Text = "To Do List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextbox;
        private Label label2;
        private Label label3;
        private Button newButton;
        private Button deleteButton;
        private Button editButton;
        private Button saveButton;
        private DataGridView toDoListView;
    }
}
