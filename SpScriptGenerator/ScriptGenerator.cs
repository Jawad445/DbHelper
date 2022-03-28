using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpScriptGenerator
{
    public partial class ScriptGenerator : Form
    {
        private readonly string connetionString;
        public ScriptGenerator()
        {
            connetionString = @"Server=ec2-35-179-99-242.eu-west-2.compute.amazonaws.com;database=iQCRM_Dev;UID=sa;password=$qL@sT1Quest";
            InitializeComponent();
        }

       

        private void generate_Click(object sender, EventArgs e)
        {
            string directory = @"D:\SqlGenerator";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            string type = (cbtype.Text).Trim();
            //string Querytype = (qtype.Text).Trim();
            string text = sps.Text.Trim();
            string[] split = text.Split('\n');
            string data = string.Empty;
            string fileName = @"D:\SqlGenerator\spscript.sql";
            if(!File.Exists(fileName))
                File.Create(fileName);
            StreamWriter fs = File.CreateText(fileName);
            //var response = GetViewQuery();
            foreach (var sp in split)
            {
                data = CreateConnection(sp);
                if (!string.IsNullOrEmpty(data))
                {
                    if (type == "ALTER")
                    {
                        data = data.Replace("CREATE PROCEDURE", "ALTER PROCEDURE");
                    }

                    data = data + "\n GO \n";
                }
                
                fs.Write(data.ToString());
            }

            fs.Close();
            errorMessage.Text = "Script Generated Successfully.";
        }

        private string CreateConnection(string spname)
        {
            string data = string.Empty;
            try
            {
                using (var cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand($"SELECT VIEW_DEFINITION FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = '{spname}' ", cnn);
                    //SqlCommand cmd = new SqlCommand($"EXEC sp_helptext '{spname}'", cnn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data += reader[0].ToString();
                        }
                    }
                    cnn.Close();

                }
            }
            catch (Exception ex)
            {
                errorMessage.Text = ex.Message;
            }
            return data;
        }

        //private string GetViewQuery(string name = "LeadsFact_vw")
        //{
        //    string schema = "rpt";
        //    string data = string.Empty;
        //    try
        //    {
        //        using (var cnn = new SqlConnection(connetionString))
        //        {
        //            cnn.Open();

        //            SqlCommand cmd = new SqlCommand($"SELECT VIEW_DEFINITION FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = '{name}' AND TABLE_SCHEMA ='{schema}' ", cnn);
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    data += reader[0].ToString();
        //                }
        //            }
        //            cnn.Close();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        errorMessage.Text = ex.Message;
        //    }
        //    return data;
        //}

        private void ScriptGenerator_Load(object sender, EventArgs e)
        {
            qtype.Text = "Store Procedure";
            cbtype.Text = "CREATE";
        }

    }
}
