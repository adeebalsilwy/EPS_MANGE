using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPS.BL
{
   public class UpdateData
    {

        private double TotalValue1;
        private double TotalValue2;

        public void UpdateCustomerData()
        {
           
            try
            {

                DBEPSEntities db = new DBEPSEntities();
                // Add Supplier Value
                TB_Customers customers = new TB_Customers();
                var idcustomerlist = db.TB_Customers.Select(x => x.ID).ToList();

                for (int i = 0; i < idcustomerlist.Count; i++)
                {
                    var id = idcustomerlist[i];

                    customers = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();


                    if (customers != null)
                    {
                        var TotalValue = db.TB_Sell.Where(x => x.IDCustomer == id).Select(x => x.CustomerBalance).ToArray();
                        var TotalValue2 = db.TB_Sell.Where(x => x.IDCustomer == id).Select(x => x.CustomerBalanceprim).ToArray();
                        if (TotalValue != null)
                        {
                            customers.SupplierBalance = TotalValue.Sum();
                            customers.SupplierBalanceprim = TotalValue2.Sum();

                            db.Set<TB_Customers>().AddOrUpdate(customers);
                            db.SaveChanges();

                        }
                    }

                }

            }
            catch
            {
            }





        }





        public void UpdateSuppliersData()
        {
            try
            {

                DBEPSEntities db = new DBEPSEntities();
                // Add Supplier Value
                TB_Suppliers suppliers = new TB_Suppliers();
                var idsupplierlist = db.TB_Suppliers.Select(x => x.ID).ToList();

                for (int i = 0; i < idsupplierlist.Count; i++)
                {
                    var id = idsupplierlist[i];
                    suppliers = db.TB_Suppliers.Where(x => x.ID == id).FirstOrDefault();

                    if (suppliers != null)
                    {
                        TotalValue1 = (double)db.TB_Buy.Where(x => x.ID_Supplier == id).Select(x => x.SupplierPyment).ToArray().Sum();
                        TotalValue2 = (double)db.TB_Buy.Where(x => x.ID_Supplier == id).Select(x => x.SupplierPyment1).ToArray().Sum();
                        if (TotalValue1 != null || TotalValue2 != null)
                        {
                            suppliers.SupplierBalance = TotalValue1;
                            suppliers.SupplierBalancePrim = Convert.ToDouble(TotalValue2.ToString("#0.00"));

                            db.Set<TB_Suppliers>().AddOrUpdate(suppliers);
                            db.SaveChanges();

                        }
                    }






                }



            }
            catch
            {
            }
        }







        public void UpdatePaymentssData()
        {
            try
            {

                DBEPSEntities db = new DBEPSEntities();

                TB_Sell suppliers = new TB_Sell();
                var idsupplierlist = db.TB_Sell.Select(x => x.ID).ToList();

                for (int i = 0; i < idsupplierlist.Count; i++)
                {
                    var id = idsupplierlist[i];
                    suppliers = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();

                    if (suppliers != null)
                    {
                        TotalValue1 = (double)db.TB_Pyments.Where(x => x.IDSELL == id).Select(x => x.Paymentone).ToArray().Sum();
                        TotalValue2 = (double)db.TB_Pyments.Where(x => x.IDSELL == id).Select(x => x.CurrentPaymentone).ToArray().Sum();
                        if (TotalValue1 != null || TotalValue2 != null)
                        {
                            suppliers.CustomerBalance = TotalValue1 - TotalValue2;

                            db.Set<TB_Sell>().AddOrUpdate(suppliers);
                            db.SaveChanges();

                        }
                    }






                }



            }
            catch
            {
            }
        }
        }
}
