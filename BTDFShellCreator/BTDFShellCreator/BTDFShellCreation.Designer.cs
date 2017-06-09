namespace BTDFShellCreator
{
    partial class BTDFShellCreation
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
            this.components = new System.ComponentModel.Container();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHomeDir = new System.Windows.Forms.TextBox();
            this.cmdCreateApp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusname = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tooltipHomeDir = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(164, 62);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(548, 20);
            this.txtAppName.TabIndex = 0;
            this.txtAppName.Text = "Bidvest.Integration";
            this.tooltipHomeDir.SetToolTip(this.txtAppName, "This is where you specify the first part of the application name ie Bidvest.Integ" +
        "ration (which is the default option)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application Prefix";
            this.tooltipHomeDir.SetToolTip(this.label1, "This is where you specify the first part of the application name ie Bidvest.Integ" +
        "ration (which is the default option)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home Directory";
            this.tooltipHomeDir.SetToolTip(this.label2, "Please input the folder name you wish your application to be held under ie Custom" +
        "ers or Legacy etc");
            // 
            // txtHomeDir
            // 
            this.txtHomeDir.Location = new System.Drawing.Point(164, 26);
            this.txtHomeDir.Name = "txtHomeDir";
            this.txtHomeDir.Size = new System.Drawing.Size(548, 20);
            this.txtHomeDir.TabIndex = 2;
            this.tooltipHomeDir.SetToolTip(this.txtHomeDir, "Please input the folder name you wish your application to be held under ie Custom" +
        "ers or Legacy etc");
            // 
            // cmdCreateApp
            // 
            this.cmdCreateApp.Location = new System.Drawing.Point(384, 334);
            this.cmdCreateApp.Name = "cmdCreateApp";
            this.cmdCreateApp.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateApp.TabIndex = 4;
            this.cmdCreateApp.Text = "Create App";
            this.cmdCreateApp.UseVisualStyleBackColor = true;
            this.cmdCreateApp.Click += new System.EventHandler(this.cmdCreateApp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Application Type";
            this.tooltipHomeDir.SetToolTip(this.label3, "Please type in the type of app ie Customer");
            // 
            // txtAppType
            // 
            this.txtAppType.Location = new System.Drawing.Point(164, 97);
            this.txtAppType.Name = "txtAppType";
            this.txtAppType.Size = new System.Drawing.Size(548, 20);
            this.txtAppType.TabIndex = 5;
            this.tooltipHomeDir.SetToolTip(this.txtAppType, "Please type in the type of app ie Customer");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Name";
            this.tooltipHomeDir.SetToolTip(this.label4, "Please type in the name of the customer or third party");
            // 
            // txtCusname
            // 
            this.txtCusname.Location = new System.Drawing.Point(164, 132);
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.Size = new System.Drawing.Size(548, 20);
            this.txtCusname.TabIndex = 7;
            this.tooltipHomeDir.SetToolTip(this.txtCusname, "Please type in the name of the customer or third party");
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(164, 200);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(548, 82);
            this.txtDisplay.TabIndex = 9;
            // 
            // BTDFShellCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 427);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCusname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAppType);
            this.Controls.Add(this.cmdCreateApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHomeDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAppName);
            this.Name = "BTDFShellCreation";
            this.Text = "BTDF Shell Creator";
            this.Load += new System.EventHandler(this.BTDFShellCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHomeDir;
        private System.Windows.Forms.Button cmdCreateApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusname;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.ToolTip tooltipHomeDir;
    }
}

