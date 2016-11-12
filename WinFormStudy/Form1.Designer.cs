using System.Drawing;
using System.Windows.Forms;

namespace WinFormStudy {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rotate = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.ProgramName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ProgramName);
            this.panel1.Controls.Add(this.Rotate);
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 25);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Rotate
            // 
            this.Rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotate.BackColor = System.Drawing.Color.Transparent;
            this.Rotate.BackgroundImage = global::WinFormStudy.Properties.Resources.plainicon1;
            this.Rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rotate.FlatAppearance.BorderSize = 0;
            this.Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rotate.Location = new System.Drawing.Point(707, 0);
            this.Rotate.Margin = new System.Windows.Forms.Padding(1);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(24, 25);
            this.Rotate.TabIndex = 2;
            this.Rotate.UseVisualStyleBackColor = false;
            this.Rotate.Visible = false;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // Open
            // 
            this.Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Open.BackColor = System.Drawing.Color.Transparent;
            this.Open.BackgroundImage = global::WinFormStudy.Properties.Resources.To3El1;
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Location = new System.Drawing.Point(737, 0);
            this.Open.Margin = new System.Windows.Forms.Padding(1);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(24, 25);
            this.Open.TabIndex = 1;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.button3_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = global::WinFormStudy.Properties.Resources.minicons2_33_5121;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Location = new System.Drawing.Point(767, 0);
            this.Maximize.Margin = new System.Windows.Forms.Padding(1);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 25);
            this.Maximize.TabIndex = 1;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.button4_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::WinFormStudy.Properties.Resources.button_close_1281;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(797, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 25);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImageView
            // 
            this.ImageView.BackColor = System.Drawing.Color.Transparent;
            this.ImageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageView.ImageLocation = "";
            this.ImageView.Location = new System.Drawing.Point(0, 25);
            this.ImageView.Margin = new System.Windows.Forms.Padding(0);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(822, 525);
            this.ImageView.TabIndex = 0;
            this.ImageView.TabStop = false;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Location = new System.Drawing.Point(3, 5);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(78, 15);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "Image Viewer";
            this.ProgramName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgramName_MouseDown);
            this.ProgramName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgramName_MouseMove);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(822, 550);
            this.Controls.Add(this.ImageView);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Study Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox ImageView;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Rotate;
        private Label ProgramName;
        }
    }

