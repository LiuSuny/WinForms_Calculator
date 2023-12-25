namespace WindowsFormsApp_Calculator
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
            this.tbDisplayResult = new System.Windows.Forms.TextBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btndotSymbol = new System.Windows.Forms.Button();
            this.btnSubstractSymbol = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnDivisionSymbol = new System.Windows.Forms.Button();
            this.btnMultiplicationSymbol = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqualSymbol = new System.Windows.Forms.Button();
            this.btnAdditionSymbol = new System.Windows.Forms.Button();
            this.IbCurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDisplayResult
            // 
            this.tbDisplayResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisplayResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDisplayResult.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayResult.Location = new System.Drawing.Point(0, 0);
            this.tbDisplayResult.Multiline = true;
            this.tbDisplayResult.Name = "tbDisplayResult";
            this.tbDisplayResult.Size = new System.Drawing.Size(255, 64);
            this.tbDisplayResult.TabIndex = 0;
            this.tbDisplayResult.Text = "0";
            this.tbDisplayResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            this.btnCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCE.BackColor = System.Drawing.Color.Ivory;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(0, 70);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(66, 40);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.CE_Button_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(0, 162);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(66, 40);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btn7
            // 
            this.btn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(0, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(66, 40);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(0, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 40);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btndotSymbol
            // 
            this.btndotSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndotSymbol.BackColor = System.Drawing.Color.Black;
            this.btndotSymbol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndotSymbol.ForeColor = System.Drawing.Color.White;
            this.btndotSymbol.Location = new System.Drawing.Point(0, 254);
            this.btndotSymbol.Name = "btndotSymbol";
            this.btndotSymbol.Size = new System.Drawing.Size(66, 40);
            this.btndotSymbol.TabIndex = 1;
            this.btndotSymbol.Text = ".";
            this.btndotSymbol.UseVisualStyleBackColor = false;
            this.btndotSymbol.Click += new System.EventHandler(this.button_click);
            // 
            // btnSubstractSymbol
            // 
            this.btnSubstractSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubstractSymbol.BackColor = System.Drawing.Color.Yellow;
            this.btnSubstractSymbol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstractSymbol.Location = new System.Drawing.Point(188, 162);
            this.btnSubstractSymbol.Name = "btnSubstractSymbol";
            this.btnSubstractSymbol.Size = new System.Drawing.Size(66, 40);
            this.btnSubstractSymbol.TabIndex = 1;
            this.btnSubstractSymbol.Text = "-";
            this.btnSubstractSymbol.UseVisualStyleBackColor = false;
            this.btnSubstractSymbol.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnC
            // 
            this.btnC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC.BackColor = System.Drawing.Color.Ivory;
            this.btnC.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(58, 70);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(66, 40);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.C_Button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Ivory;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(123, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "<";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(58, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(66, 40);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btnDivisionSymbol
            // 
            this.btnDivisionSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivisionSymbol.BackColor = System.Drawing.Color.Yellow;
            this.btnDivisionSymbol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisionSymbol.Location = new System.Drawing.Point(188, 70);
            this.btnDivisionSymbol.Name = "btnDivisionSymbol";
            this.btnDivisionSymbol.Size = new System.Drawing.Size(66, 40);
            this.btnDivisionSymbol.TabIndex = 1;
            this.btnDivisionSymbol.Text = "/";
            this.btnDivisionSymbol.UseVisualStyleBackColor = false;
            this.btnDivisionSymbol.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnMultiplicationSymbol
            // 
            this.btnMultiplicationSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiplicationSymbol.BackColor = System.Drawing.Color.Yellow;
            this.btnMultiplicationSymbol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicationSymbol.Location = new System.Drawing.Point(188, 116);
            this.btnMultiplicationSymbol.Name = "btnMultiplicationSymbol";
            this.btnMultiplicationSymbol.Size = new System.Drawing.Size(66, 40);
            this.btnMultiplicationSymbol.TabIndex = 1;
            this.btnMultiplicationSymbol.Text = "*";
            this.btnMultiplicationSymbol.UseVisualStyleBackColor = false;
            this.btnMultiplicationSymbol.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(58, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(66, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(123, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(66, 40);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(58, 162);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(66, 40);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(123, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(66, 40);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(123, 162);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(66, 40);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn0
            // 
            this.btn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(58, 254);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(66, 40);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // btnEqualSymbol
            // 
            this.btnEqualSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEqualSymbol.BackColor = System.Drawing.Color.Yellow;
            this.btnEqualSymbol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqualSymbol.Location = new System.Drawing.Point(116, 254);
            this.btnEqualSymbol.Name = "btnEqualSymbol";
            this.btnEqualSymbol.Size = new System.Drawing.Size(138, 40);
            this.btnEqualSymbol.TabIndex = 1;
            this.btnEqualSymbol.Text = "=";
            this.btnEqualSymbol.UseVisualStyleBackColor = false;
            this.btnEqualSymbol.Click += new System.EventHandler(this.EqualToOperator_click);
            // 
            // btnAdditionSymbol
            // 
            this.btnAdditionSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdditionSymbol.BackColor = System.Drawing.Color.Yellow;
            this.btnAdditionSymbol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditionSymbol.Location = new System.Drawing.Point(188, 208);
            this.btnAdditionSymbol.Name = "btnAdditionSymbol";
            this.btnAdditionSymbol.Size = new System.Drawing.Size(66, 40);
            this.btnAdditionSymbol.TabIndex = 1;
            this.btnAdditionSymbol.Text = "+";
            this.btnAdditionSymbol.UseVisualStyleBackColor = false;
            this.btnAdditionSymbol.Click += new System.EventHandler(this.Operator_Click);
            // 
            // IbCurrentOp
            // 
            this.IbCurrentOp.AutoSize = true;
            this.IbCurrentOp.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbCurrentOp.Location = new System.Drawing.Point(-3, 5);
            this.IbCurrentOp.Name = "IbCurrentOp";
            this.IbCurrentOp.Size = new System.Drawing.Size(0, 14);
            this.IbCurrentOp.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(256, 292);
            this.Controls.Add(this.IbCurrentOp);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btndotSymbol);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivisionSymbol);
            this.Controls.Add(this.btnMultiplicationSymbol);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnAdditionSymbol);
            this.Controls.Add(this.btnSubstractSymbol);
            this.Controls.Add(this.btnEqualSymbol);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.tbDisplayResult);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplayResult;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btndotSymbol;
        private System.Windows.Forms.Button btnSubstractSymbol;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnDivisionSymbol;
        private System.Windows.Forms.Button btnMultiplicationSymbol;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqualSymbol;
        private System.Windows.Forms.Button btnAdditionSymbol;
        private System.Windows.Forms.Label IbCurrentOp;
    }
}

