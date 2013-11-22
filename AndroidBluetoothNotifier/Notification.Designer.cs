namespace AndroidBluetoothNotifier
{
    partial class Notification
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleNotification = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.labelBodyNotification = new AndroidBluetoothNotifier.WrapLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelTitleNotification, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSeparator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBodyNotification, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 143);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelTitleNotification
            // 
            this.labelTitleNotification.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitleNotification.AutoEllipsis = true;
            this.labelTitleNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleNotification.Location = new System.Drawing.Point(51, 0);
            this.labelTitleNotification.Name = "labelTitleNotification";
            this.labelTitleNotification.Size = new System.Drawing.Size(249, 40);
            this.labelTitleNotification.TabIndex = 0;
            this.labelTitleNotification.Text = "label1";
            this.labelTitleNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconBox
            // 
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconBox.Location = new System.Drawing.Point(3, 3);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(42, 34);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconBox.TabIndex = 3;
            this.iconBox.TabStop = false;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.labelSeparator, 2);
            this.labelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparator.Location = new System.Drawing.Point(3, 40);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(297, 2);
            this.labelSeparator.TabIndex = 4;
            // 
            // labelBodyNotification
            // 
            this.labelBodyNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBodyNotification.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelBodyNotification, 2);
            this.labelBodyNotification.Location = new System.Drawing.Point(3, 91);
            this.labelBodyNotification.Name = "labelBodyNotification";
            this.labelBodyNotification.Padding = new System.Windows.Forms.Padding(5, 5, 8, 10);
            this.labelBodyNotification.Size = new System.Drawing.Size(297, 2);
            this.labelBodyNotification.TabIndex = 5;
            this.labelBodyNotification.Text = "wrapLabel1";
            this.labelBodyNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(293, 143);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Notification_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label labelSeparator;
        private WrapLabel labelBodyNotification;
        private System.Windows.Forms.Label labelTitleNotification;
    }
}