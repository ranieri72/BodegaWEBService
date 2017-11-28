using BodegaAdmin.localhost;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BodegaAdmin
{
    class GenerateList
    {
        public static ListView GenerateListView(ListView listView, List<Object> listObjects, string[] columnName, int[] columnWidth)
        {
            try
            {
                ListViewItem item;
                PropertyInfo[] props;
                int columnIndex = columnName.Length;
                listView.Clear();

                if (listObjects[0] is Products)
                {
                    props = typeof(Products).GetProperties();
                }
                else
                {
                    props = typeof(Sales).GetProperties();
                }

                for (int i = 0; i < columnIndex; i++)
                {
                    ColumnHeader col = new ColumnHeader();
                    listView.Columns.Add(col);
                    col.Text = columnName[i];
                    col.Width = columnWidth[i];
                }

                foreach (Object obj in listObjects)
                {
                    item = listView.Items.Add("");

                    //foreach (PropertyInfo p in props)
                    for (int x = 0; x < columnIndex; x++)
                    {
                        if (x == 0)
                        {
                            item.Text = props[x].GetValue(obj, null).ToString();
                        }
                        else
                        {
                            if (props[x].GetValue(obj, null) != null)
                            {
                                item.SubItems.Add(props[x].GetValue(obj, null).ToString());
                            }
                        }
                    }
                }
                return listView;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
