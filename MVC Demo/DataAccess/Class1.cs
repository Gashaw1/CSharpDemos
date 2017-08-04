//using system;
//using system.collections.generic;
//using system.linq;
//using system.web;
//using system.data;
//using system.data.sqlclient;
//using system.configuration;

//namespace dataaccess
//{
//    public class class1
//    {
//        public void test()
//        {

//            string sconnectionstring;

//            // modify the following string to correctly connect to your sql s\erver.
//            sconnectionstring = "password=;user id=sa;"
//                + "initial catalog=pubs;"
//                + "data source=(local)";

//            sqlconnection objconn
//                = new sqlconnection(sconnectionstring);
//            objconn.open();

//            // create an instance of a dataadapter.
//            sqldataadapter daauthors
//                = new sqldataadapter("select * from authors", objconn);

//            // create an instance of a dataset, and retrieve 
//            // data from the authors table.
//            dataset dspubs = new dataset("pubs");
//            daauthors.fillschema(dspubs, schematype.source, "");
//            daauthors.fill(dspubs, "authors");
//            //****************
//            // begin add code 
//            // create a new instance of a datatable.
//            datatable tblauthors;
//            tblauthors = dspubs.tables["authors"];

//            datarow drcurrent;
//            // obtain a new datarow object from the datatable.
//            drcurrent = tblauthors.newrow();

//            // set the datarow field values as necessary.
//            drcurrent["au_id"] = "993-21-3427";
//            drcurrent["au_fname"] = "george";
//            drcurrent["au_lname"] = "johnson";
//            drcurrent["phone"] = "800 226-0752";
//            drcurrent["address"] = "1956 arlington pl.";
//            drcurrent["city"] = "winnipeg";
//            drcurrent["state"] = "mb";
//            drcurrent["contract"] = 1;

//            // pass that new object into the add method of the datatable.
//            tblauthors.rows.add(drcurrent);
//            console.writeline("add was successful, click any key to continue!!");
//            console.readline();

//            // end add code   
//            //*****************
//            // begin edit code 

//            drcurrent = tblauthors.rows.find("213-46-8915");
//            drcurrent.beginedit();
//            drcurrent["phone"] = "342" + drcurrent["phone"].tostring().substring(3);
//            drcurrent.endedit();
//            console.writeline("record edited successfully, click any key to continue!!");
//            console.readline();

//            // end edit code   
//            //*****************
//            // begin send changes to sql server 

//            sqlcommandbuilder objcommandbuilder = new sqlcommandbuilder(daauthors);
//            daauthors.update(dspubs, "authors");
//            console.writeline("sql server updated successfully, check server explorer to see changes");
//            console.readline();

//            // end send changes to sql server 
//            //*****************
//            //begin delete code 

//            drcurrent = tblauthors.rows.find("993-21-3427");
//            drcurrent.delete();
//            console.writeline("srecord deleted successfully, click any key to continue!!");
//            console.readline();

//            //end delete code  
//            //*****************
//            // clean up sql server
//            daauthors.update(dspubs, "authors");
//            console.writeline("sql server updated successfully, check server explorer to see changes");
//            console.readline();

//        }\
//    }
//}
//}