namespace LegoDriver
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.connectButton = new System.Windows.Forms.Button( );
            this.disconnectButton = new System.Windows.Forms.Button( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.portBox = new System.Windows.Forms.TextBox( );
            this.modelCombo = new System.Windows.Forms.ComboBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.manipulatorControl = new LegoDriver.ManipulatorControl( );
            this.turnControl = new LegoDriver.TurnControl( );
            this.groupBox3 = new System.Windows.Forms.GroupBox( );
            this.cameraDisconnectButton = new System.Windows.Forms.Button( );
            this.cameraConnectButton = new System.Windows.Forms.Button( );
            this.devicesCombo = new System.Windows.Forms.ComboBox( );
            this.groupBox4 = new System.Windows.Forms.GroupBox( );
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.groupBox3.SuspendLayout( );
            this.groupBox4.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point( 140, 25 );
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size( 75, 23 );
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler( this.connectButton_Click );
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point( 220, 25 );
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size( 75, 23 );
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "&Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler( this.disconnectButton_Click );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Controls.Add( this.portBox );
            this.groupBox1.Controls.Add( this.modelCombo );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.disconnectButton );
            this.groupBox1.Controls.Add( this.connectButton );
            this.groupBox1.Location = new System.Drawing.Point( 10, 10 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 305, 84 );
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lego Brick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 10, 57 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 29, 13 );
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point( 55, 55 );
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size( 60, 20 );
            this.portBox.TabIndex = 7;
            // 
            // modelCombo
            // 
            this.modelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCombo.FormattingEnabled = true;
            this.modelCombo.Items.AddRange( new object[] {
            "RCX",
            "NXT"} );
            this.modelCombo.Location = new System.Drawing.Point( 55, 25 );
            this.modelCombo.Name = "modelCombo";
            this.modelCombo.Size = new System.Drawing.Size( 60, 21 );
            this.modelCombo.TabIndex = 6;
            this.modelCombo.SelectedIndexChanged += new System.EventHandler( this.modelCombo_SelectedIndexChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 10, 27 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 39, 13 );
            this.label1.TabIndex = 5;
            this.label1.Text = "Model:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.manipulatorControl );
            this.groupBox2.Controls.Add( this.turnControl );
            this.groupBox2.Location = new System.Drawing.Point( 10, 100 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 305, 265 );
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manipulation";
            // 
            // manipulatorControl
            // 
            this.manipulatorControl.Enabled = false;
            this.manipulatorControl.Location = new System.Drawing.Point( 52, 20 );
            this.manipulatorControl.Name = "manipulatorControl";
            this.manipulatorControl.Size = new System.Drawing.Size( 200, 200 );
            this.manipulatorControl.TabIndex = 0;
            this.manipulatorControl.PositionChanged += new LegoDriver.ManipulatorControl.PositionChangedHandler( this.manipulatorControl_PositionChanged );
            // 
            // turnControl
            // 
            this.turnControl.Enabled = false;
            this.turnControl.Location = new System.Drawing.Point( 52, 226 );
            this.turnControl.Name = "turnControl";
            this.turnControl.Size = new System.Drawing.Size( 200, 29 );
            this.turnControl.TabIndex = 3;
            this.turnControl.PositionChanged += new LegoDriver.TurnControl.PositionChangedHandler( this.turnControl_PositionChanged );
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add( this.cameraDisconnectButton );
            this.groupBox3.Controls.Add( this.cameraConnectButton );
            this.groupBox3.Controls.Add( this.devicesCombo );
            this.groupBox3.Location = new System.Drawing.Point( 325, 10 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size( 305, 84 );
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // cameraDisconnectButton
            // 
            this.cameraDisconnectButton.Enabled = false;
            this.cameraDisconnectButton.Location = new System.Drawing.Point( 220, 53 );
            this.cameraDisconnectButton.Name = "cameraDisconnectButton";
            this.cameraDisconnectButton.Size = new System.Drawing.Size( 75, 23 );
            this.cameraDisconnectButton.TabIndex = 2;
            this.cameraDisconnectButton.Text = "Disc&onnect";
            this.cameraDisconnectButton.UseVisualStyleBackColor = true;
            this.cameraDisconnectButton.Click += new System.EventHandler( this.cameraDisconnectButton_Click );
            // 
            // cameraConnectButton
            // 
            this.cameraConnectButton.Location = new System.Drawing.Point( 140, 53 );
            this.cameraConnectButton.Name = "cameraConnectButton";
            this.cameraConnectButton.Size = new System.Drawing.Size( 75, 23 );
            this.cameraConnectButton.TabIndex = 1;
            this.cameraConnectButton.Text = "Co&nnect";
            this.cameraConnectButton.UseVisualStyleBackColor = true;
            this.cameraConnectButton.Click += new System.EventHandler( this.cameraConnectButton_Click );
            // 
            // devicesCombo
            // 
            this.devicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Location = new System.Drawing.Point( 10, 25 );
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size( 285, 21 );
            this.devicesCombo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add( this.videoSourcePlayer );
            this.groupBox4.Location = new System.Drawing.Point( 325, 100 );
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size( 305, 265 );
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View";
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point( 10, 20 );
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size( 285, 235 );
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size( 640, 376 );
            this.Controls.Add( this.groupBox4 );
            this.Controls.Add( this.groupBox3 );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.Name = "MainForm";
            this.Text = "Lego Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.MainForm_FormClosing );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.groupBox2.ResumeLayout( false );
            this.groupBox3.ResumeLayout( false );
            this.groupBox4.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private ManipulatorControl manipulatorControl;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private TurnControl turnControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox modelCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button cameraDisconnectButton;
        private System.Windows.Forms.Button cameraConnectButton;
        private System.Windows.Forms.ComboBox devicesCombo;
    }
}

