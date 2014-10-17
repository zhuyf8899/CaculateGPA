using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace CaculateGPA
{
    public partial class Form1 : Form
    {
        public DataTable dt_operate;
        string textBoxOpenPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCaluate_Click(object sender, EventArgs e)
        {
            DataTable dt_dest;
            double sumGPA = 0.0;
            double sumCredit = 0.0;
            int count = 0;
            try
            {
                dt_dest = new DataTable();
                dt_dest = dt_operate;
                while (!dt_dest.Rows[count][1].Equals("")) 
                {
                    double tempScore;
                    double tempGPA;
                    tempScore = Convert.ToDouble(dt_dest.Rows[count][2]);
                    switch ((int)(tempScore / 10))
                    {
                        case 10:
                            tempGPA = 4;
                            break;
                        case 9:
                            tempGPA = 4;
                            break;
                        case 8:
                            tempGPA = 3;
                            break;
                        case 7:
                            tempGPA = 2;
                            break;
                        case 6:
                            tempGPA = 1;
                            break;
                        default:
                            tempGPA = 0;
                            break;
                    }
                    if (tempGPA == 0)
                    {
                        double Scorebukao = 0.0;
                        double Scorechongxiu = 0.0;
                        if (!(dt_dest.Rows[count][4].ToString().Equals(""))) 
                        {
                            Scorebukao=(Convert.ToDouble(dt_dest.Rows[count][4].ToString()));
                        }
                        if (!(dt_dest.Rows[count][5].ToString().Equals(""))) 
                        {
                            Scorechongxiu=(Convert.ToDouble(dt_dest.Rows[count][5].ToString()));
                        }

                        if ( (Scorebukao>= 60) || (Scorechongxiu >= 60))
                            tempGPA = 1;
                        else
                            tempGPA = 0;
                    }
                    sumCredit += Convert.ToDouble(dt_dest.Rows[count][3].ToString());
                    sumGPA += (tempGPA * Convert.ToDouble(dt_dest.Rows[count][3].ToString()));
                    count++;
                }
                
            }
            catch (Exception err)
            {
                ;//MessageBox.Show(err.Message);
            }
            finally 
            {
                double res = sumGPA / sumCredit;
                MessageBox.Show("本次共统计科目"+(count)+"门，\n"+"计算总学分为："+ sumCredit.ToString()+"\n总绩点学分和为："+sumGPA.ToString()+"\n平均绩点为："+ res.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //选择打开文件路径触发的事件
            try
            {
                //打开文件对话框
                OpenFileDialog ofd = new OpenFileDialog();
                //默认路径
                ofd.InitialDirectory = @"D:\学习资料\windows程序设计\CaculateGPA";
                //筛选类型
                ofd.Filter = "Excel2003-2007 files|*.xls";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //从这个字符串获取打开内容
                    textBoxOpenPath = ofd.FileName;
                    //构造子字符串
                    string constr = "Provider = MicroSoft.Jet.OLEDB.4.0;" + "Data Source=" + textBoxOpenPath + ";Extended Properties = \"Excel 8.0;HDR=Yes;\";";
                    //实例化对象con打开数据源，源地址为变量textOpenPath的内容
                    OleDbConnection con = new OleDbConnection(constr);
                    con.Open();
                    //初始化表格
                   // DataTable dt = new DataTable();
                    //获取表格文件中的表
                    //dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    //实例化适配器对象oda，并且向源中发送SQL语句
                    OleDbDataAdapter oda = new OleDbDataAdapter("Select 课程名称,课程性质,成绩,学分,补考成绩,重修成绩 From [Sheet1$] WHERE 课程性质='公共基础课' OR 课程性质='专业基础课' OR 课程性质='专业课' OR 课程性质='必修课'", con);
                    //实例化内存中表格对象dtSource
                    dt_operate = new DataTable();
                    //适配器对象oda使用Fill方法填充内存中表格的dtSource
                    oda.Fill(dt_operate);
                    //将表单中dataSourceInfo源连接至dtSource
                    dataGridViewTable.DataSource = dt_operate;
                }
            }
            catch (Exception err)
            {
                //提供调试信息
                MessageBox.Show(err.Message);
            }
        }
    }
}
