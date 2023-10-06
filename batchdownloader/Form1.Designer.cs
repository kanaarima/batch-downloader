namespace batchdownloader
{
    partial class main
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
            tabControl1 = new TabControl();
            general = new TabPage();
            button1 = new Button();
            pathtextbox = new TextBox();
            label1 = new Label();
            tabmapsetdownloader = new TabPage();
            updatelabel = new Label();
            updatetextbox = new TextBox();
            startbutton = new Button();
            updatebar = new ProgressBar();
            button2 = new Button();
            listpathtextbox = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            general.SuspendLayout();
            tabmapsetdownloader.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(general);
            tabControl1.Controls.Add(tabmapsetdownloader);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(580, 331);
            tabControl1.TabIndex = 0;
            // 
            // general
            // 
            general.Controls.Add(button1);
            general.Controls.Add(pathtextbox);
            general.Controls.Add(label1);
            general.Location = new Point(4, 24);
            general.Name = "general";
            general.Padding = new Padding(3);
            general.Size = new Size(572, 303);
            general.TabIndex = 0;
            general.Text = "General";
            general.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(491, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "select...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pathtextbox
            // 
            pathtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathtextbox.Location = new Point(8, 27);
            pathtextbox.Name = "pathtextbox";
            pathtextbox.Size = new Size(477, 23);
            pathtextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(193, 21);
            label1.TabIndex = 0;
            label1.Text = "Osu songs/download path";
            // 
            // tabmapsetdownloader
            // 
            tabmapsetdownloader.Controls.Add(updatelabel);
            tabmapsetdownloader.Controls.Add(updatetextbox);
            tabmapsetdownloader.Controls.Add(startbutton);
            tabmapsetdownloader.Controls.Add(updatebar);
            tabmapsetdownloader.Controls.Add(button2);
            tabmapsetdownloader.Controls.Add(listpathtextbox);
            tabmapsetdownloader.Controls.Add(label2);
            tabmapsetdownloader.Location = new Point(4, 24);
            tabmapsetdownloader.Name = "tabmapsetdownloader";
            tabmapsetdownloader.Padding = new Padding(3);
            tabmapsetdownloader.Size = new Size(572, 303);
            tabmapsetdownloader.TabIndex = 1;
            tabmapsetdownloader.Text = "Batch list downloader";
            tabmapsetdownloader.UseVisualStyleBackColor = true;
            // 
            // updatelabel
            // 
            updatelabel.AutoSize = true;
            updatelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updatelabel.Location = new Point(8, 53);
            updatelabel.Name = "updatelabel";
            updatelabel.Size = new Size(102, 21);
            updatelabel.TabIndex = 10;
            updatelabel.Text = "Progress: 0/0";
            // 
            // updatetextbox
            // 
            updatetextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updatetextbox.Location = new Point(8, 107);
            updatetextbox.Multiline = true;
            updatetextbox.Name = "updatetextbox";
            updatetextbox.ReadOnly = true;
            updatetextbox.Size = new Size(556, 188);
            updatetextbox.TabIndex = 9;
            // 
            // startbutton
            // 
            startbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startbutton.Enabled = false;
            startbutton.Location = new Point(489, 78);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(75, 23);
            startbutton.TabIndex = 8;
            startbutton.Text = "start/stop";
            startbutton.UseVisualStyleBackColor = true;
            startbutton.Click += button3_Click;
            // 
            // updatebar
            // 
            updatebar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updatebar.Location = new Point(8, 78);
            updatebar.Name = "updatebar";
            updatebar.Size = new Size(477, 23);
            updatebar.TabIndex = 7;
            updatebar.Click += progressBar1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(489, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "select...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listpathtextbox
            // 
            listpathtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listpathtextbox.Location = new Point(8, 27);
            listpathtextbox.Name = "listpathtextbox";
            listpathtextbox.Size = new Size(477, 23);
            listpathtextbox.TabIndex = 4;
            listpathtextbox.TextChanged += listpathtextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 3);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 3;
            label2.Text = "Beatmapset list";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 331);
            Controls.Add(tabControl1);
            Name = "main";
            Text = "Batch beatmap downloader";
            tabControl1.ResumeLayout(false);
            general.ResumeLayout(false);
            general.PerformLayout();
            tabmapsetdownloader.ResumeLayout(false);
            tabmapsetdownloader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage general;
        private Button button1;
        private TextBox pathtextbox;
        private Label label1;
        private TabPage tabmapsetdownloader;
        private Button button2;
        private TextBox listpathtextbox;
        private Label label2;
        private Label updatelabel;
        private TextBox updatetextbox;
        private Button startbutton;
        private ProgressBar updatebar;
    }
}