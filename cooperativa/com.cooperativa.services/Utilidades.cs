using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.services
{
    public class Utilidades
    {
        public void CargarCombo(ComboBox combo, IList Lista, string Value, string Text, string InsertaFila) {
            try
            {
                if (InsertaFila != "")
                {
                    Lista.Add(new Item(InsertaFila, 3));
                }
                combo.DisplayMember = Text;
                combo.ValueMember = Value;
                combo.DataSource = Lista;
            }
            catch (Exception ex) {
                throw (ex); 
            }
   
        }


        public void CargarCheckList(CheckedListBox combo, IList Lista, string Value, string Text, string InsertaFila)
        {
            try
            {
                if (InsertaFila != "")
                {
                    Lista.Add(new Item(InsertaFila, 3));
                }
                combo.DisplayMember = Text;
                combo.ValueMember = Value;
                combo.DataSource = Lista;
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}
