namespace PizzaForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smallBtn = new System.Windows.Forms.RadioButton();
            this.mediumBtn = new System.Windows.Forms.RadioButton();
            this.largeBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.PepperoniBox = new System.Windows.Forms.CheckBox();
            this.sausageBtn = new System.Windows.Forms.CheckBox();
            this.baconBtn = new System.Windows.Forms.CheckBox();
            this.hamBtn = new System.Windows.Forms.CheckBox();
            this.pineappleBtn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipField = new System.Windows.Forms.TextBox();
            this.tipBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.endtotalLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.largeBtn);
            this.groupBox1.Controls.Add(this.mediumBtn);
            this.groupBox1.Controls.Add(this.smallBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Size";
            // 
            // smallBtn
            // 
            this.smallBtn.AutoSize = true;
            this.smallBtn.Location = new System.Drawing.Point(7, 20);
            this.smallBtn.Name = "smallBtn";
            this.smallBtn.Size = new System.Drawing.Size(99, 17);
            this.smallBtn.TabIndex = 0;
            this.smallBtn.TabStop = true;
            this.smallBtn.Text = "Small Pizza - $7";
            this.smallBtn.UseVisualStyleBackColor = true;
            // 
            // mediumBtn
            // 
            this.mediumBtn.AutoSize = true;
            this.mediumBtn.Location = new System.Drawing.Point(7, 44);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(111, 17);
            this.mediumBtn.TabIndex = 1;
            this.mediumBtn.TabStop = true;
            this.mediumBtn.Text = "Medium Pizza - $9";
            this.mediumBtn.UseVisualStyleBackColor = true;
            // 
            // largeBtn
            // 
            this.largeBtn.AutoSize = true;
            this.largeBtn.Location = new System.Drawing.Point(7, 68);
            this.largeBtn.Name = "largeBtn";
            this.largeBtn.Size = new System.Drawing.Size(107, 17);
            this.largeBtn.TabIndex = 2;
            this.largeBtn.TabStop = true;
            this.largeBtn.Text = "Large Pizza - $12";
            this.largeBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pineappleBtn);
            this.groupBox2.Controls.Add(this.hamBtn);
            this.groupBox2.Controls.Add(this.baconBtn);
            this.groupBox2.Controls.Add(this.sausageBtn);
            this.groupBox2.Controls.Add(this.PepperoniBox);
            this.groupBox2.Controls.Add(this.cheeseBox);
            this.groupBox2.Location = new System.Drawing.Point(153, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings ($1 each)";
            // 
            // cheeseBox
            // 
            this.cheeseBox.AutoSize = true;
            this.cheeseBox.Location = new System.Drawing.Point(7, 20);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(89, 17);
            this.cheeseBox.TabIndex = 0;
            this.cheeseBox.Text = "Extra Cheese";
            this.cheeseBox.UseVisualStyleBackColor = true;
            // 
            // PepperoniBox
            // 
            this.PepperoniBox.AutoSize = true;
            this.PepperoniBox.Location = new System.Drawing.Point(7, 44);
            this.PepperoniBox.Name = "PepperoniBox";
            this.PepperoniBox.Size = new System.Drawing.Size(74, 17);
            this.PepperoniBox.TabIndex = 1;
            this.PepperoniBox.Text = "Pepperoni";
            this.PepperoniBox.UseVisualStyleBackColor = true;
            // 
            // sausageBtn
            // 
            this.sausageBtn.AutoSize = true;
            this.sausageBtn.Location = new System.Drawing.Point(7, 68);
            this.sausageBtn.Name = "sausageBtn";
            this.sausageBtn.Size = new System.Drawing.Size(68, 17);
            this.sausageBtn.TabIndex = 2;
            this.sausageBtn.Text = "Sausage";
            this.sausageBtn.UseVisualStyleBackColor = true;
            // 
            // baconBtn
            // 
            this.baconBtn.AutoSize = true;
            this.baconBtn.Location = new System.Drawing.Point(7, 92);
            this.baconBtn.Name = "baconBtn";
            this.baconBtn.Size = new System.Drawing.Size(57, 17);
            this.baconBtn.TabIndex = 3;
            this.baconBtn.Text = "Bacon";
            this.baconBtn.UseVisualStyleBackColor = true;
            // 
            // hamBtn
            // 
            this.hamBtn.AutoSize = true;
            this.hamBtn.Location = new System.Drawing.Point(7, 116);
            this.hamBtn.Name = "hamBtn";
            this.hamBtn.Size = new System.Drawing.Size(48, 17);
            this.hamBtn.TabIndex = 4;
            this.hamBtn.Text = "Ham";
            this.hamBtn.UseVisualStyleBackColor = true;
            // 
            // pineappleBtn
            // 
            this.pineappleBtn.AutoSize = true;
            this.pineappleBtn.Location = new System.Drawing.Point(7, 140);
            this.pineappleBtn.Name = "pineappleBtn";
            this.pineappleBtn.Size = new System.Drawing.Size(73, 17);
            this.pineappleBtn.TabIndex = 5;
            this.pineappleBtn.Text = "Pineapple";
            this.pineappleBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.taxLbl);
            this.groupBox3.Controls.Add(this.subtotalLabel);
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(7, 20);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(79, 13);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "Subtotal: $0.00";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(7, 38);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(81, 13);
            this.taxLbl.TabIndex = 1;
            this.taxLbl.Text = "Tax (6%): $0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip Amount:  $";
            // 
            // tipField
            // 
            this.tipField.Location = new System.Drawing.Point(81, 13);
            this.tipField.Name = "tipField";
            this.tipField.Size = new System.Drawing.Size(44, 20);
            this.tipField.TabIndex = 3;
            this.tipField.Text = "0.00";
            // 
            // tipBtn
            // 
            this.tipBtn.Location = new System.Drawing.Point(32, 36);
            this.tipBtn.Name = "tipBtn";
            this.tipBtn.Size = new System.Drawing.Size(75, 23);
            this.tipBtn.TabIndex = 4;
            this.tipBtn.Text = "Leave Tip";
            this.tipBtn.UseVisualStyleBackColor = true;
            this.tipBtn.Click += new System.EventHandler(this.tipBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(174, 184);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 3;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(174, 213);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // endtotalLabel
            // 
            this.endtotalLabel.AutoSize = true;
            this.endtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtotalLabel.Location = new System.Drawing.Point(90, 261);
            this.endtotalLabel.Name = "endtotalLabel";
            this.endtotalLabel.Size = new System.Drawing.Size(111, 13);
            this.endtotalLabel.TabIndex = 5;
            this.endtotalLabel.Text = "Order Total: $0.00";
            this.endtotalLabel.Click += new System.EventHandler(this.endtotalLabel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tipBtn);
            this.groupBox4.Controls.Add(this.tipField);
            this.groupBox4.Location = new System.Drawing.Point(12, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 65);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tip (Optional)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.endtotalLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza Pricer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton largeBtn;
        private System.Windows.Forms.RadioButton mediumBtn;
        private System.Windows.Forms.RadioButton smallBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox pineappleBtn;
        private System.Windows.Forms.CheckBox hamBtn;
        private System.Windows.Forms.CheckBox baconBtn;
        private System.Windows.Forms.CheckBox sausageBtn;
        private System.Windows.Forms.CheckBox PepperoniBox;
        private System.Windows.Forms.CheckBox cheeseBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tipBtn;
        private System.Windows.Forms.TextBox tipField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label endtotalLabel;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

