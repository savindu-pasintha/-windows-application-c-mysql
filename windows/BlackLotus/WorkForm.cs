using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;
using BusinessLogic;
using DataLayer;

namespace BlackLotus
{
    public partial class WorkForm : Form
    {
        //this is a image file pathe get variable call to flowerimage brows button
        public String imgPath;

        //price calculation
        double y = 0;
        double z = 0;
        double p = 0;

        public WorkForm()
        {
            InitializeComponent();

            //order list box/combo box to flower table items set method
             listItemSet();
             comboFlower();

             OrderClass oc = new OrderClass();
            
        }
        //add button  CATEGORY
        private void XuiSuperButton2_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                CategoryClass obj = new CategoryClass();
                //check text box empty or not
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    obj.CategoryId = textBox1.Text;
                    obj.CategoryName = textBox2.Text;

                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.CategoryAdd() == 1)
                    {
                        MessageBox.Show("---Created new Cateogry---" + obj.CategoryName);
                    }
                    else
                    {
                        MessageBox.Show("---Can not create same category name again !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

                // Console.WriteLine("---ERROR IN SQL CONNECTION---");
                //    Console.WriteLine(ex);
            }

        }
        //update category button
        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {

            try
            {
                //text feild empty or not check
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    CategoryClass obj = new CategoryClass();
                    //pass to Business layer CategoryClass
                    obj.CategoryId = textBox1.Text;
                    obj.CategoryName = textBox2.Text;

                    if (obj.CategoryUpdate() == 1)
                    {
                        MessageBox.Show("---Updated Cateegory---");
                    }
                    else
                    {
                        MessageBox.Show("--- Cannot Update Category ---");

                    }
                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


        }

        //Category delete Button
        private void xuiSuperButton3_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                CategoryClass obj = new CategoryClass();
                //check text box empty or not
                if ((textBox1.Text != "") || (textBox2.Text != ""))
                {
                    obj.CategoryId = textBox1.Text;
                    obj.CategoryName = textBox2.Text;

                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.CategoryDelete() == 1)
                    {
                        String x;
                        x = obj.CategoryId;
                        x = obj.CategoryName;
                        MessageBox.Show("---Deleted Cateogry---" + x);
                    }
                    else
                    {
                        MessageBox.Show("---Can not  Delete category  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }

        }

        //Ctategory search button
        private void Categorysearch_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                CategoryClass obj = new CategoryClass();
                //check text box empty or not
                if (textBox1.Text != "")
                {
                    obj.CategoryId = textBox1.Text;
                    obj.CategoryName = textBox2.Text;

                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.CategorySearch() == 1)
                    {

                        textBox1.Text = obj.CategoryId;
                        textBox2.Text = obj.CategoryName;

                    }
                    else
                    {
                        MessageBox.Show("---Can not  Search category  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }

        }
       

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void xuiSuperButton12_Click(object sender, EventArgs e)
        {

        }
        //delete order
        private void xuiSuperButton13_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                OrderClass obj = new OrderClass();
                //check text box empty or not
                if (tdelOrder.Text != "") 
                {
                    obj.orderId = tdelOrder.Text;
                   
                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.orderDelete() == 1)
                    {
                       
                        MessageBox.Show("---Deleted order---");
                    }
                    else
                    {
                        MessageBox.Show("---Can not  Delete order  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }
        }

       
        //help button
        private void helpgobutton_Click(object sender, EventArgs e)
        {

            this.Hide();

            //open login and sign up control page
            LoginSignup loginsignupformobj = new LoginSignup();
            loginsignupformobj.Show();


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //view Category Dtabase tables coloums values
        private void refeshbutton_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryClass oobj = new CategoryClass();
                //Datas Set obj put to the Dtaview grid auto rende all the colums and values.
                ///you dont create custom table colums in Data grid grid
                //variable of data grid view+daat source
                dataGridView1.DataSource = oobj.categoryViewAll().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Order management Dta tables grids
        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewShip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //referesh Customer /order/shiping tables  Database Table colum data vies button
        private void RefreshOrderCustomerShippTable_Click(object sender, EventArgs e)
        {
            try
            {
                OrderClass oobj = new OrderClass();
                //Datas Set obj put to the Dtaview grid auto rende all the colums and values.
                ///you dont create custom table colums in Data grid grid
                //variable of data grid view+daat source
                dataGridViewOrder.DataSource = oobj.orderViewAll().Tables[0];

                OrderClass cus = new OrderClass();
                //Datas Set obj put to the Dtaview grid auto rende all the colums and values.
                ///you dont create custom table colums in Data grid grid
                //variable of data grid view+daat source
                dataGridViewCustomer.DataSource = cus.customerViewAll().Tables[0];


                OrderClass ship = new OrderClass();
                //Datas Set obj put to the Dtaview grid auto rende all the colums and values.
                ///you dont create custom table colums in Data grid grid
                //variable of data grid view+daat source
                dataGridViewShip.DataSource = ship.shipinViewAll().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Flower image Brows and image path catch
        private void BrowsButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog findFile = new OpenFileDialog();
                //Browser Box eke  ok button ek click kala nam
                if (findFile.ShowDialog() == DialogResult.OK)
                {
                    //set to view , picture box as a image
                    pictureBoxFlower.Image = Image.FromFile(findFile.FileName);
                    //file name view lable Variable
                    //  ImageName.Text = findFile.FileName;

                    imgPath = findFile.FileName;


                }
                else
                {
                    MessageBox.Show("can not show image  file");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Flower ADD
        private void xuiSuperButton5_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                FlowerClass obj = new FlowerClass();
                //check text box empty or not
                if ((textBoxFlowerCode.Text != "") && (textBoxFlowerName.Text != "") && (textBoxFlowerPriceOne.Text != ""))
                {
                    obj.flowerId = textBoxFlowerCode.Text;
                    obj.flowerName = textBoxFlowerName.Text;
                    obj.flowerPriceone = textBoxFlowerPriceOne.Text; ;
                    obj.flowerQuentity = textBoxFlowerQuentity.Text;
                  //  obj.flowerCategory = "category";
                    obj.flowerDescription = richTextBoxFlowerDiscription.Text;
                    obj.flowerCategory = flowerCombo.SelectedItem.ToString();

                    Image img = pictureBoxFlower.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                    obj.flowerImageFile = arr;


                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.flowerAdd() == 1)
                    {
                        MessageBox.Show("---Added new Flower---" + obj.flowerName);
                    }
                    else
                    {
                        MessageBox.Show("---Can not Add same Flower name again !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);
            }
        }

        //flower table combo box values
        public void comboFlower()
        {
            try
            {
                //combo box to values add
                String sql = " SELECT name FROM [BlackLotusDB].[dbo].[CategoryTable] ";
                SqlDataReader dr = DBClass.DataAdapterMethod(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        String val1 = dr["name"].ToString();
                        //  String val2 = dr["code"].ToString();
                        flowerCombo.Items.Add(val1);
                    }
                }
                else
                { MessageBox.Show("No items  In Category Table "); }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void flowerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                OrderClass obj = new OrderClass();
                //check text box empty or not
                if (tdelOrder.Text != "" )
                {
                    obj.orderId = tdelOrder.Text;
                    

                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.orderDelete() == 1)
                    {
                       
                        MessageBox.Show("---Deleted order---");
                    }
                    else
                    {
                        MessageBox.Show("---Can not  Delete order  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }
        }
        //Flower Update
        private void xuiSuperButton6_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                FlowerClass obj = new FlowerClass();
                //check text box empty or not
                if ((textBoxFlowerCode.Text != "") && (textBoxFlowerName.Text != "") && (textBoxFlowerPriceOne.Text != ""))
                {
                    obj.flowerId = textBoxFlowerCode.Text;
                    obj.flowerName = textBoxFlowerName.Text;
                    obj.flowerPriceone = textBoxFlowerPriceOne.Text; ;
                    obj.flowerQuentity = textBoxFlowerQuentity.Text;
                    obj.flowerCategory = "category";
                    obj.flowerDescription = richTextBoxFlowerDiscription.Text;

                    Image img = pictureBoxFlower.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                    obj.flowerImageFile = arr;


                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.flowerUpdate() == 1)
                    {
                        MessageBox.Show("---Updated  Flower---" + obj.flowerName);
                    }
                    else
                    {
                        MessageBox.Show("---Can not Update same Flower name again !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);
            }


        }

        //Flower delete
        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                FlowerClass obj = new FlowerClass();
                //check text box empty or not
                if (textBoxFlowerCode.Text != "")
                {
                    obj.flowerId = textBoxFlowerCode.Text;


                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.flowerDelete() == 1)
                    {
                        String x;
                        x = obj.flowerId;

                        MessageBox.Show("---Deleted Flower---" + x);
                    }
                    else
                    {
                        MessageBox.Show("---Can not  Delete Flower  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }
        }
        //flower search butoon
        private void flowerSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                FlowerClass obj = new FlowerClass();

                //check text box empty or not
                if (textBoxFlowerCode.Text != "")
                {
                    //set value to search 
                    obj.flowerId = textBoxFlowerCode.Text;
                    //obj.CategoryName = textBox2.Text;

                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.flowerSearch() == 1)
                    {
                        //out put values
                        textBoxFlowerCode.Text = obj.flowerId;
                        textBoxFlowerName.Text = obj.flowerName;
                        textBoxFlowerPriceOne.Text = obj.flowerPriceone;
                        textBoxFlowerQuentity.Text = obj.flowerQuentity;
                        //CategoryFbox.Text = obj.flowerCategory;
                        richTextBoxFlowerDiscription.Text = obj.flowerDescription;



                        //Bitmap Imag = obj.flowerSearch();
                        //pictureBoxFlower.Image = Imag;

                    }
                    else
                    {
                        MessageBox.Show("---Can not  Search category  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }

        }
        //Flower table refresh Dtabase Table Data
        private void RefreshFlower_Click(object sender, EventArgs e)
        {
            try
            {
                FlowerClass oobj = new FlowerClass();
                //Datas Set obj put to the Dtaview grid auto rende all the colums and values.
                ///you dont create custom table colums in Data grid grid
                //variable of data grid view+daat source
                dataGridViewFlower.DataSource = oobj.flowerViewAll().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //===================================================

        

        private void submit_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // search.Text = "20";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        //order details Add 
        private void xuiSuperButton7_Click(object sender, EventArgs e)
        {
            try
            {
                OrderClass oc = new OrderClass();

                oc.flowercategoryNameOrCode = oName.Text.ToString();
                oc.flowerId = oCode.Text.ToString();
                oc.flowerName = oName.Text.ToString();
                oc.flowerPriceone = oPrice.Text.ToString();
                // oc.orderId = "20";
                // oc.orderId = new Random().Next(0,1000000000).ToString();

                Random rm = new Random();
                oc.orderId = rm.Next(2147483647).ToString();

                oc.totalPrice = OTotal.Text.ToString();
                oc.flowerQuentity = oQuentity.Text.ToString();

                if ((oName.Text != "") && (oPrice.Text != "") && (oQuentity.Text != ""))
                    if (checkBoxO.Enabled)
                    {

                        if (oc.orderAdd() == 1)
                        {
                            MessageBox.Show("--- ADD Order Details ---");
                        }
                        else
                        {
                            MessageBox.Show("---Can not order !---");

                        }
                    }
                    else
                    {
                        MessageBox.Show("--- Please enter Values ! ---");
                    }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //total price add to text box
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if ((oName.Text != "") && (oPrice.Text != "") && (oQuentity.Text != ""))
            {
                z = Convert.ToDouble(oQuentity.Text.ToString());
                p = Convert.ToDouble(oPrice.Text.ToString());
                y = z * p;

                OTotal.Text = y.ToString();
            }
            else
            {
                MessageBox.Show("---Please enter values !---");
            }
        }
        //order Mnagement Customer details add
        private void xuiSuperButton8_Click(object sender, EventArgs e)
        {
            try
            {
                OrderClass oc = new OrderClass();

                if (checkBoxCus.Enabled)
                {
                    if ((CfirstName.Text != "") && (CfirstLast.Text != "") && (number.Text != "") && (email.Text != ""))
                    {
                        oc.firstName = CfirstName.Text.ToString();
                        oc.lastName = CfirstLast.Text.ToString();
                        oc.mobileNumber = number.Text.ToString();
                        oc.email = email.Text.ToString();

                        Random rm = new Random();
                        oc.orderId = rm.Next(2147483647).ToString();

                        if (oc.customerAdd() == 1)
                        { 
                            MessageBox.Show("Customer Details Added.");
                        }
                        else
                        {
                            MessageBox.Show("---Can not add !---");

                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Please fill your details.");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enable Check Box.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // delete order
        private void xuiSuperButton11_Click(object sender, EventArgs e)
        {

        }
        //shiping Add complete
        private void xuiSuperButton9_Click(object sender, EventArgs e)
        {
            try
            {
                OrderClass oc = new OrderClass();
                if ((addone.Text != "") && (addtwo.Text != "") && (country.Text != "") && (city.Text != "") && (postal.Text != ""))
                {
                    if (checkBoxS.Enabled)
                    {
                        oc.addressLineOne = addone.Text.ToString();
                        oc.addressLineTwo = addtwo.Text.ToString();
                        oc.city = city.Text.ToString();
                        oc.country = country.Text.ToString();
                        oc.postalCode = postal.Text.ToString();

                        Random rm = new Random();
                        oc.orderId = rm.Next(2147483647).ToString();
                    }

                    else
                    {

                        MessageBox.Show("Please Enable Check Box.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill your details.");
                }


                if (checkBoxSS.Enabled)
                {
                    if (oc.shipinDelatilsAdd() == 1)
                    {

                        MessageBox.Show("Order completed");

                    }
                    else
                    {

                        MessageBox.Show("Please Enable Check Box.");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void listItemSet()
        {
         //   comboOrder.Items.Insert(0, "Copenhagen"); ;
          //  comboOrder.Items.Insert(1, "Copenhagen");
           //  comboOrder.Items.Add("Three");
           // comboOrder.Items.Insert(x, arr[x]);
           //listBox.Items.Add("names");



            try
            {
                String sql = " SELECT name FROM [BlackLotusDB].[dbo].[FlowerTable] ";

                SqlDataReader dr = DBClass.DataAdapterMethod(sql);
                if (dr.HasRows)
                {
                   // dr.GetString("name");
                   // int i = 0;
                    //String[] arr = new String[i];

                    while (dr.Read())
                    {
                         String val1 = dr["name"].ToString();
                       //  String val2 = dr["code"].ToString();
                      orderListBox.Items.Add(val1);//order page list box
                      listBox2.Items.Add(val1);//order management list box
                        // comboOrder.Items.Add(val);
                        //
                        //
                        // string name = saReader.GetString(0);
                        // comboOrder.Items.Add(dr.GetString(0));
                    }


                }
                else
                {
                    MessageBox.Show("No items  In flowe Table ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //List box selected items views
        private void orderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT name,categoryNameOrCode,code,price FROM [BlackLotusDB].[dbo].[FlowerTable] WHERE name='"+ orderListBox.SelectedItem.ToString() + "' ";

                SqlDataReader dr = DBClass.DataAdapterMethod(sql);
                if (dr.HasRows)
                {
                    // dr.GetString("name");
                    int i = 0;
                    //String[] arr = new String[i];

                    while (dr.Read())
                    {
                        String val1 = dr["name"].ToString();
                        String val2 = dr["code"].ToString();
                        String val4 = dr["price"].ToString();
                        String val3 = dr["categoryNameOrCode"].ToString();

                        oName.Text = val1;
                        oCode.Text = val2;
                        oCategory.Text = val3;
                        oPrice.Text = val4;

                        
                    }


                }
                else
                {
                    MessageBox.Show("No items  In flowe Table ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxCus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSS_CheckedChanged(object sender, EventArgs e)
        {

        }
        //delete order Id
        private void xuiSuperButton13_Click_1(object sender, EventArgs e)
        {
            try
            {

                //value passs to business layer Logclass variable to
                OrderClass obj = new OrderClass();
                //check text box empty or not
                if (tdelOrder.Text != "")
                {
                    obj.orderId = tdelOrder.Text.ToString();

                    //  ExecuteNonQuery() if worked return value=truee return value=0 CtegoryClass in BusinessLayer
                    if (obj.orderDelete() == 1)
                    {

                        MessageBox.Show("---Deleted order---");
                    }
                    else
                    {
                        MessageBox.Show("---Can not  Delete order  !---");

                    }

                }
                else
                {
                    MessageBox.Show("---please enter values !---");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT name,categoryNameOrCode,code,price FROM [BlackLotusDB].[dbo].[FlowerTable] WHERE name='" + listBox2.SelectedItem.ToString() + "' ";

                SqlDataReader dr = DBClass.DataAdapterMethod(sql);
                if (dr.HasRows)
                {
                    // dr.GetString("name");
                    //int i = 0;
                    //String[] arr = new String[i];

                    while (dr.Read())
                    {
                        String val1 = dr["name"].ToString();
                        String val2 = dr["code"].ToString();
                        String val4 = dr["price"].ToString();
                        String val3 = dr["categoryNameOrCode"].ToString();

                        textBox21.Text = val1;
                        textBox24.Text = val2;
                        textBox3.Text = val3;
                        textBox4.Text = val4;

                        z = Convert.ToDouble(textBox25.Text.ToString());
                        p = Convert.ToDouble(textBox4.Text.ToString());
                        y = z * p;

                        textBox18.Text = y.ToString();


                    }


                }
                else
                {
                    MessageBox.Show("No items  In flower Table ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
