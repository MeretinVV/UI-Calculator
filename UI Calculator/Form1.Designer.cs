namespace UI_Calculator
{
    partial class MainWindow
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
            this.equalBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.divideBtn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equalBtn
            // 
            this.equalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equalBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.equalBtn.FlatAppearance.BorderSize = 2;
            this.equalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.equalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalBtn.Location = new System.Drawing.Point(12, 357);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(310, 92);
            this.equalBtn.TabIndex = 0;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = false;
            this.equalBtn.Click += new System.EventHandler(this.GetAnswer);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatAppearance.BorderSize = 2;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(3, 219);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(71, 66);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "CE";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.Reset);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.decimalBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.zeroBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplyBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.threeBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.twoBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.oneBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.minusBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sixBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fiveBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.plusBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.nineBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eightBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 288);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // divideBtn
            // 
            this.divideBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divideBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divideBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.divideBtn.FlatAppearance.BorderSize = 2;
            this.divideBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.divideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideBtn.Location = new System.Drawing.Point(234, 219);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(73, 66);
            this.divideBtn.TabIndex = 16;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decimalBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.decimalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.decimalBtn.FlatAppearance.BorderSize = 2;
            this.decimalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.decimalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decimalBtn.Location = new System.Drawing.Point(157, 219);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(71, 66);
            this.decimalBtn.TabIndex = 15;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = false;
            this.decimalBtn.Click += new System.EventHandler(this.AddFloatingPoint);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zeroBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.zeroBtn.FlatAppearance.BorderSize = 2;
            this.zeroBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.zeroBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroBtn.Location = new System.Drawing.Point(80, 219);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(71, 66);
            this.zeroBtn.TabIndex = 14;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.multiplyBtn.FlatAppearance.BorderSize = 2;
            this.multiplyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.multiplyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyBtn.Location = new System.Drawing.Point(234, 147);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(73, 66);
            this.multiplyBtn.TabIndex = 13;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = false;
            this.multiplyBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // threeBtn
            // 
            this.threeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.threeBtn.FlatAppearance.BorderSize = 2;
            this.threeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.threeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeBtn.Location = new System.Drawing.Point(157, 147);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(71, 66);
            this.threeBtn.TabIndex = 12;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // twoBtn
            // 
            this.twoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.twoBtn.FlatAppearance.BorderSize = 2;
            this.twoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.twoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoBtn.Location = new System.Drawing.Point(80, 147);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(71, 66);
            this.twoBtn.TabIndex = 11;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // oneBtn
            // 
            this.oneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.oneBtn.FlatAppearance.BorderSize = 2;
            this.oneBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.oneBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneBtn.Location = new System.Drawing.Point(3, 147);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(71, 66);
            this.oneBtn.TabIndex = 10;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // minusBtn
            // 
            this.minusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minusBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.minusBtn.FlatAppearance.BorderSize = 2;
            this.minusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.minusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBtn.Location = new System.Drawing.Point(234, 75);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(73, 66);
            this.minusBtn.TabIndex = 9;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // sixBtn
            // 
            this.sixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sixBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sixBtn.FlatAppearance.BorderSize = 2;
            this.sixBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sixBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixBtn.Location = new System.Drawing.Point(157, 75);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(71, 66);
            this.sixBtn.TabIndex = 8;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.fiveBtn.FlatAppearance.BorderSize = 2;
            this.fiveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.fiveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveBtn.Location = new System.Drawing.Point(80, 75);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(71, 66);
            this.fiveBtn.TabIndex = 7;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // fourBtn
            // 
            this.fourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.fourBtn.FlatAppearance.BorderSize = 2;
            this.fourBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.fourBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourBtn.Location = new System.Drawing.Point(3, 75);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(71, 66);
            this.fourBtn.TabIndex = 6;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // plusBtn
            // 
            this.plusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plusBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.plusBtn.FlatAppearance.BorderSize = 2;
            this.plusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.plusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(234, 3);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(73, 66);
            this.plusBtn.TabIndex = 5;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // nineBtn
            // 
            this.nineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nineBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.nineBtn.FlatAppearance.BorderSize = 2;
            this.nineBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.nineBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineBtn.Location = new System.Drawing.Point(157, 3);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(71, 66);
            this.nineBtn.TabIndex = 4;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // eightBtn
            // 
            this.eightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eightBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.eightBtn.FlatAppearance.BorderSize = 2;
            this.eightBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.eightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightBtn.Location = new System.Drawing.Point(80, 3);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(71, 66);
            this.eightBtn.TabIndex = 3;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sevenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sevenBtn.FlatAppearance.BorderSize = 2;
            this.sevenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sevenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenBtn.Location = new System.Drawing.Point(3, 3);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(71, 66);
            this.sevenBtn.TabIndex = 2;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.ButtonClick);
            // 
            // resultLbl
            // 
            this.resultLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(12, 8);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(307, 55);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "0";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.equalBtn);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
    }
}

