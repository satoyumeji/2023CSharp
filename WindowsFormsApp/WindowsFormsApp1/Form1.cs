using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 画面が表示された時のイベント
        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessage.Text = "";
            // ラジオボタン１の値をラベル2に表示
            // ラジオボタン２の値をラベル3に表示
            // ニューメリックアップダウンの値をラベル4に表示
        }


        private void button1_Click(object sender, EventArgs e)
        {
            labelMessage.Text = textBoxName.Text 
                + "さん、こんにちは。";
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
   
        }
    }
}
