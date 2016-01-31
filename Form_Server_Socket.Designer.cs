namespace ServerSocketApp
{
    partial class Form_Server_Socket
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.lbl_server_msg_show = new System.Windows.Forms.Label();
            this.lbl_rercieved_msg = new System.Windows.Forms.Label();
            this.lbl_server_status = new System.Windows.Forms.Label();
            this.btn_start_server = new System.Windows.Forms.Button();
            this.btn_start_listen = new System.Windows.Forms.Button();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Controls.Add(this.btn_start_listen);
            this.panel_container.Controls.Add(this.lbl_server_msg_show);
            this.panel_container.Controls.Add(this.lbl_rercieved_msg);
            this.panel_container.Controls.Add(this.lbl_server_status);
            this.panel_container.Controls.Add(this.btn_start_server);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(486, 302);
            this.panel_container.TabIndex = 0;
            // 
            // lbl_server_msg_show
            // 
            this.lbl_server_msg_show.AutoSize = true;
            this.lbl_server_msg_show.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_server_msg_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.lbl_server_msg_show.Location = new System.Drawing.Point(146, 200);
            this.lbl_server_msg_show.Name = "lbl_server_msg_show";
            this.lbl_server_msg_show.Size = new System.Drawing.Size(91, 21);
            this.lbl_server_msg_show.TabIndex = 6;
            this.lbl_server_msg_show.Text = "nothing got";
            // 
            // lbl_rercieved_msg
            // 
            this.lbl_rercieved_msg.AutoSize = true;
            this.lbl_rercieved_msg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_rercieved_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.lbl_rercieved_msg.Location = new System.Drawing.Point(28, 200);
            this.lbl_rercieved_msg.Name = "lbl_rercieved_msg";
            this.lbl_rercieved_msg.Size = new System.Drawing.Size(117, 21);
            this.lbl_rercieved_msg.TabIndex = 5;
            this.lbl_rercieved_msg.Text = "Received Msg : ";
            // 
            // lbl_server_status
            // 
            this.lbl_server_status.AutoSize = true;
            this.lbl_server_status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_server_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.lbl_server_status.Location = new System.Drawing.Point(28, 129);
            this.lbl_server_status.Name = "lbl_server_status";
            this.lbl_server_status.Size = new System.Drawing.Size(131, 21);
            this.lbl_server_status.TabIndex = 4;
            this.lbl_server_status.Text = "Server Status : off";
            // 
            // btn_start_server
            // 
            this.btn_start_server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(55)))));
            this.btn_start_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_start_server.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_start_server.FlatAppearance.BorderSize = 0;
            this.btn_start_server.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_start_server.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_start_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_server.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_server.ForeColor = System.Drawing.Color.White;
            this.btn_start_server.Location = new System.Drawing.Point(174, 22);
            this.btn_start_server.Name = "btn_start_server";
            this.btn_start_server.Size = new System.Drawing.Size(165, 29);
            this.btn_start_server.TabIndex = 3;
            this.btn_start_server.Text = "Start the Server";
            this.btn_start_server.UseVisualStyleBackColor = false;
            this.btn_start_server.Click += new System.EventHandler(this.btn_conct_server_Click);
            // 
            // btn_start_listen
            // 
            this.btn_start_listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(55)))));
            this.btn_start_listen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_start_listen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_start_listen.FlatAppearance.BorderSize = 0;
            this.btn_start_listen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_start_listen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_start_listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_listen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_listen.ForeColor = System.Drawing.Color.White;
            this.btn_start_listen.Location = new System.Drawing.Point(174, 68);
            this.btn_start_listen.Name = "btn_start_listen";
            this.btn_start_listen.Size = new System.Drawing.Size(165, 29);
            this.btn_start_listen.TabIndex = 7;
            this.btn_start_listen.Text = "Start Listning";
            this.btn_start_listen.UseVisualStyleBackColor = false;
            this.btn_start_listen.Click += new System.EventHandler(this.btn_start_listen_Click);
            // 
            // Form_Server_Socket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 302);
            this.Controls.Add(this.panel_container);
            this.Name = "Form_Server_Socket";
            this.Text = "Server Socket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Label lbl_server_msg_show;
        private System.Windows.Forms.Label lbl_rercieved_msg;
        private System.Windows.Forms.Label lbl_server_status;
        private System.Windows.Forms.Button btn_start_server;
        private System.Windows.Forms.Button btn_start_listen;
    }
}

