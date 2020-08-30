using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Group_Project
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGroup_Service" in both code and config file together.
    [ServiceContract]
    public interface IGroup_Service
    {
        //user management
        //login function
        [OperationContract]
        int login(string email, string password);

        //getting the user from the table
        [OperationContract]
        User_Table getUser(int id);

        //getting email
        [OperationContract]
        User_Table getEmail(string email, int id);

        //getting admin
        [OperationContract]
        Admin getAdmin(int id);

        //getting client
        [OperationContract]
        Client getClient(int id);

        //registering
        [OperationContract]
        string Register(string username, string password, string name, string email, string contactno, int active, string address, string surname = null, string businesstype = null, string usertype = "client");

        //updating the user
        [OperationContract]
        string UpdateInfo(string username, string name, string email, string contactno, string address, int id, string surname = null, string businesstype = null);

        //getting id
        [OperationContract]
        Mask_Type getMask(int id);

        //hash password
        //active 




        //Invoice
        //get the invoice
        [OperationContract]
        Order_Table getInvoice(int id);

        //getting the order items
        [OperationContract]
        Order_Item getItem(int id);

        //get all items
        //get all invoices



        //Product catalog
        [OperationContract]
        string addproducts(string name, string description, Decimal price, int active,int maskid, int admin, int quantity );

        [OperationContract]
        string editproduct(string name, string description, Decimal price,int id, int active, int maskid, int admin, int quantity);

        [OperationContract]
        string addtype(string name, string description, int admin);

        [OperationContract]
        string edittype(string name, string description, int admin,int id);

        [OperationContract]
        string addsize(string name, string dimensions);

        [OperationContract]
        string editsize(string name, string dimen, int id);

        [OperationContract]
        string addpsize(int sizeid, int psize);

        [OperationContract]
        string updatepsize(int sizeid, int psize, int id);

        [OperationContract]
        string addcustom(int pid, string filter, int size);

        [OperationContract]
        string editcustom(int pid, string filter, int size, int id);

        [OperationContract]
        List<Product> getallproducts();

        [OperationContract]
        Product getprod(int maskid);

        [OperationContract]
        Product getProduct(int id);


        [OperationContract]
        Product filterprod(Double min, Double max);
        //get custom
        //get size
        //get prod size from product table

        //list all custom
        //list all size
        //list all prod size from product table

        //Report

    }

}
