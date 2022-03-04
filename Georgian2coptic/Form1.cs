/// </summary>
/// Convert Gregorian date to Coptic date using C#
/// Copyright :Isaac Be Website: www.isaacbe.com
/// For more inquiries contact me at info@isaacbe.com
/// </summary>
/// 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Georgian2coptic
{
    public partial class Form1 : Form
    {

        Georgian2Coptic georgian2Coptic;
        public Form1()
        {
            InitializeComponent();
            georgian2Coptic = new Georgian2Coptic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            la_georgian.Text = georgian2Coptic. GetArabicGeorgianDateNow();
           var copticDate= georgian2Coptic.georgian2coptic(dateTime.Day, dateTime.Month, dateTime.Year);
            
            la_coptic.Text =copticDate.ToString();
        }
    }
}
