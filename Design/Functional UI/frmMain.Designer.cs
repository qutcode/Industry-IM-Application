namespace Messenger
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.BorderHeaderBottom = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.pnlProfileImage = new System.Windows.Forms.Panel();
            this.BorderProfileBottom = new System.Windows.Forms.Panel();
            this.BorderProfileTop = new System.Windows.Forms.Panel();
            this.BorderProfileRight = new System.Windows.Forms.Panel();
            this.BorderProfileLeft = new System.Windows.Forms.Panel();
            this.pnlChatProfile = new System.Windows.Forms.Panel();
            this.pnlContactImage = new System.Windows.Forms.Panel();
            this.BorderContactBottom = new System.Windows.Forms.Panel();
            this.BorderContactTop = new System.Windows.Forms.Panel();
            this.BorderContactRight = new System.Windows.Forms.Panel();
            this.BorderContactLeft = new System.Windows.Forms.Panel();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.pnlTextContainer = new System.Windows.Forms.Panel();
            this.pnlEmoticon = new System.Windows.Forms.Panel();
            this.pnlEmoticonImage = new System.Windows.Forms.Panel();
            this.BorderEmoticonTop = new System.Windows.Forms.Panel();
            this.BorderEmoticonBottom = new System.Windows.Forms.Panel();
            this.BorderEmoticonRight = new System.Windows.Forms.Panel();
            this.pnlTextbox = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.BorderTextboxTop = new System.Windows.Forms.Panel();
            this.BorderTextboxBottom = new System.Windows.Forms.Panel();
            this.BorderTextboxLeft = new System.Windows.Forms.Panel();
            this.BorderChatLeft = new System.Windows.Forms.Panel();
            this.sizeablePanel1 = new SizeablePanel();
            this.BorderScrollLeft = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.pnlChatProfile.SuspendLayout();
            this.pnlChat.SuspendLayout();
            this.pnlTextContainer.SuspendLayout();
            this.pnlEmoticon.SuspendLayout();
            this.pnlTextbox.SuspendLayout();
            this.sizeablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.BorderHeaderBottom);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // BorderHeaderBottom
            // 
            this.BorderHeaderBottom.BackColor = System.Drawing.Color.Gray;
            this.BorderHeaderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderHeaderBottom.Location = new System.Drawing.Point(0, 60);
            this.BorderHeaderBottom.Name = "BorderHeaderBottom";
            this.BorderHeaderBottom.Size = new System.Drawing.Size(684, 1);
            this.BorderHeaderBottom.TabIndex = 3;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.pnlProfileImage);
            this.pnlProfile.Controls.Add(this.BorderProfileBottom);
            this.pnlProfile.Controls.Add(this.BorderProfileTop);
            this.pnlProfile.Controls.Add(this.BorderProfileRight);
            this.pnlProfile.Controls.Add(this.BorderProfileLeft);
            this.pnlProfile.Location = new System.Drawing.Point(10, 10);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(66, 66);
            this.pnlProfile.TabIndex = 2;
            // 
            // pnlProfileImage
            // 
            this.pnlProfileImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProfileImage.BackgroundImage")));
            this.pnlProfileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProfileImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfileImage.Location = new System.Drawing.Point(1, 1);
            this.pnlProfileImage.Name = "pnlProfileImage";
            this.pnlProfileImage.Size = new System.Drawing.Size(64, 64);
            this.pnlProfileImage.TabIndex = 5;
            // 
            // BorderProfileBottom
            // 
            this.BorderProfileBottom.BackColor = System.Drawing.Color.Gray;
            this.BorderProfileBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderProfileBottom.Location = new System.Drawing.Point(1, 65);
            this.BorderProfileBottom.Name = "BorderProfileBottom";
            this.BorderProfileBottom.Size = new System.Drawing.Size(64, 1);
            this.BorderProfileBottom.TabIndex = 4;
            // 
            // BorderProfileTop
            // 
            this.BorderProfileTop.BackColor = System.Drawing.Color.Gray;
            this.BorderProfileTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderProfileTop.Location = new System.Drawing.Point(1, 0);
            this.BorderProfileTop.Name = "BorderProfileTop";
            this.BorderProfileTop.Size = new System.Drawing.Size(64, 1);
            this.BorderProfileTop.TabIndex = 3;
            // 
            // BorderProfileRight
            // 
            this.BorderProfileRight.BackColor = System.Drawing.Color.Gray;
            this.BorderProfileRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderProfileRight.Location = new System.Drawing.Point(65, 0);
            this.BorderProfileRight.Name = "BorderProfileRight";
            this.BorderProfileRight.Size = new System.Drawing.Size(1, 66);
            this.BorderProfileRight.TabIndex = 2;
            // 
            // BorderProfileLeft
            // 
            this.BorderProfileLeft.BackColor = System.Drawing.Color.Gray;
            this.BorderProfileLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderProfileLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderProfileLeft.Name = "BorderProfileLeft";
            this.BorderProfileLeft.Size = new System.Drawing.Size(1, 66);
            this.BorderProfileLeft.TabIndex = 1;
            // 
            // pnlChatProfile
            // 
            this.pnlChatProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChatProfile.Controls.Add(this.pnlContactImage);
            this.pnlChatProfile.Controls.Add(this.BorderContactBottom);
            this.pnlChatProfile.Controls.Add(this.BorderContactTop);
            this.pnlChatProfile.Controls.Add(this.BorderContactRight);
            this.pnlChatProfile.Controls.Add(this.BorderContactLeft);
            this.pnlChatProfile.Location = new System.Drawing.Point(608, 10);
            this.pnlChatProfile.Name = "pnlChatProfile";
            this.pnlChatProfile.Size = new System.Drawing.Size(66, 66);
            this.pnlChatProfile.TabIndex = 7;
            // 
            // pnlContactImage
            // 
            this.pnlContactImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContactImage.BackgroundImage")));
            this.pnlContactImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContactImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContactImage.Location = new System.Drawing.Point(1, 1);
            this.pnlContactImage.Name = "pnlContactImage";
            this.pnlContactImage.Size = new System.Drawing.Size(64, 64);
            this.pnlContactImage.TabIndex = 5;
            // 
            // BorderContactBottom
            // 
            this.BorderContactBottom.BackColor = System.Drawing.Color.Gray;
            this.BorderContactBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderContactBottom.Location = new System.Drawing.Point(1, 65);
            this.BorderContactBottom.Name = "BorderContactBottom";
            this.BorderContactBottom.Size = new System.Drawing.Size(64, 1);
            this.BorderContactBottom.TabIndex = 4;
            // 
            // BorderContactTop
            // 
            this.BorderContactTop.BackColor = System.Drawing.Color.Gray;
            this.BorderContactTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderContactTop.Location = new System.Drawing.Point(1, 0);
            this.BorderContactTop.Name = "BorderContactTop";
            this.BorderContactTop.Size = new System.Drawing.Size(64, 1);
            this.BorderContactTop.TabIndex = 3;
            // 
            // BorderContactRight
            // 
            this.BorderContactRight.BackColor = System.Drawing.Color.Gray;
            this.BorderContactRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderContactRight.Location = new System.Drawing.Point(65, 0);
            this.BorderContactRight.Name = "BorderContactRight";
            this.BorderContactRight.Size = new System.Drawing.Size(1, 66);
            this.BorderContactRight.TabIndex = 2;
            // 
            // BorderContactLeft
            // 
            this.BorderContactLeft.BackColor = System.Drawing.Color.Gray;
            this.BorderContactLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderContactLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderContactLeft.Name = "BorderContactLeft";
            this.BorderContactLeft.Size = new System.Drawing.Size(1, 66);
            this.BorderContactLeft.TabIndex = 1;
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.White;
            this.pnlChat.Controls.Add(this.pnlTextContainer);
            this.pnlChat.Controls.Add(this.BorderChatLeft);
            this.pnlChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChat.Location = new System.Drawing.Point(200, 61);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(484, 400);
            this.pnlChat.TabIndex = 9;
            // 
            // pnlTextContainer
            // 
            this.pnlTextContainer.BackColor = System.Drawing.Color.White;
            this.pnlTextContainer.Controls.Add(this.pnlEmoticon);
            this.pnlTextContainer.Controls.Add(this.pnlTextbox);
            this.pnlTextContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTextContainer.Location = new System.Drawing.Point(1, 360);
            this.pnlTextContainer.Name = "pnlTextContainer";
            this.pnlTextContainer.Size = new System.Drawing.Size(483, 40);
            this.pnlTextContainer.TabIndex = 0;
            // 
            // pnlEmoticon
            // 
            this.pnlEmoticon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmoticon.Controls.Add(this.pnlEmoticonImage);
            this.pnlEmoticon.Controls.Add(this.BorderEmoticonTop);
            this.pnlEmoticon.Controls.Add(this.BorderEmoticonBottom);
            this.pnlEmoticon.Controls.Add(this.BorderEmoticonRight);
            this.pnlEmoticon.Location = new System.Drawing.Point(447, 10);
            this.pnlEmoticon.Name = "pnlEmoticon";
            this.pnlEmoticon.Size = new System.Drawing.Size(26, 20);
            this.pnlEmoticon.TabIndex = 1;
            // 
            // pnlEmoticonImage
            // 
            this.pnlEmoticonImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmoticonImage.BackgroundImage")));
            this.pnlEmoticonImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmoticonImage.Location = new System.Drawing.Point(0, 1);
            this.pnlEmoticonImage.Name = "pnlEmoticonImage";
            this.pnlEmoticonImage.Size = new System.Drawing.Size(25, 18);
            this.pnlEmoticonImage.TabIndex = 7;
            this.pnlEmoticonImage.Click += new System.EventHandler(this.pnlEmoticonImage_Click);
            // 
            // BorderEmoticonTop
            // 
            this.BorderEmoticonTop.BackColor = System.Drawing.Color.Gray;
            this.BorderEmoticonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderEmoticonTop.Location = new System.Drawing.Point(0, 0);
            this.BorderEmoticonTop.Name = "BorderEmoticonTop";
            this.BorderEmoticonTop.Size = new System.Drawing.Size(25, 1);
            this.BorderEmoticonTop.TabIndex = 6;
            // 
            // BorderEmoticonBottom
            // 
            this.BorderEmoticonBottom.BackColor = System.Drawing.Color.Gray;
            this.BorderEmoticonBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderEmoticonBottom.Location = new System.Drawing.Point(0, 19);
            this.BorderEmoticonBottom.Name = "BorderEmoticonBottom";
            this.BorderEmoticonBottom.Size = new System.Drawing.Size(25, 1);
            this.BorderEmoticonBottom.TabIndex = 5;
            // 
            // BorderEmoticonRight
            // 
            this.BorderEmoticonRight.BackColor = System.Drawing.Color.Gray;
            this.BorderEmoticonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderEmoticonRight.Location = new System.Drawing.Point(25, 0);
            this.BorderEmoticonRight.Name = "BorderEmoticonRight";
            this.BorderEmoticonRight.Size = new System.Drawing.Size(1, 20);
            this.BorderEmoticonRight.TabIndex = 3;
            // 
            // pnlTextbox
            // 
            this.pnlTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextbox.Controls.Add(this.txtMessage);
            this.pnlTextbox.Controls.Add(this.BorderTextboxTop);
            this.pnlTextbox.Controls.Add(this.BorderTextboxBottom);
            this.pnlTextbox.Controls.Add(this.BorderTextboxLeft);
            this.pnlTextbox.Location = new System.Drawing.Point(10, 10);
            this.pnlTextbox.Name = "pnlTextbox";
            this.pnlTextbox.Size = new System.Drawing.Size(438, 20);
            this.pnlTextbox.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(438, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // BorderTextboxTop
            // 
            this.BorderTextboxTop.BackColor = System.Drawing.Color.Gray;
            this.BorderTextboxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTextboxTop.Location = new System.Drawing.Point(1, 0);
            this.BorderTextboxTop.Name = "BorderTextboxTop";
            this.BorderTextboxTop.Size = new System.Drawing.Size(437, 1);
            this.BorderTextboxTop.TabIndex = 6;
            // 
            // BorderTextboxBottom
            // 
            this.BorderTextboxBottom.BackColor = System.Drawing.Color.Gray;
            this.BorderTextboxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderTextboxBottom.Location = new System.Drawing.Point(1, 19);
            this.BorderTextboxBottom.Name = "BorderTextboxBottom";
            this.BorderTextboxBottom.Size = new System.Drawing.Size(437, 1);
            this.BorderTextboxBottom.TabIndex = 5;
            // 
            // BorderTextboxLeft
            // 
            this.BorderTextboxLeft.BackColor = System.Drawing.Color.Gray;
            this.BorderTextboxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderTextboxLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderTextboxLeft.Name = "BorderTextboxLeft";
            this.BorderTextboxLeft.Size = new System.Drawing.Size(1, 20);
            this.BorderTextboxLeft.TabIndex = 2;
            // 
            // BorderChatLeft
            // 
            this.BorderChatLeft.BackColor = System.Drawing.Color.Gray;
            this.BorderChatLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderChatLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderChatLeft.Name = "BorderChatLeft";
            this.BorderChatLeft.Size = new System.Drawing.Size(1, 400);
            this.BorderChatLeft.TabIndex = 1;
            // 
            // sizeablePanel1
            // 
            this.sizeablePanel1.BackColor = System.Drawing.Color.White;
            this.sizeablePanel1.Controls.Add(this.BorderScrollLeft);
            this.sizeablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sizeablePanel1.GripRange = 10;
            this.sizeablePanel1.Location = new System.Drawing.Point(0, 61);
            this.sizeablePanel1.Name = "sizeablePanel1";
            this.sizeablePanel1.Size = new System.Drawing.Size(200, 400);
            this.sizeablePanel1.TabIndex = 10;
            // 
            // BorderScrollLeft
            // 
            this.BorderScrollLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderScrollLeft.BackColor = System.Drawing.Color.Gray;
            this.BorderScrollLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderScrollLeft.Location = new System.Drawing.Point(189, 0);
            this.BorderScrollLeft.Name = "BorderScrollLeft";
            this.BorderScrollLeft.Size = new System.Drawing.Size(1, 400);
            this.BorderScrollLeft.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnlChatProfile);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.sizeablePanel1);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Messenger (Online)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.pnlHeader.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlChatProfile.ResumeLayout(false);
            this.pnlChat.ResumeLayout(false);
            this.pnlTextContainer.ResumeLayout(false);
            this.pnlEmoticon.ResumeLayout(false);
            this.pnlTextbox.ResumeLayout(false);
            this.pnlTextbox.PerformLayout();
            this.sizeablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel BorderHeaderBottom;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel pnlProfileImage;
        private System.Windows.Forms.Panel BorderProfileBottom;
        private System.Windows.Forms.Panel BorderProfileTop;
        private System.Windows.Forms.Panel BorderProfileRight;
        private System.Windows.Forms.Panel BorderProfileLeft;
        private System.Windows.Forms.Panel pnlChatProfile;
        private System.Windows.Forms.Panel pnlContactImage;
        private System.Windows.Forms.Panel BorderContactBottom;
        private System.Windows.Forms.Panel BorderContactTop;
        private System.Windows.Forms.Panel BorderContactRight;
        private System.Windows.Forms.Panel BorderContactLeft;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Panel pnlTextContainer;
        private System.Windows.Forms.Panel pnlEmoticon;
        private System.Windows.Forms.Panel pnlTextbox;
        private System.Windows.Forms.Panel BorderChatLeft;
        private SizeablePanel sizeablePanel1;
        private System.Windows.Forms.Panel BorderScrollLeft;
        private System.Windows.Forms.Panel BorderEmoticonTop;
        private System.Windows.Forms.Panel BorderEmoticonBottom;
        private System.Windows.Forms.Panel BorderEmoticonRight;
        private System.Windows.Forms.Panel BorderTextboxTop;
        private System.Windows.Forms.Panel BorderTextboxBottom;
        private System.Windows.Forms.Panel BorderTextboxLeft;
        private System.Windows.Forms.Panel pnlEmoticonImage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

