namespace CaculateGPA
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonCaluate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(35, 73);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowTemplate.Height = 23;
            this.dataGridViewTable.Size = new System.Drawing.Size(653, 265);
            this.dataGridViewTable.TabIndex = 2;
            // 
            // buttonCaluate
            // 
            this.buttonCaluate.Location = new System.Drawing.Point(319, 38);
            this.buttonCaluate.Name = "buttonCaluate";
            this.buttonCaluate.Size = new System.Drawing.Size(86, 23);
            this.buttonCaluate.TabIndex = 3;
            this.buttonCaluate.Text = "计算绩点";
            this.buttonCaluate.UseVisualStyleBackColor = true;
            this.buttonCaluate.Click += new System.EventHandler(this.buttonCaluate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(904, 28);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(110, 31);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "使用方法";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(732, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "    首先选择打开文件导入.xls的Excel文件，要表格一定包含课程名称，课程性质，成绩，补考成绩，重修成绩，学分这几列（要求列名和刚才说名称对上不然无法识别" +
    "）。之后点击计算绩点便得出结果。注意：如果成绩为非数字，请在导入之前或之后手动修改一下分数使之为一个数字。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(652, 346);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(380, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "绩点计算插件（壮哉我大北信科坑爹的绩点算法专用版） ©  凡爷制作";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(142, 38);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(89, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "打开文件...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "首先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "然后";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(732, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 103);
            this.label4.TabIndex = 13;
            this.label4.Text = "    内置不及格时将补考和重修成绩纳入考虑，若补考或重修及格绩点则为1，若均为不及格则此时该门课成绩绩点为0，且计算平均绩点是加入加权中计算。注：北信科绩点计算" +
    "方式为60-69为1绩点，70-79为2绩点，以此类推，最高绩点为4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCaluate);
            this.Controls.Add(this.dataGridViewTable);
            this.Name = "Form1";
            this.Text = "GPA计算";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonCaluate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

