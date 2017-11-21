using ClassLibrary.DAO;
using ClassLibrary.Model;
using System;

namespace ClassLibrary.Business
{
    public class SalesBusiness
    {
        public bool SaveSale(Sales sale)
        {
            try
            {
                SalesDAO dao = new SalesDAO();

                if (sale != null)
                {
                    sale.OpenedDateTime = DateTime.Now;

                    dao.InsertSale(sale);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir a venda no banco de dados! " + e.Message);
            }
        }
    }
}
