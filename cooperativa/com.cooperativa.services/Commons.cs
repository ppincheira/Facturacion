using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace com.cooperativa.services
{
    public class Commons
    {
        public DataTable convertToTable<T>(IList<T> list)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                if (prop.Name != "EntityState" && prop.Name != "EntityKey")
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
           
            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    if (prop.Name != "EntityState" && prop.Name != "EntityKey")
                    {
                        //if (prop.GetValue(item).ToString().Contains("System.Data.Common.Internal.Materialization.CompensatingCollection"))
                        //{
                          
                        //    IEnumerable<decimal> pepe = (IEnumerable<decimal>)prop.GetValue(item);
                            
                        //    //(new System.Linq.SystemCore_EnumerableDebugView<decimal>(((System.Data.Common.Internal.Materialization.CompensatingCollection<decimal>)(prop.GetValue(item))))).Items[0]
                        //}else{
                       
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                       // }
                    }
                table.Rows.Add(row);
            }
            return table;
        }

        public void ValidarNumeroEntero(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Tab))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void ValidarNumeroDecimal(object sender, System.Windows.Forms.KeyPressEventArgs e, TextBox textBox)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }

    
}
