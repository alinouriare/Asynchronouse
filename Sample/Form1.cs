using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async  void Click_Click(object sender, EventArgs e)
        {


            //label1.Text =await DowWorkAsync();
            //await SendMessageAsync();




            await Task.Run(() => { Thread.Sleep(5000); });
            MessageBox.Show("First Task");
            await Task.Run(() => { Thread.Sleep(5000); });
            MessageBox.Show("Second Task");
            await Task.Run(() => { Thread.Sleep(5000); });
            MessageBox.Show("Finish");


        }

        //private string DoWork()
        //{

        //    System.Threading.Thread.Sleep(10000);

        //    return "Hello Async ...";
        //}


        //private Task<string> DoWork()
        //{
        //    return Task.Run(() =>
        //  {

        //      System.Threading.Thread.Sleep(10000);
        //      return "Hello Async ...";

        //  });
        //}



        private async Task<string> DowWorkAsync()
        {

            return await Task.Run(() =>
            {
                Thread.Sleep(10000);
                return "Done .";
            }




            );
        }



        private async Task SendMessageAsync()
        {

            await Task.Run(()=>{

                Thread.Sleep(5000);
                MessageBox.Show("SendMessageAsync");
            });
        }
    }
}
