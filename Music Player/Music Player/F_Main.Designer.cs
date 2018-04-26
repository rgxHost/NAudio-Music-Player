namespace Music_Player
{
    partial class F_Main
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
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.lbl_TotalTime = new System.Windows.Forms.Label();
            this.lbl_CurrentTime = new System.Windows.Forms.Label();
            this.btn_Repeat = new System.Windows.Forms.Button();
            this.trkb_Position = new System.Windows.Forms.TrackBar();
            this.pic_AlbumArt = new System.Windows.Forms.PictureBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.picBorder_Bottom = new System.Windows.Forms.PictureBox();
            this.picBorder_Right = new System.Windows.Forms.PictureBox();
            this.picBorder_Left = new System.Windows.Forms.PictureBox();
            this.picBorder_Top = new System.Windows.Forms.PictureBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.lbl_TrackName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_State
            // 
            this.lbl_State.Font = new System.Drawing.Font("DS-Digital", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ForeColor = System.Drawing.Color.Silver;
            this.lbl_State.Location = new System.Drawing.Point(132, 5);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(68, 10);
            this.lbl_State.TabIndex = 44;
            this.lbl_State.Text = "PLAYING";
            this.lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.Font = new System.Drawing.Font("DS-Digital", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArtistName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_ArtistName.Location = new System.Drawing.Point(134, 43);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Size = new System.Drawing.Size(268, 10);
            this.lbl_ArtistName.TabIndex = 43;
            this.lbl_ArtistName.Text = "Artist Band Name";
            this.lbl_ArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TotalTime
            // 
            this.lbl_TotalTime.AutoSize = true;
            this.lbl_TotalTime.Font = new System.Drawing.Font("DS-Digital", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalTime.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_TotalTime.Location = new System.Drawing.Point(362, 68);
            this.lbl_TotalTime.Name = "lbl_TotalTime";
            this.lbl_TotalTime.Size = new System.Drawing.Size(38, 12);
            this.lbl_TotalTime.TabIndex = 41;
            this.lbl_TotalTime.Text = "000:00";
            this.lbl_TotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CurrentTime
            // 
            this.lbl_CurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CurrentTime.AutoSize = true;
            this.lbl_CurrentTime.Font = new System.Drawing.Font("DS-Digital", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTime.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_CurrentTime.Location = new System.Drawing.Point(132, 67);
            this.lbl_CurrentTime.Name = "lbl_CurrentTime";
            this.lbl_CurrentTime.Size = new System.Drawing.Size(45, 13);
            this.lbl_CurrentTime.TabIndex = 40;
            this.lbl_CurrentTime.Text = "000:00";
            this.lbl_CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Repeat
            // 
            this.btn_Repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Repeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repeat.ForeColor = System.Drawing.Color.White;
            this.btn_Repeat.Location = new System.Drawing.Point(334, 95);
            this.btn_Repeat.Name = "btn_Repeat";
            this.btn_Repeat.Size = new System.Drawing.Size(30, 30);
            this.btn_Repeat.TabIndex = 26;
            this.btn_Repeat.UseVisualStyleBackColor = true;
            this.btn_Repeat.Click += new System.EventHandler(this.BtnClick);
            // 
            // trkb_Position
            // 
            this.trkb_Position.AutoSize = false;
            this.trkb_Position.Location = new System.Drawing.Point(183, 67);
            this.trkb_Position.Name = "trkb_Position";
            this.trkb_Position.Size = new System.Drawing.Size(173, 13);
            this.trkb_Position.TabIndex = 30;
            this.trkb_Position.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pic_AlbumArt
            // 
            this.pic_AlbumArt.Location = new System.Drawing.Point(6, 5);
            this.pic_AlbumArt.Name = "pic_AlbumArt";
            this.pic_AlbumArt.Size = new System.Drawing.Size(120, 120);
            this.pic_AlbumArt.TabIndex = 45;
            this.pic_AlbumArt.TabStop = false;
            // 
            // btn_Load
            // 
            this.btn_Load.BackgroundImage = global::Music_Player.Properties.Resources.LIST;
            this.btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Reitam", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Load.Location = new System.Drawing.Point(370, 95);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(30, 30);
            this.btn_Load.TabIndex = 35;
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.BtnClick);
            // 
            // picBorder_Bottom
            // 
            this.picBorder_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBorder_Bottom.BackColor = System.Drawing.Color.DimGray;
            this.picBorder_Bottom.Location = new System.Drawing.Point(0, 129);
            this.picBorder_Bottom.Name = "picBorder_Bottom";
            this.picBorder_Bottom.Size = new System.Drawing.Size(406, 1);
            this.picBorder_Bottom.TabIndex = 34;
            this.picBorder_Bottom.TabStop = false;
            // 
            // picBorder_Right
            // 
            this.picBorder_Right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBorder_Right.BackColor = System.Drawing.Color.DimGray;
            this.picBorder_Right.Location = new System.Drawing.Point(405, 0);
            this.picBorder_Right.Name = "picBorder_Right";
            this.picBorder_Right.Size = new System.Drawing.Size(1, 130);
            this.picBorder_Right.TabIndex = 32;
            this.picBorder_Right.TabStop = false;
            // 
            // picBorder_Left
            // 
            this.picBorder_Left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picBorder_Left.BackColor = System.Drawing.Color.DimGray;
            this.picBorder_Left.Location = new System.Drawing.Point(0, 0);
            this.picBorder_Left.Name = "picBorder_Left";
            this.picBorder_Left.Size = new System.Drawing.Size(1, 130);
            this.picBorder_Left.TabIndex = 33;
            this.picBorder_Left.TabStop = false;
            // 
            // picBorder_Top
            // 
            this.picBorder_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBorder_Top.BackColor = System.Drawing.Color.DimGray;
            this.picBorder_Top.Location = new System.Drawing.Point(0, 0);
            this.picBorder_Top.Name = "picBorder_Top";
            this.picBorder_Top.Size = new System.Drawing.Size(406, 1);
            this.picBorder_Top.TabIndex = 31;
            this.picBorder_Top.TabStop = false;
            // 
            // btn_Next
            // 
            this.btn_Next.BackgroundImage = global::Music_Player.Properties.Resources.NEXT;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(198, 95);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(30, 30);
            this.btn_Next.TabIndex = 29;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackgroundImage = global::Music_Player.Properties.Resources.PREVIOUS;
            this.btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Previous.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.ForeColor = System.Drawing.Color.White;
            this.btn_Previous.Location = new System.Drawing.Point(132, 95);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(30, 30);
            this.btn_Previous.TabIndex = 28;
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.BackgroundImage = global::Music_Player.Properties.Resources.PLAY;
            this.btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.ForeColor = System.Drawing.Color.White;
            this.btn_PlayPause.Location = new System.Drawing.Point(165, 95);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(30, 30);
            this.btn_PlayPause.TabIndex = 27;
            this.btn_PlayPause.UseVisualStyleBackColor = true;
            this.btn_PlayPause.Click += new System.EventHandler(this.BtnClick);
            // 
            // lbl_TrackName
            // 
            this.lbl_TrackName.Font = new System.Drawing.Font("DS-Digital", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrackName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_TrackName.Location = new System.Drawing.Point(132, 26);
            this.lbl_TrackName.Name = "lbl_TrackName";
            this.lbl_TrackName.Size = new System.Drawing.Size(268, 12);
            this.lbl_TrackName.TabIndex = 36;
            this.lbl_TrackName.Text = "Artist Track Name (feat. John Bigode & Jane doe)";
            this.lbl_TrackName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(406, 130);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.pic_AlbumArt);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lbl_ArtistName);
            this.Controls.Add(this.lbl_TotalTime);
            this.Controls.Add(this.lbl_CurrentTime);
            this.Controls.Add(this.lbl_TrackName);
            this.Controls.Add(this.picBorder_Bottom);
            this.Controls.Add(this.picBorder_Right);
            this.Controls.Add(this.picBorder_Left);
            this.Controls.Add(this.picBorder_Top);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_PlayPause);
            this.Controls.Add(this.btn_Repeat);
            this.Controls.Add(this.trkb_Position);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkb_Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder_Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.PictureBox pic_AlbumArt;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label lbl_ArtistName;
        private System.Windows.Forms.Label lbl_TotalTime;
        private System.Windows.Forms.Label lbl_CurrentTime;
        private System.Windows.Forms.PictureBox picBorder_Bottom;
        private System.Windows.Forms.PictureBox picBorder_Right;
        private System.Windows.Forms.PictureBox picBorder_Left;
        private System.Windows.Forms.PictureBox picBorder_Top;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_PlayPause;
        private System.Windows.Forms.Button btn_Repeat;
        private System.Windows.Forms.TrackBar trkb_Position;
        private System.Windows.Forms.Label lbl_TrackName;
    }
}

