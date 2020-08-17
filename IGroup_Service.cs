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

        //get the invoice
        [OperationContract]
        Order_Table getInvoice(int id);

        //getting the order items
        [OperationContract]
        Order_Item getItem(int id);

        //registering
        [OperationContract]
        string Register(string username, string password, string name, string email,string contactno,int active, string address, string surname = null, string businesstype = null, string usertype = "client");

        //updating the user
        [OperationContract]
        string UpdateInfo(string username, string name, string email, string contactno,string address, int id, string surname = null, string businesstype = null);
    }

}
